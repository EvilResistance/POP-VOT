using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using Newtonsoft.Json;
using WinFormsApp1.Animals;
using Formatting = Newtonsoft.Json.Formatting;
using PluginBase;
using System.IO.Pipes;

namespace WinFormsApp1
{
    public partial class Form1 : Form, IHost
    {
        private List<Animal> _animals = new();
        int row_index;
        private readonly PluginManager _pm = new();
        public Form1()
        {
            InitializeComponent();
            InitializePlugins();
        }
        private void InitializePlugins()
        {
            _pm.ScanPlugins(AppDomain.CurrentDomain.BaseDirectory + "\\Plugins\\");
            var menuStrip = new MenuStrip {Parent = this};
            var mi = (ToolStripMenuItem) menuStrip.Items.Add("Plugins");
            foreach (var plugin in _pm.Plugins)
            {
                var item = mi.DropDownItems.Add(plugin.Name);
                item.Click += delegate { plugin.Run(this); }; 
            }
        }
        
        public string GetXml()
        {
            var sw = new StringWriter();
            var formatter = new XmlSerializer(typeof(List<Animal>));
            formatter.Serialize(sw, _animals);
            return sw.ToString();
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            dataGridView.RowHeadersVisible = false;
            dataGridView.AllowUserToAddRows = false;
        }

        private void SetDataGridView()
        {
            dataGridView.Rows.Clear();

            foreach (Animal item in _animals)
            {
                if (item is WarmC)
                {
                    dataGridView.Rows.Add(
                    item.Name,
                    item.Weight,
                    item.Age.CurrentAge,
                    "Warm",
                    (item as WarmC).TypeW,
                    "-"
                    );
                }
                else
                {
                    dataGridView.Rows.Add(
                    item.Name,
                    item.Weight,
                    item.Age.CurrentAge,
                    "Cold",
                    "-",
                    (item as ColdC).TypeC
                    );
                }
            }
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row_index = dataGridView.CurrentCell.RowIndex;

            nameText.Text = dataGridView[0, row_index].Value.ToString();
            currWeight.Text = dataGridView[1, row_index].Value.ToString();
            currAge.Text = dataGridView[2, row_index].Value.ToString();

            if (_animals[row_index] is WarmC)
            {
                comboBox1.SelectedIndex = 1;
                comboBox2.Text = dataGridView[5, row_index].Value.ToString();
                comboBox3.Enabled = false;
            }
            else
            {
                comboBox1.SelectedIndex = 0;
                comboBox2.Text = "-";
                comboBox3.Text = dataGridView[4, row_index].Value.ToString();
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    ColdC cold = new ColdC(
                        Convert.ToInt32(currWeight.Text),
                        nameText.Text, Convert.ToInt32(currAge.Text),
                        comboBox3.Text
                        );
                    _animals.Add(cold);

                    dataGridView.Rows.Add(
                        cold.Name,
                        cold.Weight,
                        cold.Age.CurrentAge,
                        "Cold",
                        "-",
                        cold.TypeC
                        );
                }
                else
                {
                    WarmC warm = new WarmC(
                        Convert.ToInt32(currWeight.Text),
                        nameText.Text, Convert.ToInt32(currAge.Text),
                        comboBox2.Text
                        );
                    _animals.Add(warm);

                    dataGridView.Rows.Add(
                        warm.Name,
                        warm.Weight,
                        warm.Age.CurrentAge,
                        "Warm",
                        warm.TypeW,
                        "-"
                        );
                }
            }
            catch (Exception)
            {
                MessageBox.Show(@"Ошибка ввода");
            }
        }

        private void changeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    ColdC cold = (ColdC)_animals[row_index];
                    cold.Name = nameText.Text;
                    cold.Weight = Convert.ToInt32(currWeight.Text);
                    cold.Age.CurrentAge = Convert.ToInt32(currAge.Text);

                    cold.TypeC = comboBox3.Text;

