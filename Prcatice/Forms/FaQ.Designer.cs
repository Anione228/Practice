namespace Prcatice.Forms
{
    partial class FaQ
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FaQ));
            this.labelFaQ = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelFaQ
            // 
            this.labelFaQ.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFaQ.Font = new System.Drawing.Font("Segoe UI Variable Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFaQ.ForeColor = System.Drawing.Color.White;
            this.labelFaQ.Location = new System.Drawing.Point(12, 1);
            this.labelFaQ.Name = "labelFaQ";
            this.labelFaQ.Size = new System.Drawing.Size(744, 436);
            this.labelFaQ.TabIndex = 0;
            this.labelFaQ.Text = resources.GetString("labelFaQ.Text");
            // 
            // FaQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(768, 522);
            this.Controls.Add(this.labelFaQ);
            this.Name = "FaQ";
            this.Text = "FaQ";
            this.Load += new System.EventHandler(this.FaQ_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelFaQ;
    }
}