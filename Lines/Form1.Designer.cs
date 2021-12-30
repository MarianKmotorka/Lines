namespace Lines
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.XY = new System.Windows.Forms.Label();
            this.tbIncrement = new System.Windows.Forms.TextBox();
            this.tbLength = new System.Windows.Forms.TextBox();
            this.tbAngle = new System.Windows.Forms.TextBox();
            this.tbNzmOfLines = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.canvas = new System.Windows.Forms.Panel();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.rbWhite = new System.Windows.Forms.RadioButton();
            this.rbBlack = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.rbBlack);
            this.panel1.Controls.Add(this.rbWhite);
            this.panel1.Controls.Add(this.trackBar1);
            this.panel1.Controls.Add(this.XY);
            this.panel1.Controls.Add(this.tbIncrement);
            this.panel1.Controls.Add(this.tbLength);
            this.panel1.Controls.Add(this.tbAngle);
            this.panel1.Controls.Add(this.tbNzmOfLines);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1019, 47);
            this.panel1.TabIndex = 0;
            // 
            // XY
            // 
            this.XY.AutoSize = true;
            this.XY.Location = new System.Drawing.Point(954, 18);
            this.XY.Name = "XY";
            this.XY.Size = new System.Drawing.Size(53, 13);
            this.XY.TabIndex = 5;
            this.XY.Text = "X: 0 | Y: 0";
            // 
            // tbIncrement
            // 
            this.tbIncrement.Location = new System.Drawing.Point(424, 16);
            this.tbIncrement.Name = "tbIncrement";
            this.tbIncrement.Size = new System.Drawing.Size(39, 20);
            this.tbIncrement.TabIndex = 3;
            this.tbIncrement.Text = "1";
            // 
            // tbLength
            // 
            this.tbLength.Location = new System.Drawing.Point(290, 15);
            this.tbLength.Name = "tbLength";
            this.tbLength.Size = new System.Drawing.Size(39, 20);
            this.tbLength.TabIndex = 2;
            this.tbLength.Text = "1";
            // 
            // tbAngle
            // 
            this.tbAngle.Location = new System.Drawing.Point(165, 15);
            this.tbAngle.Name = "tbAngle";
            this.tbAngle.Size = new System.Drawing.Size(39, 20);
            this.tbAngle.TabIndex = 1;
            this.tbAngle.Text = "110";
            // 
            // tbNzmOfLines
            // 
            this.tbNzmOfLines.Location = new System.Drawing.Point(55, 16);
            this.tbNzmOfLines.Name = "tbNzmOfLines";
            this.tbNzmOfLines.Size = new System.Drawing.Size(39, 20);
            this.tbNzmOfLines.TabIndex = 0;
            this.tbNzmOfLines.Text = "10000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(354, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Increment";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(237, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Length";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(120, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Angle";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "# Lines";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(863, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 44);
            this.button1.TabIndex = 4;
            this.button1.Text = "Go";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.Color.Black;
            this.canvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canvas.Location = new System.Drawing.Point(0, 47);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(1019, 614);
            this.canvas.TabIndex = 1;
            this.canvas.Click += new System.EventHandler(this.canvas_Click);
            this.canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.canvas_Paint);
            this.canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseMove);
            // 
            // trackBar1
            // 
            this.trackBar1.AutoSize = false;
            this.trackBar1.BackColor = System.Drawing.Color.Red;
            this.trackBar1.Location = new System.Drawing.Point(494, 13);
            this.trackBar1.Maximum = 70;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(253, 23);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // rbWhite
            // 
            this.rbWhite.BackColor = System.Drawing.Color.White;
            this.rbWhite.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbWhite.Location = new System.Drawing.Point(764, 11);
            this.rbWhite.Name = "rbWhite";
            this.rbWhite.Size = new System.Drawing.Size(39, 24);
            this.rbWhite.TabIndex = 6;
            this.rbWhite.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbWhite.UseVisualStyleBackColor = false;
            this.rbWhite.CheckedChanged += new System.EventHandler(this.rbWhite_CheckedChanged);
            // 
            // rbBlack
            // 
            this.rbBlack.BackColor = System.Drawing.Color.Black;
            this.rbBlack.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbBlack.Checked = true;
            this.rbBlack.Location = new System.Drawing.Point(809, 11);
            this.rbBlack.Name = "rbBlack";
            this.rbBlack.Size = new System.Drawing.Size(40, 24);
            this.rbBlack.TabIndex = 0;
            this.rbBlack.TabStop = true;
            this.rbBlack.UseVisualStyleBackColor = false;
            this.rbBlack.CheckedChanged += new System.EventHandler(this.rbBlack_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 661);
            this.Controls.Add(this.canvas);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lines";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbIncrement;
        private System.Windows.Forms.TextBox tbLength;
        private System.Windows.Forms.TextBox tbAngle;
        private System.Windows.Forms.TextBox tbNzmOfLines;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel canvas;
        private System.Windows.Forms.Label XY;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.RadioButton rbBlack;
        private System.Windows.Forms.RadioButton rbWhite;
    }
}

