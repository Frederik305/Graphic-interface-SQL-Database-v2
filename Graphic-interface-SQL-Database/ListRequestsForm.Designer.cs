namespace Form_Fontions
{
    partial class ListRequestsForm
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
            label2 = new Label();
            panel1 = new Panel();
            buttonAfficher = new Button();
            comboBox2 = new ComboBox();
            buttonClear = new Button();
            label1 = new Label();
            ScoresVainqueurs = new Button();
            Joueur = new Button();
            MatchTennis = new Button();
            Tournoi = new Button();
            Epreuve = new Button();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            dataGridView2 = new DataGridView();
            panel3 = new Panel();
            label3 = new Label();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(16, 23);
            label2.Name = "label2";
            label2.Size = new Size(160, 15);
            label2.TabIndex = 15;
            label2.Text = "Choisire la requete a afficher:";
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(buttonAfficher);
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(buttonClear);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(ScoresVainqueurs);
            panel1.Controls.Add(Joueur);
            panel1.Controls.Add(MatchTennis);
            panel1.Controls.Add(Tournoi);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(Epreuve);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(200, 393);
            panel1.Name = "panel1";
            panel1.Size = new Size(709, 57);
            panel1.TabIndex = 21;
            // 
            // buttonAfficher
            // 
            buttonAfficher.Location = new Point(458, 19);
            buttonAfficher.Name = "buttonAfficher";
            buttonAfficher.Size = new Size(75, 23);
            buttonAfficher.TabIndex = 24;
            buttonAfficher.Text = "Afficher";
            buttonAfficher.UseVisualStyleBackColor = true;
            buttonAfficher.Click += buttonAfficher_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(182, 19);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(270, 23);
            comboBox2.TabIndex = 23;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(622, 19);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(75, 23);
            buttonClear.TabIndex = 22;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(13, -26);
            label1.Name = "label1";
            label1.Size = new Size(146, 15);
            label1.TabIndex = 14;
            label1.Text = "Choisire la table a afficher:";
            // 
            // ScoresVainqueurs
            // 
            ScoresVainqueurs.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ScoresVainqueurs.Location = new Point(503, -30);
            ScoresVainqueurs.Name = "ScoresVainqueurs";
            ScoresVainqueurs.Size = new Size(115, 23);
            ScoresVainqueurs.TabIndex = 13;
            ScoresVainqueurs.Text = "Scores Vainqueurs";
            ScoresVainqueurs.UseVisualStyleBackColor = true;
            // 
            // Joueur
            // 
            Joueur.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Joueur.Location = new Point(165, -30);
            Joueur.Name = "Joueur";
            Joueur.Size = new Size(75, 23);
            Joueur.TabIndex = 8;
            Joueur.Text = "Joueur";
            Joueur.UseVisualStyleBackColor = true;
            // 
            // MatchTennis
            // 
            MatchTennis.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            MatchTennis.Location = new Point(408, -30);
            MatchTennis.Name = "MatchTennis";
            MatchTennis.Size = new Size(89, 23);
            MatchTennis.TabIndex = 12;
            MatchTennis.Text = "Match tennis";
            MatchTennis.UseVisualStyleBackColor = true;
            // 
            // Tournoi
            // 
            Tournoi.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Tournoi.Location = new Point(246, -30);
            Tournoi.Name = "Tournoi";
            Tournoi.Size = new Size(75, 23);
            Tournoi.TabIndex = 10;
            Tournoi.Text = "Tournoi";
            Tournoi.UseVisualStyleBackColor = true;
            // 
            // Epreuve
            // 
            Epreuve.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Epreuve.Location = new Point(327, -30);
            Epreuve.Name = "Epreuve";
            Epreuve.Size = new Size(75, 23);
            Epreuve.TabIndex = 11;
            Epreuve.Text = "Epreuve";
            Epreuve.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ControlLight;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(200, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(709, 393);
            dataGridView1.TabIndex = 24;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView2);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 450);
            panel2.TabIndex = 25;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(0, 432);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(16, 18);
            dataGridView2.TabIndex = 20;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlLightLight;
            panel3.Controls.Add(label3);
            panel3.Controls.Add(comboBox1);
            panel3.Controls.Add(textBox1);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 125);
            panel3.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 21);
            label3.Name = "label3";
            label3.Size = new Size(107, 15);
            label3.TabIndex = 19;
            label3.Text = "Search by columns";
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(30, 39);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(136, 23);
            comboBox1.TabIndex = 18;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBox1.Location = new Point(30, 68);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Search";
            textBox1.Size = new Size(136, 23);
            textBox1.TabIndex = 17;
            textBox1.TextChanged += textBox1_TextChanged_1;
            // 
            // ListRequestsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(909, 450);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(dataGridView1);
            MinimumSize = new Size(925, 489);
            Name = "ListRequestsForm";
            Text = "ListRequestsForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Panel panel1;
        private Label label1;
        private Button ScoresVainqueurs;
        private Button Joueur;
        private Button MatchTennis;
        private Button Tournoi;
        private Button Epreuve;
        private Button buttonClear;
        private DataGridView dataGridView1;
        private Panel panel2;
        private Panel panel3;
        private Label label3;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Button buttonAfficher;
        private ComboBox comboBox2;
        private DataGridView dataGridView2;
    }
}