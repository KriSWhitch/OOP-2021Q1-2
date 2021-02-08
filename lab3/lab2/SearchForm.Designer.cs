namespace lab2
{
    partial class SearchForm
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
            this.LectorSearch = new System.Windows.Forms.Button();
            this.SemestrSearch = new System.Windows.Forms.Button();
            this.CourseSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LectorSearch
            // 
            this.LectorSearch.Location = new System.Drawing.Point(86, 47);
            this.LectorSearch.Name = "LectorSearch";
            this.LectorSearch.Size = new System.Drawing.Size(263, 52);
            this.LectorSearch.TabIndex = 0;
            this.LectorSearch.Text = "Поиск по лектору";
            this.LectorSearch.UseVisualStyleBackColor = true;
            this.LectorSearch.Click += new System.EventHandler(this.LectorSearch_Click);
            // 
            // SemestrSearch
            // 
            this.SemestrSearch.Location = new System.Drawing.Point(86, 145);
            this.SemestrSearch.Name = "SemestrSearch";
            this.SemestrSearch.Size = new System.Drawing.Size(263, 52);
            this.SemestrSearch.TabIndex = 0;
            this.SemestrSearch.Text = "Поиск по семестру";
            this.SemestrSearch.UseVisualStyleBackColor = true;
            this.SemestrSearch.Click += new System.EventHandler(this.SemestrSearch_Click);
            // 
            // CourseSearch
            // 
            this.CourseSearch.Location = new System.Drawing.Point(86, 244);
            this.CourseSearch.Name = "CourseSearch";
            this.CourseSearch.Size = new System.Drawing.Size(263, 52);
            this.CourseSearch.TabIndex = 0;
            this.CourseSearch.Text = "Поиск по курсу";
            this.CourseSearch.UseVisualStyleBackColor = true;
            this.CourseSearch.Click += new System.EventHandler(this.CourseSearch_Click);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 347);
            this.Controls.Add(this.CourseSearch);
            this.Controls.Add(this.SemestrSearch);
            this.Controls.Add(this.LectorSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SearchForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LectorSearch;
        private System.Windows.Forms.Button SemestrSearch;
        private System.Windows.Forms.Button CourseSearch;
    }
}