namespace CarCareSys
{
    partial class fromMenuMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deregisterClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerCrewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deregisterCrewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.servicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newServiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateServiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appointmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeAppointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelAppointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listDailyAppointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recordPaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.analysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.revenueAnalysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviceAnalysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listCrewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeServiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientToolStripMenuItem,
            this.crewToolStripMenuItem,
            this.servicesToolStripMenuItem,
            this.appointmentsToolStripMenuItem,
            this.analysisToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(426, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clientToolStripMenuItem
            // 
            this.clientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerClientToolStripMenuItem,
            this.updateClientToolStripMenuItem,
            this.deregisterClientToolStripMenuItem,
            this.viewHistoryToolStripMenuItem});
            this.clientToolStripMenuItem.Name = "clientToolStripMenuItem";
            this.clientToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.clientToolStripMenuItem.Text = "Client";
            this.clientToolStripMenuItem.Click += new System.EventHandler(this.clientToolStripMenuItem_Click);
            // 
            // registerClientToolStripMenuItem
            // 
            this.registerClientToolStripMenuItem.Name = "registerClientToolStripMenuItem";
            this.registerClientToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.registerClientToolStripMenuItem.Text = "Register Client";
            this.registerClientToolStripMenuItem.Click += new System.EventHandler(this.registerClientToolStripMenuItem_Click);
            // 
            // updateClientToolStripMenuItem
            // 
            this.updateClientToolStripMenuItem.Name = "updateClientToolStripMenuItem";
            this.updateClientToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.updateClientToolStripMenuItem.Text = "Update Client";
            this.updateClientToolStripMenuItem.Click += new System.EventHandler(this.updateClientToolStripMenuItem_Click);
            // 
            // deregisterClientToolStripMenuItem
            // 
            this.deregisterClientToolStripMenuItem.Name = "deregisterClientToolStripMenuItem";
            this.deregisterClientToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.deregisterClientToolStripMenuItem.Text = "De-register Client";
            this.deregisterClientToolStripMenuItem.Click += new System.EventHandler(this.deregisterClientToolStripMenuItem_Click);
            // 
            // viewHistoryToolStripMenuItem
            // 
            this.viewHistoryToolStripMenuItem.Name = "viewHistoryToolStripMenuItem";
            this.viewHistoryToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.viewHistoryToolStripMenuItem.Text = "List Clients";
            this.viewHistoryToolStripMenuItem.Click += new System.EventHandler(this.viewHistoryToolStripMenuItem_Click);
            // 
            // crewToolStripMenuItem
            // 
            this.crewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerCrewToolStripMenuItem,
            this.deregisterCrewToolStripMenuItem,
            this.listCrewToolStripMenuItem});
            this.crewToolStripMenuItem.Name = "crewToolStripMenuItem";
            this.crewToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.crewToolStripMenuItem.Text = "Crew";
            // 
            // registerCrewToolStripMenuItem
            // 
            this.registerCrewToolStripMenuItem.Name = "registerCrewToolStripMenuItem";
            this.registerCrewToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.registerCrewToolStripMenuItem.Text = "Register crew";
            this.registerCrewToolStripMenuItem.Click += new System.EventHandler(this.registerCrewToolStripMenuItem_Click);
            // 
            // deregisterCrewToolStripMenuItem
            // 
            this.deregisterCrewToolStripMenuItem.Name = "deregisterCrewToolStripMenuItem";
            this.deregisterCrewToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.deregisterCrewToolStripMenuItem.Text = "De-register crew";
            this.deregisterCrewToolStripMenuItem.Click += new System.EventHandler(this.deregisterCrewToolStripMenuItem_Click);
            // 
            // servicesToolStripMenuItem
            // 
            this.servicesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newServiceToolStripMenuItem,
            this.updateServiceToolStripMenuItem,
            this.removeServiceToolStripMenuItem});
            this.servicesToolStripMenuItem.Name = "servicesToolStripMenuItem";
            this.servicesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.servicesToolStripMenuItem.Text = "Services";
            // 
            // newServiceToolStripMenuItem
            // 
            this.newServiceToolStripMenuItem.Name = "newServiceToolStripMenuItem";
            this.newServiceToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newServiceToolStripMenuItem.Text = "New Service";
            // 
            // updateServiceToolStripMenuItem
            // 
            this.updateServiceToolStripMenuItem.Name = "updateServiceToolStripMenuItem";
            this.updateServiceToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.updateServiceToolStripMenuItem.Text = "Update Service";
            // 
            // appointmentsToolStripMenuItem
            // 
            this.appointmentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.makeAppointmentToolStripMenuItem,
            this.cancelAppointmentToolStripMenuItem,
            this.listDailyAppointmentToolStripMenuItem,
            this.recordPaymentToolStripMenuItem});
            this.appointmentsToolStripMenuItem.Name = "appointmentsToolStripMenuItem";
            this.appointmentsToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.appointmentsToolStripMenuItem.Text = "Appointments";
            // 
            // makeAppointmentToolStripMenuItem
            // 
            this.makeAppointmentToolStripMenuItem.Name = "makeAppointmentToolStripMenuItem";
            this.makeAppointmentToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.makeAppointmentToolStripMenuItem.Text = "Make Appointment";
            // 
            // cancelAppointmentToolStripMenuItem
            // 
            this.cancelAppointmentToolStripMenuItem.Name = "cancelAppointmentToolStripMenuItem";
            this.cancelAppointmentToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.cancelAppointmentToolStripMenuItem.Text = "Cancel Appointment";
            // 
            // listDailyAppointmentToolStripMenuItem
            // 
            this.listDailyAppointmentToolStripMenuItem.Name = "listDailyAppointmentToolStripMenuItem";
            this.listDailyAppointmentToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.listDailyAppointmentToolStripMenuItem.Text = "List Daily Appointment";
            // 
            // recordPaymentToolStripMenuItem
            // 
            this.recordPaymentToolStripMenuItem.Name = "recordPaymentToolStripMenuItem";
            this.recordPaymentToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.recordPaymentToolStripMenuItem.Text = "Record Payment";
            // 
            // analysisToolStripMenuItem
            // 
            this.analysisToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.revenueAnalysisToolStripMenuItem,
            this.serviceAnalysisToolStripMenuItem});
            this.analysisToolStripMenuItem.Name = "analysisToolStripMenuItem";
            this.analysisToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.analysisToolStripMenuItem.Text = "Analysis";
            // 
            // revenueAnalysisToolStripMenuItem
            // 
            this.revenueAnalysisToolStripMenuItem.Name = "revenueAnalysisToolStripMenuItem";
            this.revenueAnalysisToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.revenueAnalysisToolStripMenuItem.Text = "Revenue Analysis";
            // 
            // serviceAnalysisToolStripMenuItem
            // 
            this.serviceAnalysisToolStripMenuItem.Name = "serviceAnalysisToolStripMenuItem";
            this.serviceAnalysisToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.serviceAnalysisToolStripMenuItem.Text = "Service Analysis";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // listCrewToolStripMenuItem
            // 
            this.listCrewToolStripMenuItem.Name = "listCrewToolStripMenuItem";
            this.listCrewToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.listCrewToolStripMenuItem.Text = "List Crew";
            // 
            // removeServiceToolStripMenuItem
            // 
            this.removeServiceToolStripMenuItem.Name = "removeServiceToolStripMenuItem";
            this.removeServiceToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.removeServiceToolStripMenuItem.Text = "Remove Service";
            // 
            // fromMenuMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 235);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fromMenuMain";
            this.Text = "Total Car Care System";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem servicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem appointmentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem analysisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deregisterClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerCrewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deregisterCrewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newServiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateServiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeAppointmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelAppointmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listDailyAppointmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recordPaymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem revenueAnalysisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviceAnalysisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listCrewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeServiceToolStripMenuItem;
    }
}

