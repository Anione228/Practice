namespace HomePage
{
    partial class HomeForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelHome = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelHome
            // 
            this.labelHome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHome.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHome.ForeColor = System.Drawing.Color.Transparent;
            this.labelHome.Location = new System.Drawing.Point(12, 9);
            this.labelHome.Name = "labelHome";
            this.labelHome.Size = new System.Drawing.Size(769, 150);
            this.labelHome.TabIndex = 0;
            this.labelHome.Text = "Hello Welcome to my first application. \r\nThis app can calculate distance between " +
    "two cities. \r\nMore info chek in FaQ";
            // 
            // labelName
            // 
            this.labelName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Montserrat", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.ForeColor = System.Drawing.Color.White;
            this.labelName.Location = new System.Drawing.Point(13, 445);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(238, 78);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Made by Alex Yatsyna.\r\n2023 all rigts defended\r\n\r\n";
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(786, 517);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelHome);
            this.MinimumSize = new System.Drawing.Size(355, 556);
            this.Name = "HomeForm";
            this.Text = "bdfmdkl";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHome;
        private System.Windows.Forms.Label labelName;
    }
}

