namespace Guess_Who_Harry_Potter
{
    partial class Win
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
            this.pictureBoxWin = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWin)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxWin
            // 
            this.pictureBoxWin.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxWin.BackgroundImage = global::Guess_Who_Harry_Potter.Properties.Resources.Won;
            this.pictureBoxWin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxWin.Location = new System.Drawing.Point(384, 58);
            this.pictureBoxWin.Name = "pictureBoxWin";
            this.pictureBoxWin.Size = new System.Drawing.Size(474, 190);
            this.pictureBoxWin.TabIndex = 0;
            this.pictureBoxWin.TabStop = false;
            // 
            // Win
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Guess_Who_Harry_Potter.Properties.Resources.bg_pic;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(882, 568);
            this.Controls.Add(this.pictureBoxWin);
            this.DoubleBuffered = true;
            this.Name = "Win";
            this.Text = "Win";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxWin;
    }
}