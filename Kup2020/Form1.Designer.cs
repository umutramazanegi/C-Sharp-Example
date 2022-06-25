namespace Ornek2020
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
            this.OpenGlControl = new Tao.Platform.Windows.SimpleOpenGlControl();
            this.buttonAnimDurdur = new System.Windows.Forms.Button();
            this.buttonAnimHizlandir = new System.Windows.Forms.Button();
            this.buttonAnimBaslat = new System.Windows.Forms.Button();
            this.timerDondur = new System.Windows.Forms.Timer(this.components);
            this.labelHiz = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OpenGlControl
            // 
            this.OpenGlControl.AccumBits = ((byte)(0));
            this.OpenGlControl.AutoCheckErrors = false;
            this.OpenGlControl.AutoFinish = false;
            this.OpenGlControl.AutoMakeCurrent = true;
            this.OpenGlControl.AutoSwapBuffers = true;
            this.OpenGlControl.BackColor = System.Drawing.Color.Black;
            this.OpenGlControl.ColorBits = ((byte)(32));
            this.OpenGlControl.DepthBits = ((byte)(16));
            this.OpenGlControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.OpenGlControl.Location = new System.Drawing.Point(0, 0);
            this.OpenGlControl.Name = "OpenGlControl";
            this.OpenGlControl.Size = new System.Drawing.Size(400, 387);
            this.OpenGlControl.StencilBits = ((byte)(0));
            this.OpenGlControl.TabIndex = 0;
            this.OpenGlControl.Load += new System.EventHandler(this.OpenGlControl_Load);
            this.OpenGlControl.Paint += new System.Windows.Forms.PaintEventHandler(this.MyPaint);
            this.OpenGlControl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MyKeyDown);
            // 
            // buttonAnimDurdur
            // 
            this.buttonAnimDurdur.Location = new System.Drawing.Point(421, 85);
            this.buttonAnimDurdur.Name = "buttonAnimDurdur";
            this.buttonAnimDurdur.Size = new System.Drawing.Size(129, 54);
            this.buttonAnimDurdur.TabIndex = 1;
            this.buttonAnimDurdur.Text = "Anim Durdur";
            this.buttonAnimDurdur.UseVisualStyleBackColor = true;
            this.buttonAnimDurdur.Click += new System.EventHandler(this.buttonAnimDurdur_Click);
            // 
            // buttonAnimHizlandir
            // 
            this.buttonAnimHizlandir.Location = new System.Drawing.Point(421, 155);
            this.buttonAnimHizlandir.Name = "buttonAnimHizlandir";
            this.buttonAnimHizlandir.Size = new System.Drawing.Size(129, 54);
            this.buttonAnimHizlandir.TabIndex = 2;
            this.buttonAnimHizlandir.Text = "Anim Hızlandır";
            this.buttonAnimHizlandir.UseVisualStyleBackColor = true;
            this.buttonAnimHizlandir.Click += new System.EventHandler(this.buttonAnimHizlandir_Click);
            // 
            // buttonAnimBaslat
            // 
            this.buttonAnimBaslat.Location = new System.Drawing.Point(421, 12);
            this.buttonAnimBaslat.Name = "buttonAnimBaslat";
            this.buttonAnimBaslat.Size = new System.Drawing.Size(129, 54);
            this.buttonAnimBaslat.TabIndex = 3;
            this.buttonAnimBaslat.Text = "Anim Başlat";
            this.buttonAnimBaslat.UseVisualStyleBackColor = true;
            this.buttonAnimBaslat.Click += new System.EventHandler(this.buttonAnimBaslat_Click);
            // 
            // timerDondur
            // 
            this.timerDondur.Tick += new System.EventHandler(this.timerDondur_Tick);
            // 
            // labelHiz
            // 
            this.labelHiz.AutoSize = true;
            this.labelHiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelHiz.Location = new System.Drawing.Point(438, 233);
            this.labelHiz.Name = "labelHiz";
            this.labelHiz.Size = new System.Drawing.Size(88, 26);
            this.labelHiz.TabIndex = 4;
            this.labelHiz.Text = "Hız = 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 387);
            this.Controls.Add(this.labelHiz);
            this.Controls.Add(this.buttonAnimBaslat);
            this.Controls.Add(this.buttonAnimHizlandir);
            this.Controls.Add(this.buttonAnimDurdur);
            this.Controls.Add(this.OpenGlControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MyKeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Tao.Platform.Windows.SimpleOpenGlControl OpenGlControl;
        private System.Windows.Forms.Button buttonAnimDurdur;
        private System.Windows.Forms.Button buttonAnimHizlandir;
        private System.Windows.Forms.Button buttonAnimBaslat;
        private System.Windows.Forms.Timer timerDondur;
        private System.Windows.Forms.Label labelHiz;
    }
}

