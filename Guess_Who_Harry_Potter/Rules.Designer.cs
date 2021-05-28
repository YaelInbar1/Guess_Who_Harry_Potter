namespace Guess_Who_Harry_Potter
{
    partial class Rules
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rules));
            this.lblRules = new System.Windows.Forms.Label();
            this.lblInstructions1 = new System.Windows.Forms.Label();
            this.lblInstructions2 = new System.Windows.Forms.Label();
            this.lblInstructions3 = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblRules
            // 
            this.lblRules.AutoSize = true;
            this.lblRules.BackColor = System.Drawing.Color.Transparent;
            this.lblRules.Font = new System.Drawing.Font("Monotype Corsiva", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRules.Location = new System.Drawing.Point(126, 38);
            this.lblRules.Name = "lblRules";
            this.lblRules.Size = new System.Drawing.Size(324, 79);
            this.lblRules.TabIndex = 0;
            this.lblRules.Text = "Instructions:";
            // 
            // lblInstructions1
            // 
            this.lblInstructions1.BackColor = System.Drawing.Color.Transparent;
            this.lblInstructions1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblInstructions1.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblInstructions1.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions1.Location = new System.Drawing.Point(638, 79);
            this.lblInstructions1.Name = "lblInstructions1";
            this.lblInstructions1.Size = new System.Drawing.Size(462, 167);
            this.lblInstructions1.TabIndex = 1;
            this.lblInstructions1.Text = resources.GetString("lblInstructions1.Text");
            // 
            // lblInstructions2
            // 
            this.lblInstructions2.BackColor = System.Drawing.Color.Transparent;
            this.lblInstructions2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblInstructions2.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblInstructions2.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions2.Location = new System.Drawing.Point(638, 260);
            this.lblInstructions2.Name = "lblInstructions2";
            this.lblInstructions2.Size = new System.Drawing.Size(462, 225);
            this.lblInstructions2.TabIndex = 2;
            this.lblInstructions2.Text = resources.GetString("lblInstructions2.Text");
            // 
            // lblInstructions3
            // 
            this.lblInstructions3.BackColor = System.Drawing.Color.Transparent;
            this.lblInstructions3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblInstructions3.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblInstructions3.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions3.Location = new System.Drawing.Point(638, 500);
            this.lblInstructions3.Name = "lblInstructions3";
            this.lblInstructions3.Size = new System.Drawing.Size(462, 165);
            this.lblInstructions3.TabIndex = 3;
            this.lblInstructions3.Text = resources.GetString("lblInstructions3.Text");
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.BackColor = System.Drawing.Color.Transparent;
            this.lblStart.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStart.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblStart.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStart.Location = new System.Drawing.Point(822, 686);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(90, 47);
            this.lblStart.TabIndex = 4;
            this.lblStart.Text = "Start";
            this.lblStart.Click += new System.EventHandler(this.lblStart_Click);
            // 
            // Rules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Guess_Who_Harry_Potter.Properties.Resources.bg_pic;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1128, 762);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.lblInstructions3);
            this.Controls.Add(this.lblInstructions2);
            this.Controls.Add(this.lblInstructions1);
            this.Controls.Add(this.lblRules);
            this.DoubleBuffered = true;
            this.Name = "Rules";
            this.Text = "Rules";
            this.Load += new System.EventHandler(this.Rules_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRules;
        private System.Windows.Forms.Label lblInstructions1;
        private System.Windows.Forms.Label lblInstructions2;
        private System.Windows.Forms.Label lblInstructions3;
        private System.Windows.Forms.Label lblStart;
    }
}