
namespace Exercise1AP
{
    partial class Form1
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
            this.btnStartGame = new System.Windows.Forms.Button();
            this.txtbx1 = new System.Windows.Forms.TextBox();
            this.txtbx2 = new System.Windows.Forms.TextBox();
            this.txtbx3 = new System.Windows.Forms.TextBox();
            this.txtbx4 = new System.Windows.Forms.TextBox();
            this.txtbxEnterGuess = new System.Windows.Forms.TextBox();
            this.bw = new System.ComponentModel.BackgroundWorker();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pb = new System.Windows.Forms.ProgressBar();
            this.lblIncorrectGuesses = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStartGame
            // 
            this.btnStartGame.Location = new System.Drawing.Point(12, 12);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(125, 23);
            this.btnStartGame.TabIndex = 0;
            this.btnStartGame.Text = "START GAME";
            this.btnStartGame.UseVisualStyleBackColor = true;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // txtbx1
            // 
            this.txtbx1.Location = new System.Drawing.Point(605, 12);
            this.txtbx1.Name = "txtbx1";
            this.txtbx1.Size = new System.Drawing.Size(32, 23);
            this.txtbx1.TabIndex = 1;
            // 
            // txtbx2
            // 
            this.txtbx2.Location = new System.Drawing.Point(652, 12);
            this.txtbx2.Name = "txtbx2";
            this.txtbx2.Size = new System.Drawing.Size(32, 23);
            this.txtbx2.TabIndex = 2;
            // 
            // txtbx3
            // 
            this.txtbx3.Location = new System.Drawing.Point(700, 13);
            this.txtbx3.Name = "txtbx3";
            this.txtbx3.Size = new System.Drawing.Size(32, 23);
            this.txtbx3.TabIndex = 3;
            // 
            // txtbx4
            // 
            this.txtbx4.Location = new System.Drawing.Point(750, 13);
            this.txtbx4.Name = "txtbx4";
            this.txtbx4.Size = new System.Drawing.Size(32, 23);
            this.txtbx4.TabIndex = 4;
            // 
            // txtbxEnterGuess
            // 
            this.txtbxEnterGuess.Location = new System.Drawing.Point(40, 41);
            this.txtbxEnterGuess.Name = "txtbxEnterGuess";
            this.txtbxEnterGuess.Size = new System.Drawing.Size(60, 23);
            this.txtbxEnterGuess.TabIndex = 5;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(155, 13);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pb
            // 
            this.pb.Location = new System.Drawing.Point(185, 380);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(452, 23);
            this.pb.TabIndex = 7;
            // 
            // lblIncorrectGuesses
            // 
            this.lblIncorrectGuesses.Location = new System.Drawing.Point(605, 57);
            this.lblIncorrectGuesses.Name = "lblIncorrectGuesses";
            this.lblIncorrectGuesses.Size = new System.Drawing.Size(177, 300);
            this.lblIncorrectGuesses.TabIndex = 8;
            this.lblIncorrectGuesses.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblIncorrectGuesses);
            this.Controls.Add(this.pb);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtbxEnterGuess);
            this.Controls.Add(this.txtbx4);
            this.Controls.Add(this.txtbx3);
            this.Controls.Add(this.txtbx2);
            this.Controls.Add(this.txtbx1);
            this.Controls.Add(this.btnStartGame);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtWrite;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.TextBox txtbx1;
        private System.Windows.Forms.TextBox txtbx2;
        private System.Windows.Forms.TextBox txtbx3;
        private System.Windows.Forms.TextBox txtbx4;
        private System.Windows.Forms.TextBox txtbxEnterGuess;
        private System.ComponentModel.BackgroundWorker bw;
        private System.Windows.Forms.ProgressBar pb;
        private System.Windows.Forms.Label lblIncorrectGuesses;
    }
}

