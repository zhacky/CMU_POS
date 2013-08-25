namespace CMU_Purchasing_Area
{
    partial class frmPurchasingMain
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
            this.stsPurchasing = new System.Windows.Forms.StatusStrip();
            this.stxtUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.stsPurchasing.SuspendLayout();
            this.SuspendLayout();
            // 
            // stsPurchasing
            // 
            this.stsPurchasing.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stxtUser});
            this.stsPurchasing.Location = new System.Drawing.Point(0, 438);
            this.stsPurchasing.Name = "stsPurchasing";
            this.stsPurchasing.Size = new System.Drawing.Size(661, 22);
            this.stsPurchasing.TabIndex = 0;
            this.stsPurchasing.Text = "statusStrip1";
            // 
            // stxtUser
            // 
            this.stxtUser.Name = "stxtUser";
            this.stxtUser.Size = new System.Drawing.Size(33, 17);
            this.stxtUser.Text = "User:";
            // 
            // frmPurchasingMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 460);
            this.Controls.Add(this.stsPurchasing);
            this.Name = "frmPurchasingMain";
            this.Text = "Purchasing - Central Mindanao University Canteen";
            this.stsPurchasing.ResumeLayout(false);
            this.stsPurchasing.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip stsPurchasing;
        private System.Windows.Forms.ToolStripStatusLabel stxtUser;
    }
}

