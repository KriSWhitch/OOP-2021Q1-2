namespace lab2
{
    partial class lab5
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
            this.Adapter = new System.Windows.Forms.Button();
            this.Decorator = new System.Windows.Forms.Button();
            this.lab5Display = new System.Windows.Forms.TextBox();
            this.Observer = new System.Windows.Forms.Button();
            this.Strategy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Adapter
            // 
            this.Adapter.Location = new System.Drawing.Point(13, 13);
            this.Adapter.Name = "Adapter";
            this.Adapter.Size = new System.Drawing.Size(215, 55);
            this.Adapter.TabIndex = 0;
            this.Adapter.Text = "Адаптер";
            this.Adapter.UseVisualStyleBackColor = true;
            this.Adapter.Click += new System.EventHandler(this.Adapter_Click);
            // 
            // Decorator
            // 
            this.Decorator.Location = new System.Drawing.Point(13, 92);
            this.Decorator.Name = "Decorator";
            this.Decorator.Size = new System.Drawing.Size(215, 55);
            this.Decorator.TabIndex = 0;
            this.Decorator.Text = "Декоратор";
            this.Decorator.UseVisualStyleBackColor = true;
            this.Decorator.Click += new System.EventHandler(this.Decorator_Click);
            // 
            // lab5Display
            // 
            this.lab5Display.Location = new System.Drawing.Point(266, 13);
            this.lab5Display.Multiline = true;
            this.lab5Display.Name = "lab5Display";
            this.lab5Display.ReadOnly = true;
            this.lab5Display.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.lab5Display.Size = new System.Drawing.Size(522, 416);
            this.lab5Display.TabIndex = 1;
            // 
            // Observer
            // 
            this.Observer.Location = new System.Drawing.Point(13, 173);
            this.Observer.Name = "Observer";
            this.Observer.Size = new System.Drawing.Size(215, 55);
            this.Observer.TabIndex = 0;
            this.Observer.Text = "Наблюдатель";
            this.Observer.UseVisualStyleBackColor = true;
            this.Observer.Click += new System.EventHandler(this.Observer_Click);
            // 
            // Strategy
            // 
            this.Strategy.Location = new System.Drawing.Point(13, 254);
            this.Strategy.Name = "Strategy";
            this.Strategy.Size = new System.Drawing.Size(215, 55);
            this.Strategy.TabIndex = 0;
            this.Strategy.Text = "Стратегия";
            this.Strategy.UseVisualStyleBackColor = true;
            this.Strategy.Click += new System.EventHandler(this.Strategy_Click);
            // 
            // lab5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Strategy);
            this.Controls.Add(this.Observer);
            this.Controls.Add(this.lab5Display);
            this.Controls.Add(this.Decorator);
            this.Controls.Add(this.Adapter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "lab5";
            this.Text = "lab5";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.lab5_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Adapter;
        private System.Windows.Forms.Button Decorator;
        private System.Windows.Forms.TextBox lab5Display;
        private System.Windows.Forms.Button Observer;
        private System.Windows.Forms.Button Strategy;
    }
}