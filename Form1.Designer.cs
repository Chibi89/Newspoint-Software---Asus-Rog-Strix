namespace Newspoint_Software___Asus_Rog_Strix_g15_g513rm
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Drv = new System.Windows.Forms.Button();
            this.Bios = new System.Windows.Forms.Button();
            this.Soft = new System.Windows.Forms.Button();
            this.C_Panel = new System.Windows.Forms.Panel();
            this.D_PANEL = new System.Windows.Forms.Panel();
            this.B_PANEL = new System.Windows.Forms.Panel();
            this.S_PANEL = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Web = new System.Windows.Forms.Button();
            this.W_PANEL = new System.Windows.Forms.Panel();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.LoadSetTime = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.loadChar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.C_Panel.SuspendLayout();
            this.D_PANEL.SuspendLayout();
            this.B_PANEL.SuspendLayout();
            this.S_PANEL.SuspendLayout();
            this.W_PANEL.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(187, 139);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
           
            // 
            // C_Panel
            // 
            this.C_Panel.Controls.Add(this.loadChar);
            this.C_Panel.Controls.Add(this.D_PANEL);
            this.C_Panel.Controls.Add(this.W_PANEL);
            this.C_Panel.Controls.Add(this.S_PANEL);
            this.C_Panel.Controls.Add(this.B_PANEL);
            this.C_Panel.Location = new System.Drawing.Point(206, 200);
            this.C_Panel.Name = "C_Panel";
            this.C_Panel.Size = new System.Drawing.Size(613, 390);
            this.C_Panel.TabIndex = 5;
            // 
            // D_PANEL
            // 
            this.D_PANEL.Controls.Add(this.panel10);
            this.D_PANEL.Controls.Add(this.panel9);
            this.D_PANEL.Controls.Add(this.panel8);
            this.D_PANEL.Controls.Add(this.panel7);
            this.D_PANEL.Controls.Add(this.panel6);
            this.D_PANEL.Controls.Add(this.panel5);
            this.D_PANEL.Controls.Add(this.panel4);
            this.D_PANEL.Controls.Add(this.panel3);
            this.D_PANEL.Controls.Add(this.panel2);
            this.D_PANEL.Controls.Add(this.panel1);
            this.D_PANEL.Location = new System.Drawing.Point(71, 45);
            this.D_PANEL.Name = "D_PANEL";
            this.D_PANEL.Size = new System.Drawing.Size(200, 100);
            this.D_PANEL.TabIndex = 0;
            this.D_PANEL.Visible = false;
            // 
            // B_PANEL
            // 
            this.B_PANEL.Controls.Add(this.label1);
            this.B_PANEL.Location = new System.Drawing.Point(343, 45);
            this.B_PANEL.Name = "B_PANEL";
            this.B_PANEL.Size = new System.Drawing.Size(200, 100);
            this.B_PANEL.TabIndex = 1;
            this.B_PANEL.Visible = false;
            // 
            // S_PANEL
            // 
            this.S_PANEL.Controls.Add(this.label2);
            this.S_PANEL.Location = new System.Drawing.Point(83, 234);
            this.S_PANEL.Name = "S_PANEL";
            this.S_PANEL.Size = new System.Drawing.Size(181, 92);
            this.S_PANEL.TabIndex = 2;
            this.S_PANEL.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bios";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Software";
            // 
            // W_PANEL
            // 
            this.W_PANEL.Controls.Add(this.webBrowser1);
            this.W_PANEL.Location = new System.Drawing.Point(333, 234);
            this.W_PANEL.Name = "W_PANEL";
            this.W_PANEL.Size = new System.Drawing.Size(200, 100);
            this.W_PANEL.TabIndex = 3;
            this.W_PANEL.Visible = false;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(200, 100);
            this.webBrowser1.TabIndex = 0;
            // 
            // LoadSetTime
            // 
            this.LoadSetTime.Interval = 3000;
            this.LoadSetTime.Tick += new System.EventHandler(this.LoadSetTime_Tick);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(12, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(190, 82);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(210, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(190, 82);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(406, 14);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(176, 82);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(12, 113);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(190, 82);
            this.panel4.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Location = new System.Drawing.Point(210, 113);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(190, 82);
            this.panel5.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Location = new System.Drawing.Point(406, 113);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(176, 82);
            this.panel6.TabIndex = 3;
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Location = new System.Drawing.Point(12, 211);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(190, 82);
            this.panel7.TabIndex = 4;
            // 
            // panel8
            // 
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Location = new System.Drawing.Point(210, 211);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(190, 82);
            this.panel8.TabIndex = 5;
            // 
            // panel9
            // 
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Location = new System.Drawing.Point(406, 211);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(176, 82);
            this.panel9.TabIndex = 4;
            // 
            // panel10
            // 
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel10.Location = new System.Drawing.Point(210, 305);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(190, 82);
            this.panel10.TabIndex = 5;
            // 
            // loadChar
            // 
            this.loadChar.AutoSize = true;
            this.loadChar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.loadChar.Location = new System.Drawing.Point(175, 190);
            this.loadChar.Name = "loadChar";
            this.loadChar.Size = new System.Drawing.Size(244, 24);
            this.loadChar.TabIndex = 4;
            this.loadChar.Text = "Caricamento Componenti ...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 589);
            this.Controls.Add(this.Web);
            this.Controls.Add(this.C_Panel);
            this.Controls.Add(this.Soft);
            this.Controls.Add(this.Bios);
            this.Controls.Add(this.Drv);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Maroon;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.C_Panel.ResumeLayout(false);
            this.C_Panel.PerformLayout();
            this.D_PANEL.ResumeLayout(false);
            this.B_PANEL.ResumeLayout(false);
            this.B_PANEL.PerformLayout();
            this.S_PANEL.ResumeLayout(false);
            this.S_PANEL.PerformLayout();
            this.W_PANEL.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Drv;
        private System.Windows.Forms.Button Bios;
        private System.Windows.Forms.Button Soft;
        private System.Windows.Forms.Panel C_Panel;
        private System.Windows.Forms.Panel S_PANEL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel B_PANEL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel D_PANEL;
        private System.Windows.Forms.Panel W_PANEL;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button Web;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer LoadSetTime;
        private System.Windows.Forms.Label loadChar;
    }
}

