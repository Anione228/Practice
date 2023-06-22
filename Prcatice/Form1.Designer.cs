namespace Prcatice
{
    partial class Form1
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.ExitButton = new FontAwesome.Sharp.IconButton();
            this.OptionButton = new FontAwesome.Sharp.IconButton();
            this.InfoButton = new FontAwesome.Sharp.IconButton();
            this.PlayButton = new FontAwesome.Sharp.IconButton();
            this.panellogo = new System.Windows.Forms.Panel();
            this.HomeButton1 = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panellogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelMenu.Controls.Add(this.ExitButton);
            this.panelMenu.Controls.Add(this.OptionButton);
            this.panelMenu.Controls.Add(this.InfoButton);
            this.panelMenu.Controls.Add(this.PlayButton);
            this.panelMenu.Controls.Add(this.panellogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 561);
            this.panelMenu.TabIndex = 0;
            // 
            // ExitButton
            // 
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.ForeColor = System.Drawing.SystemColors.Menu;
            this.ExitButton.IconChar = FontAwesome.Sharp.IconChar.RightToBracket;
            this.ExitButton.IconColor = System.Drawing.Color.MediumPurple;
            this.ExitButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ExitButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExitButton.Location = new System.Drawing.Point(0, 501);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ExitButton.Size = new System.Drawing.Size(200, 60);
            this.ExitButton.TabIndex = 7;
            this.ExitButton.Text = "Exit";
            this.ExitButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // OptionButton
            // 
            this.OptionButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OptionButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.OptionButton.FlatAppearance.BorderSize = 0;
            this.OptionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OptionButton.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OptionButton.ForeColor = System.Drawing.SystemColors.Menu;
            this.OptionButton.IconChar = FontAwesome.Sharp.IconChar.Gear;
            this.OptionButton.IconColor = System.Drawing.Color.MediumPurple;
            this.OptionButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.OptionButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OptionButton.Location = new System.Drawing.Point(0, 220);
            this.OptionButton.Name = "OptionButton";
            this.OptionButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.OptionButton.Size = new System.Drawing.Size(200, 60);
            this.OptionButton.TabIndex = 5;
            this.OptionButton.Text = "Options";
            this.OptionButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.OptionButton.UseVisualStyleBackColor = true;
            this.OptionButton.Click += new System.EventHandler(this.OptionButton_Click);
            // 
            // InfoButton
            // 
            this.InfoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InfoButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.InfoButton.FlatAppearance.BorderSize = 0;
            this.InfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InfoButton.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoButton.ForeColor = System.Drawing.SystemColors.Window;
            this.InfoButton.IconChar = FontAwesome.Sharp.IconChar.List;
            this.InfoButton.IconColor = System.Drawing.Color.MediumPurple;
            this.InfoButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.InfoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.InfoButton.Location = new System.Drawing.Point(0, 160);
            this.InfoButton.Name = "InfoButton";
            this.InfoButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.InfoButton.Size = new System.Drawing.Size(200, 60);
            this.InfoButton.TabIndex = 3;
            this.InfoButton.Text = "FaQ";
            this.InfoButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.InfoButton.UseVisualStyleBackColor = true;
            this.InfoButton.Click += new System.EventHandler(this.InfoButton_Click);
            // 
            // PlayButton
            // 
            this.PlayButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PlayButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.PlayButton.FlatAppearance.BorderSize = 0;
            this.PlayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayButton.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlayButton.ForeColor = System.Drawing.Color.White;
            this.PlayButton.IconChar = FontAwesome.Sharp.IconChar.Play;
            this.PlayButton.IconColor = System.Drawing.Color.MediumPurple;
            this.PlayButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.PlayButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PlayButton.Location = new System.Drawing.Point(0, 100);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.PlayButton.Size = new System.Drawing.Size(200, 60);
            this.PlayButton.TabIndex = 1;
            this.PlayButton.Text = "Calculate";
            this.PlayButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // panellogo
            // 
            this.panellogo.Controls.Add(this.HomeButton1);
            this.panellogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panellogo.Location = new System.Drawing.Point(0, 0);
            this.panellogo.Name = "panellogo";
            this.panellogo.Size = new System.Drawing.Size(200, 100);
            this.panellogo.TabIndex = 0;
            // 
            // HomeButton1
            // 
            this.HomeButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HomeButton1.FlatAppearance.BorderSize = 0;
            this.HomeButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeButton1.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            this.HomeButton1.IconColor = System.Drawing.Color.MediumPurple;
            this.HomeButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.HomeButton1.IconSize = 90;
            this.HomeButton1.Location = new System.Drawing.Point(0, 0);
            this.HomeButton1.Name = "HomeButton1";
            this.HomeButton1.Size = new System.Drawing.Size(200, 100);
            this.HomeButton1.TabIndex = 0;
            this.HomeButton1.UseVisualStyleBackColor = true;
            this.HomeButton1.Click += new System.EventHandler(this.HomeButton1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(200, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 561);
            this.panel1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenu);
            this.MinimumSize = new System.Drawing.Size(598, 483);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panellogo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton PlayButton;
        private System.Windows.Forms.Panel panellogo;
        private FontAwesome.Sharp.IconButton ExitButton;
        private FontAwesome.Sharp.IconButton OptionButton;
        private FontAwesome.Sharp.IconButton InfoButton;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton HomeButton1;
    }
}

