namespace Guess_Who_Harry_Potter
{
    partial class Lose
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
            this.pictureBoxLose = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLose)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxLose
            // 
            this.pictureBoxLose.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLose.BackgroundImage = global::Guess_Who_Harry_Potter.Properties.Resources.Lost;
            this.pictureBoxLose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxLose.Location = new System.Drawing.Point(398, 55);
            this.pictureBoxLose.Name = "pictureBoxLose";
            this.pictureBoxLose.Size = new System.Drawing.Size(539, 186);
            this.pictureBoxLose.TabIndex = 1;
            this.pictureBoxLose.TabStop = false;
            // 
            // Lose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Guess_Who_Harry_Potter.Properties.Resources.bg_pic;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(884, 567);
            this.Controls.Add(this.pictureBoxLose);
            this.DoubleBuffered = true;
            this.Name = "Lose";
            this.Text = "Lose";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLose;
    }
}