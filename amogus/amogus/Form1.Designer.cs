namespace amogus
{
    partial class mainForm
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
            this.components = new System.ComponentModel.Container();
            this.amogusPic = new System.Windows.Forms.PictureBox();
            this.moveWindow = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.amogusPic)).BeginInit();
            this.SuspendLayout();
            // 
            // amogusPic
            // 
            this.amogusPic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.amogusPic.Image = global::amogus.Properties.Resources.amogus;
            this.amogusPic.Location = new System.Drawing.Point(0, 0);
            this.amogusPic.Name = "amogusPic";
            this.amogusPic.Size = new System.Drawing.Size(800, 450);
            this.amogusPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.amogusPic.TabIndex = 0;
            this.amogusPic.TabStop = false;
            this.amogusPic.Click += new System.EventHandler(this.amogusPic_Click);
            // 
            // moveWindow
            // 
            this.moveWindow.Tick += new System.EventHandler(this.moveWindow_Tick);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.amogusPic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mainForm";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Turquoise;
            ((System.ComponentModel.ISupportInitialize)(this.amogusPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox amogusPic;
        private System.Windows.Forms.Timer moveWindow;
    }
}