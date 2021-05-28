namespace Guess_Who_Harry_Potter
{
    partial class ChoseGuess
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
            this.btnChosen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnChosen
            // 
            this.btnChosen.BackColor = System.Drawing.Color.Transparent;
            this.btnChosen.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChosen.Location = new System.Drawing.Point(142, 588);
            this.btnChosen.Name = "btnChosen";
            this.btnChosen.Size = new System.Drawing.Size(265, 46);
            this.btnChosen.TabIndex = 0;
            this.btnChosen.Text = "I chose the character!";
            this.btnChosen.UseVisualStyleBackColor = false;
            this.btnChosen.Click += new System.EventHandler(this.btnChosen_Click);
            // 
            // ChoseGuess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Guess_Who_Harry_Potter.Properties.Resources.bg_pic;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1106, 653);
            this.Controls.Add(this.btnChosen);
            this.DoubleBuffered = true;
            this.Name = "ChoseGuess";
            this.Text = "ChoseGuess";
            this.Load += new System.EventHandler(this.ChoseGuess_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnChosen;
    }
}