namespace Prcatice
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelTheme = new System.Windows.Forms.Panel();
            this.radioButtonDark = new System.Windows.Forms.RadioButton();
            this.radioButtonLight = new System.Windows.Forms.RadioButton();
            this.panelUnit = new System.Windows.Forms.Panel();
            this.radioButtonFt = new System.Windows.Forms.RadioButton();
            this.radioButtonKm = new System.Windows.Forms.RadioButton();
            this.panelTheme.SuspendLayout();
            this.panelUnit.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Text", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(191, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(410, 128);
            this.label1.TabIndex = 4;
            this.label1.Text = "Options";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Variable Display", 36F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(-11, -8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 64);
            this.label3.TabIndex = 7;
            this.label3.Text = "Theme";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Variable Display", 36F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 64);
            this.label4.TabIndex = 9;
            this.label4.Text = "Unit";
            // 
            // panelTheme
            // 
            this.panelTheme.Controls.Add(this.radioButtonDark);
            this.panelTheme.Controls.Add(this.label3);
            this.panelTheme.Controls.Add(this.radioButtonLight);
            this.panelTheme.Location = new System.Drawing.Point(23, 171);
            this.panelTheme.Name = "panelTheme";
            this.panelTheme.Size = new System.Drawing.Size(733, 56);
            this.panelTheme.TabIndex = 12;
            // 
            // radioButtonDark
            // 
            this.radioButtonDark.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonDark.AutoSize = true;
            this.radioButtonDark.Checked = true;
            this.radioButtonDark.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.radioButtonDark.ForeColor = System.Drawing.Color.White;
            this.radioButtonDark.Location = new System.Drawing.Point(520, 12);
            this.radioButtonDark.Name = "radioButtonDark";
            this.radioButtonDark.Size = new System.Drawing.Size(96, 41);
            this.radioButtonDark.TabIndex = 1;
            this.radioButtonDark.TabStop = true;
            this.radioButtonDark.Text = "Dark";
            this.radioButtonDark.UseVisualStyleBackColor = true;
            this.radioButtonDark.CheckedChanged += new System.EventHandler(this.radioButtonDark_CheckedChanged);
            // 
            // radioButtonLight
            // 
            this.radioButtonLight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonLight.AutoSize = true;
            this.radioButtonLight.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonLight.ForeColor = System.Drawing.Color.White;
            this.radioButtonLight.Location = new System.Drawing.Point(282, 12);
            this.radioButtonLight.Name = "radioButtonLight";
            this.radioButtonLight.Size = new System.Drawing.Size(101, 41);
            this.radioButtonLight.TabIndex = 0;
            this.radioButtonLight.Text = "Light";
            this.radioButtonLight.UseVisualStyleBackColor = true;
            this.radioButtonLight.CheckedChanged += new System.EventHandler(this.radioButtonLight_CheckedChanged);
            // 
            // panelUnit
            // 
            this.panelUnit.Controls.Add(this.radioButtonFt);
            this.panelUnit.Controls.Add(this.radioButtonKm);
            this.panelUnit.Location = new System.Drawing.Point(23, 258);
            this.panelUnit.Name = "panelUnit";
            this.panelUnit.Size = new System.Drawing.Size(733, 56);
            this.panelUnit.TabIndex = 13;
            // 
            // radioButtonFt
            // 
            this.radioButtonFt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonFt.AutoSize = true;
            this.radioButtonFt.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.radioButtonFt.ForeColor = System.Drawing.Color.White;
            this.radioButtonFt.Location = new System.Drawing.Point(520, 10);
            this.radioButtonFt.Name = "radioButtonFt";
            this.radioButtonFt.Size = new System.Drawing.Size(88, 41);
            this.radioButtonFt.TabIndex = 1;
            this.radioButtonFt.Text = "Futs";
            this.radioButtonFt.UseVisualStyleBackColor = true;
            // 
            // radioButtonKm
            // 
            this.radioButtonKm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonKm.AutoSize = true;
            this.radioButtonKm.Checked = true;
            this.radioButtonKm.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.radioButtonKm.ForeColor = System.Drawing.Color.White;
            this.radioButtonKm.Location = new System.Drawing.Point(282, 10);
            this.radioButtonKm.Name = "radioButtonKm";
            this.radioButtonKm.Size = new System.Drawing.Size(175, 41);
            this.radioButtonKm.TabIndex = 0;
            this.radioButtonKm.TabStop = true;
            this.radioButtonKm.Text = "Kilometers";
            this.radioButtonKm.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(768, 522);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelTheme);
            this.Controls.Add(this.panelUnit);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panelTheme.ResumeLayout(false);
            this.panelTheme.PerformLayout();
            this.panelUnit.ResumeLayout(false);
            this.panelUnit.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelTheme;
        private System.Windows.Forms.Panel panelUnit;
        private System.Windows.Forms.RadioButton radioButtonDark;
        public System.Windows.Forms.RadioButton radioButtonLight;
        public System.Windows.Forms.RadioButton radioButtonFt;
        public System.Windows.Forms.RadioButton radioButtonKm;
    }
}