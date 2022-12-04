namespace GuessGame
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        
        #region Код, автоматически созданный конструктором форм Windows

        private void InitializeComponent()
        {
            this.CorrectCountLabel = new System.Windows.Forms.Label();
            this.ControlLabel = new System.Windows.Forms.Label();
            this.ResetButton = new System.Windows.Forms.Button();
            this.GuessButton = new System.Windows.Forms.Button();
            this.EnterTextBox = new System.Windows.Forms.TextBox();
            this.GreetingLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CorrectCountLabel
            // 
            this.CorrectCountLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CorrectCountLabel.AutoSize = true;
            this.CorrectCountLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CorrectCountLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.CorrectCountLabel.Location = new System.Drawing.Point(47, 236);
            this.CorrectCountLabel.Name = "CorrectCountLabel";
            this.CorrectCountLabel.Size = new System.Drawing.Size(154, 23);
            this.CorrectCountLabel.TabIndex = 5;
            this.CorrectCountLabel.Text = "Correctly guessed: ";
            // 
            // ControlLabel
            // 
            this.ControlLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ControlLabel.AutoSize = true;
            this.ControlLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ControlLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ControlLabel.Location = new System.Drawing.Point(374, 138);
            this.ControlLabel.Name = "ControlLabel";
            this.ControlLabel.Size = new System.Drawing.Size(129, 23);
            this.ControlLabel.TabIndex = 3;
            this.ControlLabel.Text = "Enter a number";
            this.ControlLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ResetButton
            // 
            this.ResetButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ResetButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ResetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.ResetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResetButton.Location = new System.Drawing.Point(51, 353);
            this.ResetButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(106, 45);
            this.ResetButton.TabIndex = 4;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = false;
            this.ResetButton.Click += new System.EventHandler(this.Reset_Click);
            // 
            // GuessButton
            // 
            this.GuessButton.AllowDrop = true;
            this.GuessButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GuessButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.GuessButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GuessButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GuessButton.Location = new System.Drawing.Point(397, 353);
            this.GuessButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GuessButton.Name = "GuessButton";
            this.GuessButton.Size = new System.Drawing.Size(106, 45);
            this.GuessButton.TabIndex = 2;
            this.GuessButton.Text = "Guess";
            this.GuessButton.UseVisualStyleBackColor = false;
            this.GuessButton.Click += new System.EventHandler(this.Guess_Click);
            // 
            // EnterTextBox
            // 
            this.EnterTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EnterTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.EnterTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EnterTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnterTextBox.Location = new System.Drawing.Point(370, 239);
            this.EnterTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EnterTextBox.Name = "EnterTextBox";
            this.EnterTextBox.Size = new System.Drawing.Size(153, 30);
            this.EnterTextBox.TabIndex = 1;
            // 
            // GreetingLabel
            // 
            this.GreetingLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.GreetingLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GreetingLabel.AutoSize = true;
            this.GreetingLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GreetingLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.GreetingLabel.Location = new System.Drawing.Point(272, 61);
            this.GreetingLabel.Name = "GreetingLabel";
            this.GreetingLabel.Size = new System.Drawing.Size(361, 23);
            this.GreetingLabel.TabIndex = 4;
            this.GreetingLabel.Text = "You need to guess a number between 1 and 9";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.ClientSize = new System.Drawing.Size(902, 468);
            this.Controls.Add(this.ControlLabel);
            this.Controls.Add(this.EnterTextBox);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.GuessButton);
            this.Controls.Add(this.CorrectCountLabel);
            this.Controls.Add(this.GreetingLabel);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(920, 515);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Guess_Enter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button GuessButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.TextBox EnterTextBox;
        private System.Windows.Forms.Label ControlLabel;
        private System.Windows.Forms.Label CorrectCountLabel;
        private System.Windows.Forms.Label GreetingLabel;
    }
}

