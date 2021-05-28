namespace Guess_Who_Harry_Potter
{
    partial class playBoard
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
            this.lblInfo = new System.Windows.Forms.Label();
            this.txtMess = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.lstUsers = new System.Windows.Forms.ListBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTurn = new System.Windows.Forms.Label();
            this.lblCorrentPlayer = new System.Windows.Forms.Label();
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.lblPlayer2 = new System.Windows.Forms.Label();
            this.picBoxPlayer1 = new System.Windows.Forms.PictureBox();
            this.picBoxPlayer2 = new System.Windows.Forms.PictureBox();
            this.lblServerInfo = new System.Windows.Forms.Label();
            this.btnQuestion = new System.Windows.Forms.Button();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnGuess = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPlayer2)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblInfo.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(27, 9);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(332, 112);
            this.lblInfo.TabIndex = 0;
            // 
            // txtMess
            // 
            this.txtMess.Location = new System.Drawing.Point(3, 110);
            this.txtMess.Multiline = true;
            this.txtMess.Name = "txtMess";
            this.txtMess.Size = new System.Drawing.Size(332, 30);
            this.txtMess.TabIndex = 1;
            this.txtMess.TextChanged += new System.EventHandler(this.txtMess_TextChanged);
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnSend.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSend.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(108, 146);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(96, 35);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "SEND";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lstUsers
            // 
            this.lstUsers.FormattingEnabled = true;
            this.lstUsers.Location = new System.Drawing.Point(3, 22);
            this.lstUsers.Name = "lstUsers";
            this.lstUsers.Size = new System.Drawing.Size(258, 82);
            this.lstUsers.TabIndex = 3;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnLogin.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(78, 586);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(135, 47);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Log In";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnLogOut.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(234, 586);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(135, 47);
            this.btnLogOut.TabIndex = 5;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lstUsers);
            this.panel1.Controls.Add(this.txtMess);
            this.panel1.Controls.Add(this.btnSend);
            this.panel1.Location = new System.Drawing.Point(365, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(38, 47);
            this.panel1.TabIndex = 6;
            // 
            // lblTurn
            // 
            this.lblTurn.AutoSize = true;
            this.lblTurn.BackColor = System.Drawing.Color.Transparent;
            this.lblTurn.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurn.ForeColor = System.Drawing.Color.Black;
            this.lblTurn.Location = new System.Drawing.Point(72, 165);
            this.lblTurn.Name = "lblTurn";
            this.lblTurn.Size = new System.Drawing.Size(68, 33);
            this.lblTurn.TabIndex = 7;
            this.lblTurn.Text = "Turn:";
            // 
            // lblCorrentPlayer
            // 
            this.lblCorrentPlayer.BackColor = System.Drawing.Color.Transparent;
            this.lblCorrentPlayer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCorrentPlayer.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrentPlayer.Location = new System.Drawing.Point(146, 168);
            this.lblCorrentPlayer.Name = "lblCorrentPlayer";
            this.lblCorrentPlayer.Size = new System.Drawing.Size(150, 35);
            this.lblCorrentPlayer.TabIndex = 8;
            this.lblCorrentPlayer.Click += new System.EventHandler(this.lblCorrentPlayer_Click);
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.AutoSize = true;
            this.lblPlayer1.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayer1.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1.Location = new System.Drawing.Point(65, 233);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(107, 28);
            this.lblPlayer1.TabIndex = 9;
            this.lblPlayer1.Text = "Player 1 is:";
            this.lblPlayer1.Click += new System.EventHandler(this.lblPlayer1_Click);
            // 
            // lblPlayer2
            // 
            this.lblPlayer2.AutoSize = true;
            this.lblPlayer2.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayer2.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer2.Location = new System.Drawing.Point(191, 233);
            this.lblPlayer2.Name = "lblPlayer2";
            this.lblPlayer2.Size = new System.Drawing.Size(107, 28);
            this.lblPlayer2.TabIndex = 11;
            this.lblPlayer2.Text = "Player 2 is:";
            // 
            // picBoxPlayer1
            // 
            this.picBoxPlayer1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBoxPlayer1.Location = new System.Drawing.Point(59, 276);
            this.picBoxPlayer1.Name = "picBoxPlayer1";
            this.picBoxPlayer1.Size = new System.Drawing.Size(113, 106);
            this.picBoxPlayer1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxPlayer1.TabIndex = 13;
            this.picBoxPlayer1.TabStop = false;
            // 
            // picBoxPlayer2
            // 
            this.picBoxPlayer2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBoxPlayer2.Location = new System.Drawing.Point(196, 276);
            this.picBoxPlayer2.Name = "picBoxPlayer2";
            this.picBoxPlayer2.Size = new System.Drawing.Size(113, 106);
            this.picBoxPlayer2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxPlayer2.TabIndex = 14;
            this.picBoxPlayer2.TabStop = false;
            // 
            // lblServerInfo
            // 
            this.lblServerInfo.AutoSize = true;
            this.lblServerInfo.BackColor = System.Drawing.Color.RosyBrown;
            this.lblServerInfo.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServerInfo.Location = new System.Drawing.Point(141, 518);
            this.lblServerInfo.Name = "lblServerInfo";
            this.lblServerInfo.Size = new System.Drawing.Size(157, 28);
            this.lblServerInfo.TabIndex = 17;
            this.lblServerInfo.Text = "Connect to server";
            // 
            // btnQuestion
            // 
            this.btnQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnQuestion.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuestion.Location = new System.Drawing.Point(27, 409);
            this.btnQuestion.Name = "btnQuestion";
            this.btnQuestion.Size = new System.Drawing.Size(213, 37);
            this.btnQuestion.TabIndex = 18;
            this.btnQuestion.Text = "Press to Choose a Question";
            this.btnQuestion.UseVisualStyleBackColor = false;
            this.btnQuestion.Click += new System.EventHandler(this.btnQuestion_Click);
            // 
            // lblQuestion
            // 
            this.lblQuestion.BackColor = System.Drawing.Color.RosyBrown;
            this.lblQuestion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblQuestion.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(12, 461);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(470, 35);
            this.lblQuestion.TabIndex = 19;
            this.lblQuestion.Click += new System.EventHandler(this.lblQuestion_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(409, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(200, 100);
            this.tabControl1.TabIndex = 20;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(192, 74);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 74);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnGuess
            // 
            this.btnGuess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnGuess.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuess.Location = new System.Drawing.Point(282, 409);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(134, 37);
            this.btnGuess.TabIndex = 21;
            this.btnGuess.Text = "Guess Who!";
            this.btnGuess.UseVisualStyleBackColor = false;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // playBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Guess_Who_Harry_Potter.Properties.Resources.bg_pic;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1104, 662);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.btnQuestion);
            this.Controls.Add(this.lblServerInfo);
            this.Controls.Add(this.picBoxPlayer2);
            this.Controls.Add(this.picBoxPlayer1);
            this.Controls.Add(this.lblPlayer2);
            this.Controls.Add(this.lblPlayer1);
            this.Controls.Add(this.lblCorrentPlayer);
            this.Controls.Add(this.lblTurn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblInfo);
            this.DoubleBuffered = true;
            this.Name = "playBoard";
            this.Text = "playBoard";
            this.Load += new System.EventHandler(this.playBoard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPlayer2)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.TextBox txtMess;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.ListBox lstUsers;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTurn;
        private System.Windows.Forms.Label lblCorrentPlayer;
        private System.Windows.Forms.Label lblPlayer1;
        private System.Windows.Forms.Label lblPlayer2;
        private System.Windows.Forms.PictureBox picBoxPlayer1;
        private System.Windows.Forms.PictureBox picBoxPlayer2;
        private System.Windows.Forms.Label lblServerInfo;
        private System.Windows.Forms.Button btnQuestion;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnGuess;
    }
}