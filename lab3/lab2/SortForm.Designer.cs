namespace lab2
{
    partial class SortForm
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
            this.LectionsSortBtn = new System.Windows.Forms.Button();
            this.TypeOfControlSortBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LectionsSortBtn
            // 
            this.LectionsSortBtn.Location = new System.Drawing.Point(42, 29);
            this.LectionsSortBtn.Name = "LectionsSortBtn";
            this.LectionsSortBtn.Size = new System.Drawing.Size(334, 35);
            this.LectionsSortBtn.TabIndex = 0;
            this.LectionsSortBtn.Text = "Сортировать по количеству лекций";
            this.LectionsSortBtn.UseVisualStyleBackColor = true;
            this.LectionsSortBtn.Click += new System.EventHandler(this.LectionsSortBtn_Click);
            // 
            // TypeOfControlSortBtn
            // 
            this.TypeOfControlSortBtn.Location = new System.Drawing.Point(42, 93);
            this.TypeOfControlSortBtn.Name = "TypeOfControlSortBtn";
            this.TypeOfControlSortBtn.Size = new System.Drawing.Size(334, 35);
            this.TypeOfControlSortBtn.TabIndex = 0;
            this.TypeOfControlSortBtn.Text = "Сортировать по виду контроля";
            this.TypeOfControlSortBtn.UseVisualStyleBackColor = true;
            this.TypeOfControlSortBtn.Click += new System.EventHandler(this.TypeOfControlSortBtn_Click);
            // 
            // SortForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 152);
            this.Controls.Add(this.TypeOfControlSortBtn);
            this.Controls.Add(this.LectionsSortBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "SortForm";
            this.Text = "Сортировка данных";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SearchForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LectionsSortBtn;
        private System.Windows.Forms.Button TypeOfControlSortBtn;
    }
}