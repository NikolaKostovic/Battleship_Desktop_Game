namespace Potapanje_brodova
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel_trenutni_potez = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel_ime_igraca = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.computer_ime_panel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.pogodak_promasaj_panel = new System.Windows.Forms.Panel();
            this.panel_pozadina = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel_pozadina.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(761, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Prikazi protivnicke brodove";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.PapayaWhip;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(12, 82);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(446, 40);
            this.panel4.TabIndex = 10;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.PapayaWhip;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Location = new System.Drawing.Point(464, 82);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(440, 40);
            this.panel5.TabIndex = 11;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel_trenutni_potez
            // 
            this.panel_trenutni_potez.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_trenutni_potez.BackColor = System.Drawing.Color.Ivory;
            this.panel_trenutni_potez.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_trenutni_potez.Location = new System.Drawing.Point(288, 34);
            this.panel_trenutni_potez.Name = "panel_trenutni_potez";
            this.panel_trenutni_potez.Size = new System.Drawing.Size(341, 31);
            this.panel_trenutni_potez.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel3.BackColor = System.Drawing.Color.Cornsilk;
            this.panel3.Location = new System.Drawing.Point(194, 591);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(528, 23);
            this.panel3.TabIndex = 8;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BackColor = System.Drawing.Color.PapayaWhip;
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(12, 128);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel_ime_igraca);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.computer_ime_panel);
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Size = new System.Drawing.Size(892, 457);
            this.splitContainer1.SplitterDistance = 446;
            this.splitContainer1.TabIndex = 9;
            this.splitContainer1.Resize += new System.EventHandler(this.splitContainer1_Resize);
            // 
            // panel_ime_igraca
            // 
            this.panel_ime_igraca.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel_ime_igraca.BackColor = System.Drawing.Color.Ivory;
            this.panel_ime_igraca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_ime_igraca.Location = new System.Drawing.Point(142, 426);
            this.panel_ime_igraca.Name = "panel_ime_igraca";
            this.panel_ime_igraca.Size = new System.Drawing.Size(161, 26);
            this.panel_ime_igraca.TabIndex = 7;
            this.panel_ime_igraca.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_ime_igraca_Paint);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.PowderBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(20, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 400);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // computer_ime_panel
            // 
            this.computer_ime_panel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.computer_ime_panel.BackColor = System.Drawing.Color.Ivory;
            this.computer_ime_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.computer_ime_panel.Location = new System.Drawing.Point(140, 426);
            this.computer_ime_panel.Name = "computer_ime_panel";
            this.computer_ime_panel.Size = new System.Drawing.Size(161, 26);
            this.computer_ime_panel.TabIndex = 8;
            this.computer_ime_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.computer_ime_panel_Paint);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.PowderBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(20, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 400);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            this.panel2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseClick);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(829, 32);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Slikaj ekran";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pogodak_promasaj_panel
            // 
            this.pogodak_promasaj_panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pogodak_promasaj_panel.BackColor = System.Drawing.Color.Ivory;
            this.pogodak_promasaj_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pogodak_promasaj_panel.Location = new System.Drawing.Point(288, 3);
            this.pogodak_promasaj_panel.Name = "pogodak_promasaj_panel";
            this.pogodak_promasaj_panel.Size = new System.Drawing.Size(341, 31);
            this.pogodak_promasaj_panel.TabIndex = 6;
            // 
            // panel_pozadina
            // 
            this.panel_pozadina.Controls.Add(this.button2);
            this.panel_pozadina.Controls.Add(this.panel5);
            this.panel_pozadina.Controls.Add(this.button1);
            this.panel_pozadina.Controls.Add(this.splitContainer1);
            this.panel_pozadina.Controls.Add(this.panel4);
            this.panel_pozadina.Controls.Add(this.pogodak_promasaj_panel);
            this.panel_pozadina.Controls.Add(this.panel3);
            this.panel_pozadina.Controls.Add(this.panel_trenutni_potez);
            this.panel_pozadina.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_pozadina.Location = new System.Drawing.Point(0, 0);
            this.panel_pozadina.Name = "panel_pozadina";
            this.panel_pozadina.Size = new System.Drawing.Size(916, 620);
            this.panel_pozadina.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(916, 620);
            this.Controls.Add(this.panel_pozadina);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Potapanje brodova";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel_pozadina.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel_trenutni_potez;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel_ime_igraca;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel computer_ime_panel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel pogodak_promasaj_panel;
        private System.Windows.Forms.Panel panel_pozadina;

    }
}

