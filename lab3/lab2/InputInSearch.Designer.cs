namespace lab2
{
    partial class InputInSearch
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
            this.SearchInputTextBox = new System.Windows.Forms.TextBox();
            this.SearchInputLabel = new System.Windows.Forms.Label();
            this.SearchInputButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SearchInputTextBox
            // 
            this.SearchInputTextBox.Location = new System.Drawing.Point(12, 57);
            this.SearchInputTextBox.Name = "SearchInputTextBox";
            this.SearchInputTextBox.Size = new System.Drawing.Size(285, 23);
            this.SearchInputTextBox.TabIndex = 0;
            // 
            // SearchInputLabel
            // 
            this.SearchInputLabel.AutoSize = true;
            this.SearchInputLabel.Location = new System.Drawing.Point(12, 23);
            this.SearchInputLabel.Name = "SearchInputLabel";
            this.SearchInputLabel.Size = new System.Drawing.Size(260, 15);
            this.SearchInputLabel.TabIndex = 1;
            this.SearchInputLabel.Text = "Введите текст по которому будет задан поиск:";
            // 
            // SearchInputButton
            // 
            this.SearchInputButton.Location = new System.Drawing.Point(48, 104);
            this.SearchInputButton.Name = "SearchInputButton";
            this.SearchInputButton.Size = new System.Drawing.Size(212, 38);
            this.SearchInputButton.TabIndex = 2;
            this.SearchInputButton.Text = "Поиск";
            this.SearchInputButton.UseVisualStyleBackColor = true;
            this.SearchInputButton.Click += new System.EventHandler(this.SearchInputButton_Click);
            // 
            // InputInSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 169);
            this.Controls.Add(this.SearchInputButton);
            this.Controls.Add(this.SearchInputLabel);
            this.Controls.Add(this.SearchInputTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "InputInSearch";
            this.Text = "Ввод текста для поиска";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InputInSearch_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SearchInputTextBox;
        private System.Windows.Forms.Label SearchInputLabel;
        private System.Windows.Forms.Button SearchInputButton;
    }
}