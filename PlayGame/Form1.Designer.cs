namespace PlayGame
{
    partial class Background
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
            this.PlayGame = new System.Windows.Forms.Button();
            this.GameStartsIn = new System.Windows.Forms.Label();
            this.numbercountdown = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PlayGame
            // 
            this.PlayGame.AutoSize = true;
            this.PlayGame.BackColor = System.Drawing.Color.Black;
            this.PlayGame.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayGame.ForeColor = System.Drawing.Color.White;
            this.PlayGame.Location = new System.Drawing.Point(208, 177);
            this.PlayGame.Name = "PlayGame";
            this.PlayGame.Size = new System.Drawing.Size(353, 79);
            this.PlayGame.TabIndex = 0;
            this.PlayGame.Text = "Play Game";
            this.PlayGame.UseVisualStyleBackColor = false;
            // 
            // GameStartsIn
            // 
            this.GameStartsIn.AutoSize = true;
            this.GameStartsIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameStartsIn.ForeColor = System.Drawing.Color.White;
            this.GameStartsIn.Location = new System.Drawing.Point(286, 272);
            this.GameStartsIn.Name = "GameStartsIn";
            this.GameStartsIn.Size = new System.Drawing.Size(206, 33);
            this.GameStartsIn.TabIndex = 1;
            this.GameStartsIn.Text = "Game starts in";
            // 
            // numbercountdown
            // 
            this.numbercountdown.AutoSize = true;
            this.numbercountdown.BackColor = System.Drawing.Color.Transparent;
            this.numbercountdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numbercountdown.ForeColor = System.Drawing.Color.White;
            this.numbercountdown.Location = new System.Drawing.Point(486, 272);
            this.numbercountdown.Name = "numbercountdown";
            this.numbercountdown.Size = new System.Drawing.Size(0, 33);
            this.numbercountdown.TabIndex = 2;
            // 
            // Background
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numbercountdown);
            this.Controls.Add(this.GameStartsIn);
            this.Controls.Add(this.PlayGame);
            this.Name = "Background";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PlayGame;
        private System.Windows.Forms.Label GameStartsIn;
        private System.Windows.Forms.Label numbercountdown;
    }
}

