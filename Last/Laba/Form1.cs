using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using Laba.GalaxyTypes;
using Newtonsoft.Json;
using PluginBase;
using Formatting = Newtonsoft.Json.Formatting;

namespace Laba
{
    public partial class Form1 : Form, IHost
    {
        private List<Galaxy> Galaxies = new();
        int rowIndex;
        private readonly PluginManager pluginManager = new();
        public Form1()
        {
            InitializeComponent();
            InitializePlugins();
        }

        private void InitializePlugins()
        {
            pluginManager.ScanPlugins(AppDomain.CurrentDomain.BaseDirectory + "\\Plugins\\");
            var menuStrip = new MenuStrip {
            Parent = this};
            var mi = (ToolStripMenuItem)menuStrip.Items.Add("Plugins");
            foreach (var plugin in pluginManager.Plugins)
            {
                var item = mi.DropDownItems.Add(plugin.Name);
                item.Click += delegate { plugin.Run(this); };
            }
        }

        public string GetXml()
        {
            var writer = new StringWriter();
            var formatter = new XmlSerializer(typeof(List<Galaxy>));
            formatter.Serialize(writer, Galaxies);
            return writer.ToString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = dataGridView.CurrentCell.RowIndex;

            textName.Text = dataGridView[0, rowIndex].Value.ToString();
            textCount.Text = dataGridView[1, rowIndex].Value.ToString();

            if(Galaxies[rowIndex] is EllipticClass)
            {
                comboType.SelectedIndex = 0;
                comboElliptic.Text = dataGridView[3, rowIndex].Value.ToString();
                comboLens.Enabled = false;
                comboLens.Text = "";
                comboSpiral.Enabled = false;
                comboSpiral.Text = "";
                comboUncorrect.Enabled = false;
                comboUncorrect.Text = "";
            } else if(Galaxies[rowIndex] is LensClass)
            {
                comboType.SelectedIndex = 1;
                comboElliptic.Enabled = false;
                comboElliptic.Text = "";
                comboLens.Text = dataGridView[4, rowIndex].Value.ToString();
                comboSpiral.Enabled = false;
                comboSpiral.Text = "";
                comboUncorrect.Enabled = false;
                comboUncorrect.Text = "";
            } else if(Galaxies[rowIndex] is SpiralClass)
            {
                comboType.SelectedIndex = 2;
                comboElliptic.Enabled = false;
                comboElliptic.Text = "";
                comboLens.Enabled = false;
                comboLens.Text = "";
                comboSpiral.Text = dataGridView[5, rowIndex].Value.ToString();
                comboUncorrect.Enabled = false;
                comboUncorrect.Text = "";
            } else if(Galaxies[rowIndex] is UncorrectClass)
            {
                comboType.SelectedIndex = 3;
                comboElliptic.Enabled = false;
                comboElliptic.Text = "";
                comboLens.Enabled = false;
                comboLens.Text = "";
                comboSpiral.Enabled = false;
                comboSpiral.Text = "";
                comboUncorrect.Text = dataGridView[6, rowIndex].Value.ToString();
            }
        }

        private void setDataGridView()
        {
            dataGridView.Rows.Clear();

            foreach(Galaxy item in Galaxies)
            {
                if(item is EllipticClass)
                {
                    dataGridView.Rows.Add(item.Name, item.Count, "Elliptic", (item as EllipticClass).EllipticType, "-", "-", "-");
                } else if(item is LensClass)
                {
                    dataGridView.Rows.Add(item.Name, item.Count, "Lens", "-", (item as LensClass).LensType, "-", "-");
                } else if(item is SpiralClass)
                {
                    dataGridView.Rows.Add(item.Name, item.Count, "Spiral", "-", "-", (item as SpiralClass).SpiralType, "-");
                } else
                {
                    dataGridView.Rows.Add(item.Name, item.Count, "Uncorrect", "-", "-", "-",(item as UncorrectClass).UncorrectType);
                }
            }
        }

