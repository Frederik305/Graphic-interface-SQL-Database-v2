namespace Form_Fontions
{
    partial class ListTablesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            panel2 = new Panel();
            panel6 = new Panel();
            textBox2 = new TextBox();
            label5 = new Label();
            button1 = new Button();
            panel5 = new Panel();
            label4 = new Label();
            buttonSaveNewData = new Button();
            checkBoxAddData = new CheckBox();
            panel4 = new Panel();
            checkBox1 = new CheckBox();
            buttonUpdate = new Button();
            checkBoxEdit = new CheckBox();
            label3 = new Label();
            panel3 = new Panel();
            label1 = new Label();
            dataGridView2 = new DataGridView();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            panel1 = new Panel();
            buttonClear = new Button();
            comboBox2 = new ComboBox();
            buttonAfficher = new Button();
            connectionSqlDatabaseBindingSource = new BindingSource(components);
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel2.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)connectionSqlDatabaseBindingSource).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBox1.Location = new Point(21, 67);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Search";
            textBox1.Size = new Size(136, 23);
            textBox1.TabIndex = 17;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(21, 38);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(136, 23);
            comboBox1.TabIndex = 18;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.AutoSize = true;
            panel2.BackColor = SystemColors.ControlLight;
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.MaximumSize = new Size(200, 0);
            panel2.MinimumSize = new Size(200, 300);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 520);
            panel2.TabIndex = 19;
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.ControlLightLight;
            panel6.Controls.Add(textBox2);
            panel6.Controls.Add(label5);
            panel6.Controls.Add(button1);
            panel6.Location = new Point(0, 385);
            panel6.Name = "panel6";
            panel6.Size = new Size(183, 119);
            panel6.TabIndex = 22;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 47);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "entrer l'ID de la row a delete";
            textBox2.Size = new Size(154, 23);
            textBox2.TabIndex = 24;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 16);
            label5.Name = "label5";
            label5.Size = new Size(126, 15);
            label5.TabIndex = 23;
            label5.Text = "Delete content in table";
            // 
            // button1
            // 
            button1.Location = new Point(23, 76);
            button1.Name = "button1";
            button1.Size = new Size(113, 31);
            button1.TabIndex = 22;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ControlLightLight;
            panel5.Controls.Add(label4);
            panel5.Controls.Add(buttonSaveNewData);
            panel5.Controls.Add(checkBoxAddData);
            panel5.Location = new Point(0, 272);
            panel5.Name = "panel5";
            panel5.Size = new Size(183, 107);
            panel5.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 16);
            label4.Name = "label4";
            label4.Size = new Size(115, 15);
            label4.TabIndex = 23;
            label4.Text = "Add content in table";
            // 
            // buttonSaveNewData
            // 
            buttonSaveNewData.Enabled = false;
            buttonSaveNewData.Location = new Point(21, 59);
            buttonSaveNewData.Name = "buttonSaveNewData";
            buttonSaveNewData.Size = new Size(113, 31);
            buttonSaveNewData.TabIndex = 22;
            buttonSaveNewData.Text = "Save Changes";
            buttonSaveNewData.UseVisualStyleBackColor = true;
            buttonSaveNewData.Click += buttonSaveNewData_Click;
            // 
            // checkBoxAddData
            // 
            checkBoxAddData.AutoSize = true;
            checkBoxAddData.Location = new Point(30, 34);
            checkBoxAddData.Name = "checkBoxAddData";
            checkBoxAddData.Size = new Size(75, 19);
            checkBoxAddData.TabIndex = 0;
            checkBoxAddData.Text = "Add Data";
            checkBoxAddData.UseVisualStyleBackColor = true;
            checkBoxAddData.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ControlLightLight;
            panel4.Controls.Add(checkBox1);
            panel4.Controls.Add(buttonUpdate);
            panel4.Controls.Add(checkBoxEdit);
            panel4.Controls.Add(label3);
            panel4.Location = new Point(0, 131);
            panel4.Name = "panel4";
            panel4.Size = new Size(183, 135);
            panel4.TabIndex = 20;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Enabled = false;
            checkBox1.Location = new Point(30, 62);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(65, 19);
            checkBox1.TabIndex = 22;
            checkBox1.Text = "Edit IDs";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Enabled = false;
            buttonUpdate.Location = new Point(21, 87);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(113, 31);
            buttonUpdate.TabIndex = 21;
            buttonUpdate.Text = "Save Changes";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // checkBoxEdit
            // 
            checkBoxEdit.AutoSize = true;
            checkBoxEdit.Enabled = false;
            checkBoxEdit.Location = new Point(30, 37);
            checkBoxEdit.Name = "checkBoxEdit";
            checkBoxEdit.Size = new Size(46, 19);
            checkBoxEdit.TabIndex = 20;
            checkBoxEdit.Text = "Edit";
            checkBoxEdit.UseVisualStyleBackColor = true;
            checkBoxEdit.CheckedChanged += checkBoxEdit_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 19);
            label3.Name = "label3";
            label3.Size = new Size(113, 15);
            label3.TabIndex = 19;
            label3.Text = "Edit content in table";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlLightLight;
            panel3.Controls.Add(label1);
            panel3.Controls.Add(comboBox1);
            panel3.Controls.Add(textBox1);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(183, 125);
            panel3.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 20);
            label1.Name = "label1";
            label1.Size = new Size(107, 15);
            label1.TabIndex = 19;
            label1.Text = "Search by columns";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(738, 511);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(10, 10);
            dataGridView2.TabIndex = 21;
            dataGridView2.Visible = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ControlLight;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(206, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(720, 464);
            dataGridView1.TabIndex = 25;
            dataGridView1.CellEndEdit += dataGridView1_CellEndEdit_1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(212, 489);
            label2.Name = "label2";
            label2.Size = new Size(140, 15);
            label2.TabIndex = 14;
            label2.Text = "Choisir la table a afficher:";
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 520);
            panel1.Name = "panel1";
            panel1.Size = new Size(926, 0);
            panel1.TabIndex = 16;
            // 
            // buttonClear
            // 
            buttonClear.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonClear.Location = new Point(839, 485);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(75, 23);
            buttonClear.TabIndex = 15;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // comboBox2
            // 
            comboBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(364, 485);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(192, 23);
            comboBox2.TabIndex = 26;
            // 
            // buttonAfficher
            // 
            buttonAfficher.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonAfficher.Location = new Point(562, 485);
            buttonAfficher.Name = "buttonAfficher";
            buttonAfficher.Size = new Size(75, 23);
            buttonAfficher.TabIndex = 27;
            buttonAfficher.Text = "Afficher";
            buttonAfficher.UseVisualStyleBackColor = true;
            buttonAfficher.Click += buttonAfficher_Click;
            // 
            // connectionSqlDatabaseBindingSource
            // 
            connectionSqlDatabaseBindingSource.DataSource = typeof(SqlFonctions.ConnectionSqlDatabase);
            // 
            // ListTablesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(926, 520);
            Controls.Add(dataGridView2);
            Controls.Add(buttonAfficher);
            Controls.Add(comboBox2);
            Controls.Add(buttonClear);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(dataGridView1);
            MinimumSize = new Size(758, 340);
            Name = "ListTablesForm";
            Text = "ListTablesForm";
            panel2.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)connectionSqlDatabaseBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private ComboBox comboBox1;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private Panel panel4;
        private Label label3;
        private CheckBox checkBoxEdit;
        private Button buttonUpdate;
        private CheckBox checkBox1;
        private DataGridView dataGridView1;
        private Label label2;
        private Panel panel1;
        private DataGridView dataGridView2;
        private Button buttonClear;
        private ComboBox comboBox2;
        private Button buttonAfficher;
        private Panel panel5;
        private Panel panel7;
        private BindingSource connectionSqlDatabaseBindingSource;
        private CheckBox checkBoxAddData;
        private Label label4;
        private Button buttonSaveNewData;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel panel6;
        private TextBox textBox2;
        private Label label5;
        private Button button1;
    }
}