namespace Guess_Who_Harry_Potter
{
    partial class Category
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
            this.lblHair = new System.Windows.Forms.Label();
            this.lblEyes = new System.Windows.Forms.Label();
            this.lblNose = new System.Windows.Forms.Label();
            this.lblHouse = new System.Windows.Forms.Label();
            this.picboxCategory = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picboxCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHair
            // 
            this.lblHair.AutoSize = true;
            this.lblHair.BackColor = System.Drawing.Color.Transparent;
            this.lblHair.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHair.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHair.Location = new System.Drawing.Point(55, 135);
            this.lblHair.Name = "lblHair";
            this.lblHair.Size = new System.Drawing.Size(78, 45);
            this.lblHair.TabIndex = 0;
            this.lblHair.Text = "Hair";
            // 
            // lblEyes
            // 
            this.lblEyes.AutoSize = true;
            this.lblEyes.BackColor = System.Drawing.Color.Transparent;
            this.lblEyes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEyes.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEyes.Location = new System.Drawing.Point(626, 135);
            this.lblEyes.Name = "lblEyes";
            this.lblEyes.Size = new System.Drawing.Size(80, 45);
            this.lblEyes.TabIndex = 1;
            this.lblEyes.Text = "Eyes";
            // 
            // lblNose
            // 
            this.lblNose.AutoSize = true;
            this.lblNose.BackColor = System.Drawing.Color.Transparent;
            this.lblNose.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNose.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNose.Location = new System.Drawing.Point(337, 135);
            this.lblNose.Name = "lblNose";
            this.lblNose.Size = new System.Drawing.Size(83, 45);
            this.lblNose.TabIndex = 2;
            this.lblNose.Text = "Nose";
            // 
            // lblHouse
            // 
            this.lblHouse.AutoSize = true;
            this.lblHouse.BackColor = System.Drawing.Color.Transparent;
            this.lblHouse.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHouse.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHouse.Location = new System.Drawing.Point(908, 135);
            this.lblHouse.Name = "lblHouse";
            this.lblHouse.Size = new System.Drawing.Size(98, 45);
            this.lblHouse.TabIndex = 3;
            this.lblHouse.Text = "House";
            // 
            // picboxCategory
            // 
            this.picboxCategory.BackColor = System.Drawing.Color.Transparent;
            this.picboxCategory.BackgroundImage = global::Guess_Who_Harry_Potter.Properties.Resources.Category;
            this.picboxCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picboxCategory.Location = new System.Drawing.Point(55, 12);
            this.picboxCategory.Name = "picboxCategory";
            this.picboxCategory.Size = new System.Drawing.Size(951, 105);
            this.picboxCategory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxCategory.TabIndex = 4;
            this.picboxCategory.TabStop = false;
            // 
            // Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Guess_Who_Harry_Potter.Properties.Resources.bg_pic;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1082, 723);
            this.Controls.Add(this.picboxCategory);
            this.Controls.Add(this.lblHouse);
            this.Controls.Add(this.lblNose);
            this.Controls.Add(this.lblEyes);
            this.Controls.Add(this.lblHair);
            this.DoubleBuffered = true;
            this.Name = "Category";
            this.Text = "Category";
            ((System.ComponentModel.ISupportInitialize)(this.picboxCategory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHair;
        private System.Windows.Forms.Label lblEyes;
        private System.Windows.Forms.Label lblNose;
        private System.Windows.Forms.Label lblHouse;
        private System.Windows.Forms.PictureBox picboxCategory;
    }
}