        private void comboTypeIndexChange(object sender, EventArgs e)
        {
            if(comboType.SelectedIndex == 0)
            {
                comboElliptic.Enabled = true;
                comboLens.Enabled = false;
                comboLens.Text = "";
                comboSpiral.Enabled = false;
                comboSpiral.Text = "";
                comboUncorrect.Enabled = false;
                comboUncorrect.Text = "";
            } else if(comboType.SelectedIndex == 1)
            {
                comboElliptic.Enabled = false;
                comboElliptic.Text = "";
                comboLens.Enabled = true;
                comboSpiral.Enabled = false;
                comboSpiral.Text = "";
                comboUncorrect.Enabled = false;
                comboUncorrect.Text = "";
            } else if(comboType.SelectedIndex == 2)
            {
                comboElliptic.Enabled = false;
                comboElliptic.Text = "";
                comboLens.Enabled = false;
                comboLens.Text = "";
                comboSpiral.Enabled = true;
                comboUncorrect.Enabled = false;
                comboUncorrect.Text = "";
            } else
            {
                comboElliptic.Enabled = false;
                comboElliptic.Text = "";
                comboLens.Enabled = false;
                comboLens.Text = "";
                comboSpiral.Enabled = false;
                comboSpiral.Text = "";
                comboUncorrect.Enabled = true;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e){
            try
            {
                if(comboType.SelectedIndex == 0)
                {
                    EllipticClass elliptic = new EllipticClass(
                        textName.Text, Convert.ToInt32(textCount.Text), comboElliptic.Text);
                    Galaxies.Add(elliptic);
                    dataGridView.Rows.Add(elliptic.Name, elliptic.Count, "Elliptic", elliptic.EllipticType, "-", "-", "-");
                } else if(comboType.SelectedIndex == 1)
                {
                    LensClass lens = new LensClass(
                        textName.Text, Convert.ToInt32(textCount.Text), comboLens.Text);
                    Galaxies.Add(lens);
                    dataGridView.Rows.Add(lens.Name, lens.Count, "Lens","-", lens.LensType, "-", "-");
                } else if(comboType.SelectedIndex == 2)
                {
                    SpiralClass spiral = new SpiralClass(
                        textName.Text, Convert.ToInt32(textCount.Text), comboSpiral.Text);
                    Galaxies.Add(spiral);
                    dataGridView.Rows.Add(spiral.Name, spiral.Count, "Spiral", "-", "-", spiral.SpiralType, "-");
                } else
                {
                    UncorrectClass uncorrect = new UncorrectClass(
                        textName.Text, Convert.ToInt32(textCount.Text), comboUncorrect.Text);
                    Galaxies.Add(uncorrect);
                    dataGridView.Rows.Add(uncorrect.Name, uncorrect.Count, "Uncorrect", "-", "-", "-", uncorrect.UncorrectType);
                }
            }
            catch (Exception)
            {
                MessageBox.Show(@"Ошибка ввода");
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if(comboType.SelectedIndex == 0)
                {
                    EllipticClass elliptic = (EllipticClass)Galaxies[rowIndex];
                    elliptic.Name = textName.Text;
                    elliptic.Count = Convert.ToInt32(textCount.Text);
                    elliptic.EllipticType = comboElliptic.Text;
                    dataGridView[0, rowIndex].Value = elliptic.Name;
                    dataGridView[1, rowIndex].Value = elliptic.Count;
                    dataGridView[2, rowIndex].Value = comboType.Text;
                    dataGridView[3, rowIndex].Value = comboElliptic.Text;
                } else if(comboType.SelectedIndex == 1)
                {
                    LensClass lens = (LensClass)Galaxies[rowIndex];
                    lens.Name = textName.Text;
                    lens.Count = Convert.ToInt32(textCount.Text);
                    lens.LensType = comboLens.Text;
                    dataGridView[0, rowIndex].Value = lens.Name;
                    dataGridView[1, rowIndex].Value = lens.Count;
                    dataGridView[2, rowIndex].Value = comboType.Text;
                    dataGridView[4, rowIndex].Value = comboLens.Text;
                }
                else if (comboType.SelectedIndex == 2)
                {
                    SpiralClass spiral = (SpiralClass)Galaxies[rowIndex];
                    spiral.Name = textName.Text;
                    spiral.Count = Convert.ToInt32(textCount.Text);
                    spiral.SpiralType = comboSpiral.Text;
                    dataGridView[0, rowIndex].Value = spiral.Name;
                    dataGridView[1, rowIndex].Value = spiral.Count;
                    dataGridView[2, rowIndex].Value = comboType.Text;
                    dataGridView[5, rowIndex].Value = comboSpiral.Text;
                } else
                {
                    UncorrectClass uncorrect = (UncorrectClass)Galaxies[rowIndex];
                    uncorrect.Name = textName.Text;
                    uncorrect.Count = Convert.ToInt32(textCount.Text);
                    uncorrect.UncorrectType = comboUncorrect.Text;
                    dataGridView[0, rowIndex].Value = uncorrect.Name;
                    dataGridView[1, rowIndex].Value = uncorrect.Count;
                    dataGridView[2, rowIndex].Value = comboType.Text;
                    dataGridView[6, rowIndex].Value = comboUncorrect.Text;
                }
            }
            catch (Exception)
            {
                MessageBox.Show(@"Некорректная замена. Не меняйте тип галактик после их определения");
            }

        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView.Rows.RemoveAt(rowIndex);
            }
            catch(Exception)
            {
                MessageBox.Show(@"Отсутствуют элементы");
            }
        }

        private void BinarySer_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using FileStream file = new FileStream("Galaxies.dat", FileMode.OpenOrCreate);
            formatter.Serialize(file, Galaxies);
        }

        private void XMLSer_Click(object sender, EventArgs e)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(List<Galaxy>));
            using FileStream file = new FileStream("Galaxies.xml", FileMode.OpenOrCreate);
            formatter.Serialize(file, Galaxies);
        }

        private void JSONSer_Click(object sender, EventArgs e)
        {
            using StreamWriter write = new StreamWriter("Galaxies.json", false, Encoding.Default);
            string jsonTypeNameAll = JsonConvert.SerializeObject(Galaxies, Formatting.Indented, new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.Auto
            });
            write.Write(jsonTypeNameAll);
        }

        private void BinaryDes_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using FileStream file = new FileStream("Galaxies.dat", FileMode.OpenOrCreate);
            Galaxies = (List<Galaxy>)formatter.Deserialize(file);
            setDataGridView();
        }

        private void XMLDes_Click(object sender, EventArgs e)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(List<Galaxy>));
            using FileStream file = new FileStream("Galaxies.xml", FileMode.OpenOrCreate);
            Galaxies = (List<Galaxy>)formatter.Deserialize(file);
            setDataGridView();
        }

        private void JSONDes_Click(object sender, EventArgs e)
        {
            using StreamReader reader = new StreamReader("Galaxies.json");
            Galaxies = JsonConvert.DeserializeObject<List<Galaxy>>(reader.ReadToEnd(), new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.Auto
            });
            setDataGridView();
        }

        private void buttonFacade_Click(object sender, EventArgs e)
        {
            Subsystem1 subsystem1 = new Subsystem1();
            Subsystem2 subsystem2 = new Subsystem2();
            Facade facade = new Facade(subsystem1, subsystem2);
            Client.ClientCode(facade);
        }

        private void buttonCommand_Click(object sender, EventArgs e)
        {

        }

        private void buttonPipe_Click(object sender, EventArgs e)
        {

        }
    }
}
