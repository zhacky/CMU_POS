namespace CMU_Point_Of_Sale_System
{
    partial class frmMain
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
            this.stsMain = new System.Windows.Forms.StatusStrip();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.itemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchasingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockMonitoringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dailySalesReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perCashierUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perStationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentModeMonitoringReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cashToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staggeredToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editSalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpManualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // stsMain
            // 
            this.stsMain.Location = new System.Drawing.Point(0, 455);
            this.stsMain.Name = "stsMain";
            this.stsMain.Size = new System.Drawing.Size(788, 22);
            this.stsMain.TabIndex = 0;
            this.stsMain.Text = "statusStrip1";
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemsToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.salesToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.usersToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(788, 24);
            this.mnuMain.TabIndex = 1;
            this.mnuMain.Text = "menuStrip1";
            // 
            // itemsToolStripMenuItem
            // 
            this.itemsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.purchasingToolStripMenuItem,
            this.productionToolStripMenuItem});
            this.itemsToolStripMenuItem.Name = "itemsToolStripMenuItem";
            this.itemsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.itemsToolStripMenuItem.Text = "&Items";
            // 
            // purchasingToolStripMenuItem
            // 
            this.purchasingToolStripMenuItem.Name = "purchasingToolStripMenuItem";
            this.purchasingToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.purchasingToolStripMenuItem.Text = "&Purchasing";
            // 
            // productionToolStripMenuItem
            // 
            this.productionToolStripMenuItem.Name = "productionToolStripMenuItem";
            this.productionToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.productionToolStripMenuItem.Text = "Pr&oduction";
            this.productionToolStripMenuItem.Click += new System.EventHandler(this.productionToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stockMonitoringToolStripMenuItem,
            this.dailySalesReportToolStripMenuItem,
            this.paymentModeMonitoringReportToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "&Reports";
            // 
            // stockMonitoringToolStripMenuItem
            // 
            this.stockMonitoringToolStripMenuItem.Name = "stockMonitoringToolStripMenuItem";
            this.stockMonitoringToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.stockMonitoringToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.stockMonitoringToolStripMenuItem.Text = "&Stock Monitoring Report";
            this.stockMonitoringToolStripMenuItem.Click += new System.EventHandler(this.stockMonitoringToolStripMenuItem_Click);
            // 
            // dailySalesReportToolStripMenuItem
            // 
            this.dailySalesReportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.perCashierUserToolStripMenuItem,
            this.perStationToolStripMenuItem});
            this.dailySalesReportToolStripMenuItem.Name = "dailySalesReportToolStripMenuItem";
            this.dailySalesReportToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.dailySalesReportToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.dailySalesReportToolStripMenuItem.Text = "&Daily Sales Report";
            // 
            // perCashierUserToolStripMenuItem
            // 
            this.perCashierUserToolStripMenuItem.Name = "perCashierUserToolStripMenuItem";
            this.perCashierUserToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.perCashierUserToolStripMenuItem.Text = "Per Cas&hier / User";
            // 
            // perStationToolStripMenuItem
            // 
            this.perStationToolStripMenuItem.Name = "perStationToolStripMenuItem";
            this.perStationToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.perStationToolStripMenuItem.Text = "Per S&tation";
            // 
            // paymentModeMonitoringReportToolStripMenuItem
            // 
            this.paymentModeMonitoringReportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cashToolStripMenuItem,
            this.creditToolStripMenuItem,
            this.staggeredToolStripMenuItem});
            this.paymentModeMonitoringReportToolStripMenuItem.Name = "paymentModeMonitoringReportToolStripMenuItem";
            this.paymentModeMonitoringReportToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.paymentModeMonitoringReportToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.paymentModeMonitoringReportToolStripMenuItem.Text = "&Payment Mode Report";
            // 
            // cashToolStripMenuItem
            // 
            this.cashToolStripMenuItem.Name = "cashToolStripMenuItem";
            this.cashToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.cashToolStripMenuItem.Text = "&Cash";
            // 
            // creditToolStripMenuItem
            // 
            this.creditToolStripMenuItem.Name = "creditToolStripMenuItem";
            this.creditToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.creditToolStripMenuItem.Text = "C&redit";
            // 
            // staggeredToolStripMenuItem
            // 
            this.staggeredToolStripMenuItem.Name = "staggeredToolStripMenuItem";
            this.staggeredToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.staggeredToolStripMenuItem.Text = "S&taggered";
            // 
            // salesToolStripMenuItem
            // 
            this.salesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.transactionWindowToolStripMenuItem,
            this.editSalesToolStripMenuItem});
            this.salesToolStripMenuItem.Name = "salesToolStripMenuItem";
            this.salesToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.salesToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.salesToolStripMenuItem.Text = "&Sales";
            // 
            // transactionWindowToolStripMenuItem
            // 
            this.transactionWindowToolStripMenuItem.Name = "transactionWindowToolStripMenuItem";
            this.transactionWindowToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.transactionWindowToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.transactionWindowToolStripMenuItem.Text = "&Transaction";
            // 
            // editSalesToolStripMenuItem
            // 
            this.editSalesToolStripMenuItem.Name = "editSalesToolStripMenuItem";
            this.editSalesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.editSalesToolStripMenuItem.Text = "&Edit Sales";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectionToolStripMenuItem,
            this.configurationToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Se&ttings";
            // 
            // connectionToolStripMenuItem
            // 
            this.connectionToolStripMenuItem.Name = "connectionToolStripMenuItem";
            this.connectionToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.connectionToolStripMenuItem.Text = "&Connection";
            // 
            // configurationToolStripMenuItem
            // 
            this.configurationToolStripMenuItem.Name = "configurationToolStripMenuItem";
            this.configurationToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.configurationToolStripMenuItem.Text = "C&onfiguration";
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageUsersToolStripMenuItem});
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.usersToolStripMenuItem.Text = "&Users";
            // 
            // manageUsersToolStripMenuItem
            // 
            this.manageUsersToolStripMenuItem.Name = "manageUsersToolStripMenuItem";
            this.manageUsersToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.manageUsersToolStripMenuItem.Text = "&Manage Users";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpManualToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // helpManualToolStripMenuItem
            // 
            this.helpManualToolStripMenuItem.Name = "helpManualToolStripMenuItem";
            this.helpManualToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.helpManualToolStripMenuItem.Text = "&Manual";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.exitToolStripMenuItem.Text = "Logout";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(788, 477);
            this.Controls.Add(this.stsMain);
            this.Controls.Add(this.mnuMain);
            this.MainMenuStrip = this.mnuMain;
            this.Name = "frmMain";
            this.Text = "Central Mindanao University - POS System";
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip stsMain;
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchasingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockMonitoringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dailySalesReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem perCashierUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem perStationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paymentModeMonitoringReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cashToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem staggeredToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editSalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpManualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

