namespace Form_Fontions
{
    partial class Main
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
            afficheTables = new Button();
            afficheRequests = new Button();
            Quit = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // afficheTables
            // 
            afficheTables.Location = new Point(48, 53);
            afficheTables.Name = "afficheTables";
            afficheTables.Size = new Size(126, 23);
            afficheTables.TabIndex = 0;
            afficheTables.Text = "Gestion des tables";
            afficheTables.UseVisualStyleBackColor = true;
            afficheTables.Click += afficheTables_Click;
            // 
            // afficheRequests
            // 
            afficheRequests.Location = new Point(48, 82);
            afficheRequests.Name = "afficheRequests";
            afficheRequests.Size = new Size(126, 23);
            afficheRequests.TabIndex = 1;
            afficheRequests.Text = "Afficher les requetes";
            afficheRequests.UseVisualStyleBackColor = true;
            afficheRequests.Click += afficheRequests_Click;
            // 
            // Quit
            // 
            Quit.Location = new Point(48, 111);
            Quit.Name = "Quit";
            Quit.Size = new Size(75, 23);
            Quit.TabIndex = 2;
            Quit.Text = "Quitter";
            Quit.UseVisualStyleBackColor = true;
            Quit.Click += Quit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 57);
            label1.Name = "label1";
            label1.Size = new Size(16, 15);
            label1.TabIndex = 3;
            label1.Text = "1.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 86);
            label2.Name = "label2";
            label2.Size = new Size(16, 15);
            label2.TabIndex = 4;
            label2.Text = "2.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 115);
            label3.Name = "label3";
            label3.Size = new Size(16, 15);
            label3.TabIndex = 5;
            label3.Text = "3.";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(241, 191);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Quit);
            Controls.Add(afficheRequests);
            Controls.Add(afficheTables);
            MaximumSize = new Size(257, 230);
            MinimumSize = new Size(257, 230);
            Name = "Main";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button afficheTables;
        private Button afficheRequests;
        private Button Quit;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}