
using System;

namespace Laba
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
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elliptic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lens = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spiral = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uncorrect = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textName = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.textCount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboType = new System.Windows.Forms.ComboBox();
            this.comboElliptic = new System.Windows.Forms.ComboBox();
            this.comboLens = new System.Windows.Forms.ComboBox();
            this.comboSpiral = new System.Windows.Forms.ComboBox();
            this.comboUncorrect = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.BinarySer = new System.Windows.Forms.Button();
            this.XMLSer = new System.Windows.Forms.Button();
            this.JSONSer = new System.Windows.Forms.Button();
            this.BinaryDes = new System.Windows.Forms.Button();
            this.XMLDes = new System.Windows.Forms.Button();
            this.JSONDes = new System.Windows.Forms.Button();
            this.buttonFacade = new System.Windows.Forms.Button();
            this.buttonPipe = new System.Windows.Forms.Button();
            this.buttonCommand = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.count,
            this.type,
            this.elliptic,
            this.lens,
            this.spiral,
            this.uncorrect});
            this.dataGridView.Location = new System.Drawing.Point(15, 43);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 29;
            this.dataGridView.Size = new System.Drawing.Size(1031, 247);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            // 
            // count
            // 
            this.count.HeaderText = "Systems count";
            this.count.MinimumWidth = 6;
            this.count.Name = "count";
            // 
            // type
            // 
            this.type.HeaderText = "Galaxy Type";
            this.type.MinimumWidth = 6;
            this.type.Name = "type";
            // 
            // elliptic
            // 
            this.elliptic.HeaderText = "Elliptic class";
            this.elliptic.MinimumWidth = 6;
            this.elliptic.Name = "elliptic";
            // 
            // lens
            // 
            this.lens.HeaderText = "Lens class";
            this.lens.MinimumWidth = 6;
            this.lens.Name = "lens";
            // 
            // spiral
            // 
            this.spiral.HeaderText = "Spiral class";
            this.spiral.MinimumWidth = 6;
            this.spiral.Name = "spiral";
            // 
            // uncorrect
            // 
            this.uncorrect.HeaderText = "Uncorrect class";
            this.uncorrect.MinimumWidth = 6;
            this.uncorrect.Name = "uncorrect";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(15, 319);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(140, 27);
            this.textName.TabIndex = 1;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(15, 293);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(49, 20);
            this.label.TabIndex = 2;
            this.label.Text = "Name";
            // 
            // textCount
            // 
            this.textCount.Location = new System.Drawing.Point(161, 319);
            this.textCount.Name = "textCount";
            this.textCount.Size = new System.Drawing.Size(140, 27);
            this.textCount.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 293);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Systems count";
            // 
            // comboType
            // 
            this.comboType.FormattingEnabled = true;
            this.comboType.Items.AddRange(new object[] {
            "Elliptic",
            "Lens",
            "Spiral",
            "Uncorrect"});
            this.comboType.Location = new System.Drawing.Point(307, 318);
            this.comboType.Name = "comboType";
            this.comboType.Size = new System.Drawing.Size(140, 28);
            this.comboType.TabIndex = 5;
            this.comboType.SelectedIndexChanged += new System.EventHandler(this.comboTypeIndexChange);
            // 
            // comboElliptic
            // 
            this.comboElliptic.FormattingEnabled = true;
            this.comboElliptic.Items.AddRange(new object[] {
            "E0",
            "E1",
            "E2",
            "E3",
            "E4",
            "E5",
            "E6",
            "E7"});
            this.comboElliptic.Location = new System.Drawing.Point(453, 318);
            this.comboElliptic.Name = "comboElliptic";
            this.comboElliptic.Size = new System.Drawing.Size(140, 28);
            this.comboElliptic.TabIndex = 6;
            // 
            // comboLens
            // 
            this.comboLens.FormattingEnabled = true;
            this.comboLens.Items.AddRange(new object[] {
            "S0",
            "SB0"});
            this.comboLens.Location = new System.Drawing.Point(599, 318);
            this.comboLens.Name = "comboLens";
            this.comboLens.Size = new System.Drawing.Size(140, 28);
            this.comboLens.TabIndex = 7;
            // 
            // comboSpiral
            // 
            this.comboSpiral.FormattingEnabled = true;
            this.comboSpiral.Items.AddRange(new object[] {
            "Sa",
            "Sb",
            "Sc",
            "Sd"});
            this.comboSpiral.Location = new System.Drawing.Point(745, 318);
            this.comboSpiral.Name = "comboSpiral";
            this.comboSpiral.Size = new System.Drawing.Size(140, 28);
            this.comboSpiral.TabIndex = 8;
            // 
            // comboUncorrect
            // 
            this.comboUncorrect.FormattingEnabled = true;
            this.comboUncorrect.Items.AddRange(new object[] {
            "SB",
            "SBa",
            "SBb",
            "SBc",
            "SBm"});
            this.comboUncorrect.Location = new System.Drawing.Point(891, 318);
            this.comboUncorrect.Name = "comboUncorrect";
            this.comboUncorrect.Size = new System.Drawing.Size(155, 28);
            this.comboUncorrect.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(307, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Galaxy type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(453, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Elliptic class";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(599, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Lens class";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(745, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Spiral class";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(891, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Uncorrect class";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(45, 352);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(308, 48);
            this.buttonAdd.TabIndex = 15;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(359, 352);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(331, 48);
            this.buttonEdit.TabIndex = 16;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(696, 352);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(315, 48);
            this.buttonRemove.TabIndex = 17;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(161, 424);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Serialize";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(478, 424);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Deserialize";
            // 
            // BinarySer
            // 
            this.BinarySer.Location = new System.Drawing.Point(45, 447);
            this.BinarySer.Name = "BinarySer";
            this.BinarySer.Size = new System.Drawing.Size(308, 48);
            this.BinarySer.TabIndex = 20;
            this.BinarySer.Text = "Binary";
            this.BinarySer.UseVisualStyleBackColor = true;
            this.BinarySer.Click += new System.EventHandler(this.BinarySer_Click);
            // 
            // XMLSer
            // 
            this.XMLSer.Location = new System.Drawing.Point(45, 501);
            this.XMLSer.Name = "XMLSer";
            this.XMLSer.Size = new System.Drawing.Size(308, 48);
            this.XMLSer.TabIndex = 21;
            this.XMLSer.Text = "XML";
            this.XMLSer.UseVisualStyleBackColor = true;
            this.XMLSer.Click += new System.EventHandler(this.XMLSer_Click);
            // 
            // JSONSer
            // 
            this.JSONSer.Location = new System.Drawing.Point(45, 558);
            this.JSONSer.Name = "JSONSer";
            this.JSONSer.Size = new System.Drawing.Size(308, 48);
            this.JSONSer.TabIndex = 22;
            this.JSONSer.Text = "JSON";
            this.JSONSer.UseVisualStyleBackColor = true;
            this.JSONSer.Click += new System.EventHandler(this.JSONSer_Click);
            // 
            // BinaryDes
            // 
            this.BinaryDes.Location = new System.Drawing.Point(359, 447);
            this.BinaryDes.Name = "BinaryDes";
            this.BinaryDes.Size = new System.Drawing.Size(331, 48);
            this.BinaryDes.TabIndex = 23;
            this.BinaryDes.Text = "Binary";
            this.BinaryDes.UseVisualStyleBackColor = true;
            this.BinaryDes.Click += new System.EventHandler(this.BinaryDes_Click);
            // 
            // XMLDes
            // 
            this.XMLDes.Location = new System.Drawing.Point(359, 501);
            this.XMLDes.Name = "XMLDes";
            this.XMLDes.Size = new System.Drawing.Size(331, 48);
            this.XMLDes.TabIndex = 24;
            this.XMLDes.Text = "XML";
            this.XMLDes.UseVisualStyleBackColor = true;
            this.XMLDes.Click += new System.EventHandler(this.XMLDes_Click);
            // 
            // JSONDes
            // 
            this.JSONDes.Location = new System.Drawing.Point(359, 558);
            this.JSONDes.Name = "JSONDes";
            this.JSONDes.Size = new System.Drawing.Size(331, 48);
            this.JSONDes.TabIndex = 25;
            this.JSONDes.Text = "JSON";
            this.JSONDes.UseVisualStyleBackColor = true;
            this.JSONDes.Click += new System.EventHandler(this.JSONDes_Click);
            // 
            // buttonFacade
            // 
            this.buttonFacade.Location = new System.Drawing.Point(696, 447);
            this.buttonFacade.Name = "buttonFacade";
            this.buttonFacade.Size = new System.Drawing.Size(315, 48);
            this.buttonFacade.TabIndex = 26;
            this.buttonFacade.Text = "Facade";
            this.buttonFacade.UseVisualStyleBackColor = true;
            this.buttonFacade.Click += new System.EventHandler(this.buttonFacade_Click);
            // 
            // buttonPipe
            // 
            this.buttonPipe.Location = new System.Drawing.Point(696, 501);
            this.buttonPipe.Name = "buttonPipe";
            this.buttonPipe.Size = new System.Drawing.Size(315, 48);
            this.buttonPipe.TabIndex = 27;
            this.buttonPipe.Text = "Pipe";
            this.buttonPipe.UseVisualStyleBackColor = true;
            this.buttonPipe.Click += new System.EventHandler(this.buttonPipe_Click);
            // 
            // buttonCommand
            // 
            this.buttonCommand.Location = new System.Drawing.Point(696, 558);
            this.buttonCommand.Name = "buttonCommand";
            this.buttonCommand.Size = new System.Drawing.Size(315, 48);
            this.buttonCommand.TabIndex = 28;
            this.buttonCommand.Text = "Command";
            this.buttonCommand.UseVisualStyleBackColor = true;
            this.buttonCommand.Click += new System.EventHandler(this.buttonCommand_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 610);
            this.Controls.Add(this.buttonCommand);
            this.Controls.Add(this.buttonPipe);
            this.Controls.Add(this.buttonFacade);
            this.Controls.Add(this.JSONDes);
            this.Controls.Add(this.XMLDes);
            this.Controls.Add(this.BinaryDes);
            this.Controls.Add(this.JSONSer);
            this.Controls.Add(this.XMLSer);
            this.Controls.Add(this.BinarySer);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboUncorrect);
            this.Controls.Add(this.comboSpiral);
            this.Controls.Add(this.comboLens);
            this.Controls.Add(this.comboElliptic);
            this.Controls.Add(this.comboType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textCount);
            this.Controls.Add(this.label);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.dataGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn count;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn elliptic;
        private System.Windows.Forms.DataGridViewTextBoxColumn lens;
        private System.Windows.Forms.DataGridViewTextBoxColumn spiral;
        private System.Windows.Forms.DataGridViewTextBoxColumn uncorrect;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox textCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboType;
        private System.Windows.Forms.ComboBox comboElliptic;
        private System.Windows.Forms.ComboBox comboLens;
        private System.Windows.Forms.ComboBox comboSpiral;
        private System.Windows.Forms.ComboBox comboUncorrect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BinarySer;
        private System.Windows.Forms.Button XMLSer;
        private System.Windows.Forms.Button JSONSer;
        private System.Windows.Forms.Button BinaryDes;
        private System.Windows.Forms.Button XMLDes;
        private System.Windows.Forms.Button JSONDes;
        private System.Windows.Forms.Button buttonFacade;
        private System.Windows.Forms.Button buttonPipe;
        private System.Windows.Forms.Button buttonCommand;
    }
}