                    dataGridView[0, row_index].Value = cold.Name;
                    dataGridView[1, row_index].Value = cold.Weight;
                    dataGridView[2, row_index].Value = cold.Age.CurrentAge;
                    dataGridView[5, row_index].Value = comboBox3.Text;
                }
                else
                {
                    WarmC warm = (WarmC)_animals[row_index];
                    warm.Name = nameText.Text;
                    warm.Weight = Convert.ToInt32(currWeight.Text);
                    warm.Age.CurrentAge = Convert.ToInt32(currAge.Text);
                    warm.TypeW = comboBox2.Text;

                    dataGridView[0, row_index].Value = warm.Name;
                    dataGridView[1, row_index].Value = warm.Weight;
                    dataGridView[2, row_index].Value = warm.Age.CurrentAge;
                    dataGridView[4, row_index].Value = warm.TypeW;
                }
            }
            catch (Exception) { MessageBox.Show(@"Некорректное действие"); }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                comboBox2.Enabled = false;
                comboBox3.Enabled = true;
            }
            else
            {
                comboBox3.Enabled = false;
                comboBox2.Enabled = true;
            }
        }

        private void binarySerialize_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using FileStream fs = new FileStream("animals.dat", FileMode.OpenOrCreate);
            formatter.Serialize(fs, _animals);
        }

        private void binaryDeserialize_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using FileStream fs = new FileStream("animals.dat", FileMode.OpenOrCreate);
            _animals = (List<Animal>)formatter.Deserialize(fs);
            SetDataGridView();
        }

        private void xmlSerialize_Click(object sender, EventArgs e)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(List<Animal>));
            using FileStream fs = new FileStream("animals.xml", FileMode.OpenOrCreate);
            formatter.Serialize(fs, _animals);
        }

        private void xmlDeserialize_Click(object sender, EventArgs e)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(List<Animal>));
            using FileStream fs = new FileStream("animals.xml", FileMode.OpenOrCreate);
            _animals = (List<Animal>)formatter.Deserialize(fs);
            SetDataGridView();
        }

        private void jsonSerialize_Click(object sender, EventArgs e)
        {
            using StreamWriter sw = new StreamWriter("animals.json", false, System.Text.Encoding.Default);
            string jsonTypeNameAll = JsonConvert.SerializeObject(_animals, Formatting.Indented, new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.Auto
            });
            sw.Write(jsonTypeNameAll);
        }

        private void jsonDeserialize_Click(object sender, EventArgs e)
        {
            using StreamReader sr = new StreamReader("animals.json");
            List<Animal> vehical = JsonConvert.DeserializeObject<List<Animal>>(sr.ReadToEnd(), new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.Auto
            });
            SetDataGridView();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int delet = dataGridView.SelectedCells[0].RowIndex;
            dataGridView.Rows.RemoveAt(delet);
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Animal exemple = new Animal();
            //Coldblooded cold = new Coldblooded();
            //exemple.ptrintT(cold);
            Warmblooded warm = new Warmblooded();
            Adapter warmExemple = new WarmToColdAdapter(warm);
            exemple.ptrintT(warmExemple);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Component list = new Association("Animals");
                String scold = "", swarm = "";

                Component warmBlooded = new Association("Warm-blooded");
                Component coldBlooded = new Association("Cold-blooded");
                list.Add(warmBlooded);
                list.Add(coldBlooded);
                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    if (dataGridView[3, i].Value.ToString().Equals("Cold"))
                    {
                        scold += dataGridView[5, i].Value.ToString() + dataGridView[0, i].Value.ToString() + "\n";
                    }
                    else
                    {
                        swarm += dataGridView[4, i].Value.ToString() + dataGridView[0, i].Value.ToString() + "\n";
                    }
                }
                Component cs = new Unit(scold);
                Component cs2 = new Unit(swarm);
                coldBlooded.Add(cs);
                warmBlooded.Add(cs2);
                list.Print();
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Subsystem1 subsystem1 = new Subsystem1();
            Subsystem2 subsystem2 = new Subsystem2();
            Facade facade = new Facade(subsystem1, subsystem2);
            Client.ClientCode(facade);
        }
    }
}
