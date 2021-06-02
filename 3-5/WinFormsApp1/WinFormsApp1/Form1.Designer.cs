
namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.VehicalName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DistanceTraveled = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentFuel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxFuel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weight_class = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity_wheel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.changeBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nameText = new System.Windows.Forms.TextBox();
            this.currWeight = new System.Windows.Forms.TextBox();
            this.currAge = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.binarySerialize = new System.Windows.Forms.Button();
            this.xmlSerialize = new System.Windows.Forms.Button();
            this.jsonSerialize = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.binaryDeserialize = new System.Windows.Forms.Button();
            this.xmlDeserialize = new System.Windows.Forms.Button();
            this.jsonDeserialize = new System.Windows.Forms.Button();
            this.delBtn = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VehicalName,
            this.DistanceTraveled,
            this.currentFuel,
            this.maxFuel,
            this.weight_class,
            this.quantity_wheel});
            this.dataGridView.Location = new System.Drawing.Point(12, 304);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 25;
            this.dataGridView.Size = new System.Drawing.Size(828, 280);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // VehicalName
            // 
            this.VehicalName.HeaderText = "Name";
            this.VehicalName.MinimumWidth = 6;
            this.VehicalName.Name = "VehicalName";
            this.VehicalName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DistanceTraveled
            // 
            this.DistanceTraveled.HeaderText = "Weight";
            this.DistanceTraveled.MinimumWidth = 6;
            this.DistanceTraveled.Name = "DistanceTraveled";
            this.DistanceTraveled.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // currentFuel
            // 
            this.currentFuel.HeaderText = "Age";
            this.currentFuel.MinimumWidth = 6;
            this.currentFuel.Name = "currentFuel";
            this.currentFuel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // maxFuel
            // 
            this.maxFuel.HeaderText = "Blood";
            this.maxFuel.MinimumWidth = 6;
            this.maxFuel.Name = "maxFuel";
            this.maxFuel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // weight_class
            // 
            this.weight_class.HeaderText = "Warm class";
            this.weight_class.MinimumWidth = 6;
            this.weight_class.Name = "weight_class";
            this.weight_class.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // quantity_wheel
            // 
            this.quantity_wheel.HeaderText = "Cold class";
            this.quantity_wheel.MinimumWidth = 6;
            this.quantity_wheel.Name = "quantity_wheel";
            this.quantity_wheel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(12, 106);
            this.addButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(272, 39);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Cold-blooded",
            "Warm-blooded"});
            this.comboBox1.Location = new System.Drawing.Point(429, 58);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(133, 28);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // changeBtn
            // 
            this.changeBtn.Location = new System.Drawing.Point(290, 106);
            this.changeBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.changeBtn.Name = "changeBtn";
            this.changeBtn.Size = new System.Drawing.Size(272, 39);
            this.changeBtn.TabIndex = 4;
            this.changeBtn.Text = "Change";
            this.changeBtn.UseVisualStyleBackColor = true;
            this.changeBtn.Click += new System.EventHandler(this.changeBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Weight";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(338, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Age";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(466, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Blood";
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(12, 58);
            this.nameText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(133, 27);
            this.nameText.TabIndex = 12;
            // 
            // currWeight
            // 
            this.currWeight.Location = new System.Drawing.Point(151, 58);
            this.currWeight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.currWeight.Name = "currWeight";
            this.currWeight.Size = new System.Drawing.Size(133, 27);
            this.currWeight.TabIndex = 13;
            // 
            // currAge
            // 
            this.currAge.Location = new System.Drawing.Point(290, 58);
            this.currAge.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.currAge.Name = "currAge";
            this.currAge.Size = new System.Drawing.Size(133, 27);
            this.currAge.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(626, 443);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(587, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "Class warm";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(730, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 20);
            this.label9.TabIndex = 23;
            this.label9.Text = "Class cold";
            // 
            // binarySerialize
            // 
            this.binarySerialize.Location = new System.Drawing.Point(12, 187);
            this.binarySerialize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.binarySerialize.Name = "binarySerialize";
            this.binarySerialize.Size = new System.Drawing.Size(133, 31);
            this.binarySerialize.TabIndex = 24;
            this.binarySerialize.Text = "Binary";
            this.binarySerialize.UseVisualStyleBackColor = true;
            this.binarySerialize.Click += new System.EventHandler(this.binarySerialize_Click);
            // 
            // xmlSerialize
            // 
            this.xmlSerialize.Location = new System.Drawing.Point(12, 226);
            this.xmlSerialize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.xmlSerialize.Name = "xmlSerialize";
            this.xmlSerialize.Size = new System.Drawing.Size(133, 31);
            this.xmlSerialize.TabIndex = 25;
            this.xmlSerialize.Text = "XML";
            this.xmlSerialize.UseVisualStyleBackColor = true;
            this.xmlSerialize.Click += new System.EventHandler(this.xmlSerialize_Click);
            // 
            // jsonSerialize
            // 
            this.jsonSerialize.Location = new System.Drawing.Point(12, 265);
            this.jsonSerialize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.jsonSerialize.Name = "jsonSerialize";
            this.jsonSerialize.Size = new System.Drawing.Size(133, 31);
            this.jsonSerialize.TabIndex = 26;
            this.jsonSerialize.Text = "JSON";
            this.jsonSerialize.UseVisualStyleBackColor = true;
            this.jsonSerialize.Click += new System.EventHandler(this.jsonSerialize_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 163);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 20);
            this.label10.TabIndex = 27;
            this.label10.Text = "Serialize";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(160, 163);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 20);
            this.label11.TabIndex = 28;
            this.label11.Text = "Deserialize";
            // 
            // binaryDeserialize
            // 
            this.binaryDeserialize.Location = new System.Drawing.Point(151, 187);
            this.binaryDeserialize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.binaryDeserialize.Name = "binaryDeserialize";
            this.binaryDeserialize.Size = new System.Drawing.Size(133, 31);
            this.binaryDeserialize.TabIndex = 29;
            this.binaryDeserialize.Text = "Binary";
            this.binaryDeserialize.UseVisualStyleBackColor = true;
            this.binaryDeserialize.Click += new System.EventHandler(this.binaryDeserialize_Click);
            // 
            // xmlDeserialize
            // 
            this.xmlDeserialize.Location = new System.Drawing.Point(151, 226);
            this.xmlDeserialize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.xmlDeserialize.Name = "xmlDeserialize";
            this.xmlDeserialize.Size = new System.Drawing.Size(133, 31);
            this.xmlDeserialize.TabIndex = 30;
            this.xmlDeserialize.Text = "XML";
            this.xmlDeserialize.UseVisualStyleBackColor = true;
            this.xmlDeserialize.Click += new System.EventHandler(this.xmlDeserialize_Click);
            // 
            // jsonDeserialize
            // 
            this.jsonDeserialize.Location = new System.Drawing.Point(151, 265);
            this.jsonDeserialize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.jsonDeserialize.Name = "jsonDeserialize";
            this.jsonDeserialize.Size = new System.Drawing.Size(133, 31);
            this.jsonDeserialize.TabIndex = 31;
            this.jsonDeserialize.Text = "JSON";
            this.jsonDeserialize.UseVisualStyleBackColor = true;
            this.jsonDeserialize.Click += new System.EventHandler(this.jsonDeserialize_Click);
            // 
            // delBtn
            // 
            this.delBtn.Location = new System.Drawing.Point(568, 106);
            this.delBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(272, 39);
            this.delBtn.TabIndex = 32;
            this.delBtn.Text = "Delete";
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.button7_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Fish",
            "Bird",
            "Mamml"});
            this.comboBox2.Location = new System.Drawing.Point(568, 58);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(133, 28);
            this.comboBox2.TabIndex = 34;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Reptile",
            "Amphibian"});
            this.comboBox3.Location = new System.Drawing.Point(707, 58);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(133, 28);
            this.comboBox3.TabIndex = 35;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(290, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(550, 29);
            this.button1.TabIndex = 36;
            this.button1.Text = "Adapter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(290, 187);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(550, 29);
            this.button2.TabIndex = 37;
            this.button2.Text = "Composite";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(290, 265);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(550, 29);
            this.button3.TabIndex = 38;
            this.button3.Text = "Facade";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 594);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.jsonDeserialize);
            this.Controls.Add(this.xmlDeserialize);
            this.Controls.Add(this.binaryDeserialize);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.jsonSerialize);
            this.Controls.Add(this.xmlSerialize);
            this.Controls.Add(this.binarySerialize);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.currAge);
            this.Controls.Add(this.currWeight);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.changeBtn);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.dataGridView);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button changeBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.TextBox currWeight;
        private System.Windows.Forms.TextBox currAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn VehicalName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DistanceTraveled;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentFuel;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxFuel;
        private System.Windows.Forms.DataGridViewTextBoxColumn weight_class;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity_wheel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button binarySerialize;
        private System.Windows.Forms.Button xmlSerialize;
        private System.Windows.Forms.Button jsonSerialize;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button binaryDeserialize;
        private System.Windows.Forms.Button xmlDeserialize;
        private System.Windows.Forms.Button jsonDeserialize;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

