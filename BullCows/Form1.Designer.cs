namespace BullCows
{
    partial class GameBullsCows
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
            this.txtGenerate = new System.Windows.Forms.Button();
            this.lblTry = new System.Windows.Forms.Label();
            this.txtTry = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.gameBoard = new System.Windows.Forms.RichTextBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtGenerate
            // 
            this.txtGenerate.Location = new System.Drawing.Point(22, 29);
            this.txtGenerate.Name = "txtGenerate";
            this.txtGenerate.Size = new System.Drawing.Size(496, 23);
            this.txtGenerate.TabIndex = 0;
            this.txtGenerate.Text = "Генерирай";
            this.txtGenerate.UseVisualStyleBackColor = true;
            this.txtGenerate.Click += new System.EventHandler(this.txtGenerate_Click);
            // 
            // lblTry
            // 
            this.lblTry.AutoSize = true;
            this.lblTry.Location = new System.Drawing.Point(20, 111);
            this.lblTry.Name = "lblTry";
            this.lblTry.Size = new System.Drawing.Size(32, 13);
            this.lblTry.TabIndex = 1;
            this.lblTry.Text = "Опит";
            // 
            // txtTry
            // 
            this.txtTry.Enabled = false;
            this.txtTry.Location = new System.Drawing.Point(93, 111);
            this.txtTry.Name = "txtTry";
            this.txtTry.Size = new System.Drawing.Size(96, 20);
            this.txtTry.TabIndex = 2;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(195, 106);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(166, 23);
            this.btnCheck.TabIndex = 3;
            this.btnCheck.Text = "Провери";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(20, 66);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 4;
            // 
            // gameBoard
            // 
            this.gameBoard.Location = new System.Drawing.Point(22, 162);
            this.gameBoard.Name = "gameBoard";
            this.gameBoard.Size = new System.Drawing.Size(405, 235);
            this.gameBoard.TabIndex = 5;
            this.gameBoard.Text = "";
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(377, 106);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 6;
            this.btnShow.Text = "Покажи";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // GameBullsCows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 436);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.gameBoard);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.txtTry);
            this.Controls.Add(this.lblTry);
            this.Controls.Add(this.txtGenerate);
            this.Name = "GameBullsCows";
            this.Text = "Крави и Бикове";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button txtGenerate;
        private System.Windows.Forms.Label lblTry;
        private System.Windows.Forms.TextBox txtTry;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.RichTextBox gameBoard;
        private System.Windows.Forms.Button btnShow;
    }
}

