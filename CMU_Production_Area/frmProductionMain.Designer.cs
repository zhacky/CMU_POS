namespace CMU_Production_Area
{
    partial class frmProductionMain
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
            this.stsProduction = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.stsProduction.SuspendLayout();
            this.SuspendLayout();
            // 
            // stsProduction
            // 
            this.stsProduction.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.stsProduction.Location = new System.Drawing.Point(0, 438);
            this.stsProduction.Name = "stsProduction";
            this.stsProduction.Size = new System.Drawing.Size(661, 22);
            this.stsProduction.TabIndex = 0;
            this.stsProduction.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(36, 17);
            this.toolStripStatusLabel1.Text = "User: ";
            // 
            // frmProductionMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 460);
            this.Controls.Add(this.stsProduction);
            this.Name = "frmProductionMain";
            this.Text = "Production - Central Mindanao University Canteen";
            this.stsProduction.ResumeLayout(false);
            this.stsProduction.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip stsProduction;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

