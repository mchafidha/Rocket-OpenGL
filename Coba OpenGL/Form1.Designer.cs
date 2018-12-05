namespace Coba_OpenGL
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
            this.simpleOpenGlControl1 = new Tao.Platform.Windows.SimpleOpenGlControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.rYaw = new System.Windows.Forms.TextBox();
            this.rRoll = new System.Windows.Forms.TextBox();
            this.rPitch = new System.Windows.Forms.TextBox();
            this.comboYaw = new System.Windows.Forms.ComboBox();
            this.comboRoll = new System.Windows.Forms.ComboBox();
            this.comboPitch = new System.Windows.Forms.ComboBox();
            this.Zmin = new System.Windows.Forms.Button();
            this.Zplus = new System.Windows.Forms.Button();
            this.Ymin = new System.Windows.Forms.Button();
            this.Yplus = new System.Windows.Forms.Button();
            this.Xmin = new System.Windows.Forms.Button();
            this.Xplus = new System.Windows.Forms.Button();
            this.labelRoll = new System.Windows.Forms.Label();
            this.labelPitch = new System.Windows.Forms.Label();
            this.labelYaw = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // simpleOpenGlControl1
            // 
            this.simpleOpenGlControl1.AccumBits = ((byte)(0));
            this.simpleOpenGlControl1.AutoCheckErrors = false;
            this.simpleOpenGlControl1.AutoFinish = false;
            this.simpleOpenGlControl1.AutoMakeCurrent = true;
            this.simpleOpenGlControl1.AutoSwapBuffers = true;
            this.simpleOpenGlControl1.BackColor = System.Drawing.Color.Black;
            this.simpleOpenGlControl1.ColorBits = ((byte)(32));
            this.simpleOpenGlControl1.DepthBits = ((byte)(16));
            this.simpleOpenGlControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.simpleOpenGlControl1.Location = new System.Drawing.Point(0, 0);
            this.simpleOpenGlControl1.Name = "simpleOpenGlControl1";
            this.simpleOpenGlControl1.Size = new System.Drawing.Size(616, 498);
            this.simpleOpenGlControl1.StencilBits = ((byte)(0));
            this.simpleOpenGlControl1.TabIndex = 0;
            this.simpleOpenGlControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.simpleOpenGlControl1_Paint);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 150;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rYaw);
            this.panel1.Controls.Add(this.rRoll);
            this.panel1.Controls.Add(this.rPitch);
            this.panel1.Controls.Add(this.comboYaw);
            this.panel1.Controls.Add(this.comboRoll);
            this.panel1.Controls.Add(this.comboPitch);
            this.panel1.Controls.Add(this.Zmin);
            this.panel1.Controls.Add(this.Zplus);
            this.panel1.Controls.Add(this.Ymin);
            this.panel1.Controls.Add(this.Yplus);
            this.panel1.Controls.Add(this.Xmin);
            this.panel1.Controls.Add(this.Xplus);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(217, 107);
            this.panel1.TabIndex = 1;
            // 
            // rYaw
            // 
            this.rYaw.Location = new System.Drawing.Point(163, 73);
            this.rYaw.Name = "rYaw";
            this.rYaw.Size = new System.Drawing.Size(47, 20);
            this.rYaw.TabIndex = 3;
            this.rYaw.Text = "0";
            this.rYaw.Visible = false;
            // 
            // rRoll
            // 
            this.rRoll.Location = new System.Drawing.Point(163, 44);
            this.rRoll.Name = "rRoll";
            this.rRoll.Size = new System.Drawing.Size(47, 20);
            this.rRoll.TabIndex = 3;
            this.rRoll.Text = "0";
            this.rRoll.Visible = false;
            // 
            // rPitch
            // 
            this.rPitch.Location = new System.Drawing.Point(163, 15);
            this.rPitch.Name = "rPitch";
            this.rPitch.Size = new System.Drawing.Size(47, 20);
            this.rPitch.TabIndex = 3;
            this.rPitch.Text = "0";
            this.rPitch.Visible = false;
            // 
            // comboYaw
            // 
            this.comboYaw.FormattingEnabled = true;
            this.comboYaw.Items.AddRange(new object[] {
            "x",
            "y",
            "z"});
            this.comboYaw.Location = new System.Drawing.Point(112, 72);
            this.comboYaw.Name = "comboYaw";
            this.comboYaw.Size = new System.Drawing.Size(45, 21);
            this.comboYaw.TabIndex = 3;
            this.comboYaw.Visible = false;
            this.comboYaw.SelectedIndexChanged += new System.EventHandler(this.comboYaw_SelectedIndexChanged);
            // 
            // comboRoll
            // 
            this.comboRoll.FormattingEnabled = true;
            this.comboRoll.Items.AddRange(new object[] {
            "x",
            "y",
            "z"});
            this.comboRoll.Location = new System.Drawing.Point(112, 43);
            this.comboRoll.Name = "comboRoll";
            this.comboRoll.Size = new System.Drawing.Size(45, 21);
            this.comboRoll.TabIndex = 3;
            this.comboRoll.Visible = false;
            this.comboRoll.SelectedIndexChanged += new System.EventHandler(this.comboRoll_SelectedIndexChanged);
            // 
            // comboPitch
            // 
            this.comboPitch.FormattingEnabled = true;
            this.comboPitch.Items.AddRange(new object[] {
            "x",
            "y",
            "z"});
            this.comboPitch.Location = new System.Drawing.Point(112, 14);
            this.comboPitch.Name = "comboPitch";
            this.comboPitch.Size = new System.Drawing.Size(45, 21);
            this.comboPitch.TabIndex = 3;
            this.comboPitch.Visible = false;
            this.comboPitch.SelectedIndexChanged += new System.EventHandler(this.comboPitch_SelectedIndexChanged);
            // 
            // Zmin
            // 
            this.Zmin.Location = new System.Drawing.Point(62, 70);
            this.Zmin.Name = "Zmin";
            this.Zmin.Size = new System.Drawing.Size(44, 23);
            this.Zmin.TabIndex = 2;
            this.Zmin.Text = "Y-";
            this.Zmin.UseVisualStyleBackColor = true;
            this.Zmin.Click += new System.EventHandler(this.Zmin_Click);
            // 
            // Zplus
            // 
            this.Zplus.Location = new System.Drawing.Point(12, 70);
            this.Zplus.Name = "Zplus";
            this.Zplus.Size = new System.Drawing.Size(44, 23);
            this.Zplus.TabIndex = 2;
            this.Zplus.Text = "Y+";
            this.Zplus.UseVisualStyleBackColor = true;
            this.Zplus.Click += new System.EventHandler(this.Zplus_Click);
            // 
            // Ymin
            // 
            this.Ymin.Location = new System.Drawing.Point(62, 41);
            this.Ymin.Name = "Ymin";
            this.Ymin.Size = new System.Drawing.Size(44, 23);
            this.Ymin.TabIndex = 2;
            this.Ymin.Text = "R-";
            this.Ymin.UseVisualStyleBackColor = true;
            this.Ymin.Click += new System.EventHandler(this.Ymin_Click);
            // 
            // Yplus
            // 
            this.Yplus.Location = new System.Drawing.Point(12, 41);
            this.Yplus.Name = "Yplus";
            this.Yplus.Size = new System.Drawing.Size(44, 23);
            this.Yplus.TabIndex = 2;
            this.Yplus.Text = "R+";
            this.Yplus.UseVisualStyleBackColor = true;
            this.Yplus.Click += new System.EventHandler(this.Yplus_Click);
            // 
            // Xmin
            // 
            this.Xmin.Location = new System.Drawing.Point(62, 12);
            this.Xmin.Name = "Xmin";
            this.Xmin.Size = new System.Drawing.Size(44, 23);
            this.Xmin.TabIndex = 2;
            this.Xmin.Text = "P-";
            this.Xmin.UseVisualStyleBackColor = true;
            this.Xmin.Click += new System.EventHandler(this.Xmin_Click);
            // 
            // Xplus
            // 
            this.Xplus.Location = new System.Drawing.Point(12, 12);
            this.Xplus.Name = "Xplus";
            this.Xplus.Size = new System.Drawing.Size(44, 23);
            this.Xplus.TabIndex = 2;
            this.Xplus.Text = "P+";
            this.Xplus.UseVisualStyleBackColor = true;
            this.Xplus.Click += new System.EventHandler(this.Xplus_Click);
            // 
            // labelRoll
            // 
            this.labelRoll.AutoSize = true;
            this.labelRoll.Location = new System.Drawing.Point(9, 427);
            this.labelRoll.Name = "labelRoll";
            this.labelRoll.Size = new System.Drawing.Size(25, 13);
            this.labelRoll.TabIndex = 2;
            this.labelRoll.Text = "Roll";
            // 
            // labelPitch
            // 
            this.labelPitch.AutoSize = true;
            this.labelPitch.Location = new System.Drawing.Point(9, 449);
            this.labelPitch.Name = "labelPitch";
            this.labelPitch.Size = new System.Drawing.Size(31, 13);
            this.labelPitch.TabIndex = 2;
            this.labelPitch.Text = "Pitch";
            // 
            // labelYaw
            // 
            this.labelYaw.AutoSize = true;
            this.labelYaw.Location = new System.Drawing.Point(9, 470);
            this.labelYaw.Name = "labelYaw";
            this.labelYaw.Size = new System.Drawing.Size(28, 13);
            this.labelYaw.TabIndex = 2;
            this.labelYaw.Text = "Yaw";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 498);
            this.Controls.Add(this.labelYaw);
            this.Controls.Add(this.labelRoll);
            this.Controls.Add(this.labelPitch);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.simpleOpenGlControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Tao.Platform.Windows.SimpleOpenGlControl simpleOpenGlControl1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Zmin;
        private System.Windows.Forms.Button Zplus;
        private System.Windows.Forms.Button Ymin;
        private System.Windows.Forms.Button Yplus;
        private System.Windows.Forms.Button Xmin;
        private System.Windows.Forms.Button Xplus;
        private System.Windows.Forms.Label labelRoll;
        private System.Windows.Forms.Label labelPitch;
        private System.Windows.Forms.Label labelYaw;
        private System.Windows.Forms.ComboBox comboYaw;
        private System.Windows.Forms.ComboBox comboRoll;
        private System.Windows.Forms.ComboBox comboPitch;
        private System.Windows.Forms.TextBox rYaw;
        private System.Windows.Forms.TextBox rRoll;
        private System.Windows.Forms.TextBox rPitch;
    }
}

