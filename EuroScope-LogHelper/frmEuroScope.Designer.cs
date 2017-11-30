namespace EuroScope_LogHelper
{
    partial class frmEuroScope
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCallsign = new System.Windows.Forms.TextBox();
            this.txtSquawk = new System.Windows.Forms.TextBox();
            this.txtOrigin = new System.Windows.Forms.TextBox();
            this.lvFlight = new System.Windows.Forms.ListView();
            this.colCallsign = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colOrigin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDestination = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRoute = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSquawk = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colGate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFlightMode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colClearance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPush = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTaxi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHandoff = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.radIFR = new System.Windows.Forms.RadioButton();
            this.radVFR = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtStar = new System.Windows.Forms.TextBox();
            this.txtSid = new System.Windows.Forms.TextBox();
            this.chkClearance = new System.Windows.Forms.CheckBox();
            this.chkTaxi = new System.Windows.Forms.CheckBox();
            this.chkHandOff = new System.Windows.Forms.CheckBox();
            this.chkPushback = new System.Windows.Forms.CheckBox();
            this.chkParking = new System.Windows.Forms.CheckBox();
            this.cmdEnter = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmdReport = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdClearance = new System.Windows.Forms.Button();
            this.cmdBeenden = new System.Windows.Forms.Button();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(537, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "EuroScope - LogHelper";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 41);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Callsign";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Location = new System.Drawing.Point(9, 30);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(538, 10);
            this.panel1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(257, 41);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Squawk";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(174, 41);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "To";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(89, 41);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "From";
            // 
            // txtCallsign
            // 
            this.txtCallsign.Location = new System.Drawing.Point(9, 60);
            this.txtCallsign.Margin = new System.Windows.Forms.Padding(2);
            this.txtCallsign.Name = "txtCallsign";
            this.txtCallsign.Size = new System.Drawing.Size(80, 26);
            this.txtCallsign.TabIndex = 6;
            // 
            // txtSquawk
            // 
            this.txtSquawk.Location = new System.Drawing.Point(261, 60);
            this.txtSquawk.Margin = new System.Windows.Forms.Padding(2);
            this.txtSquawk.Name = "txtSquawk";
            this.txtSquawk.Size = new System.Drawing.Size(62, 26);
            this.txtSquawk.TabIndex = 7;
            // 
            // txtOrigin
            // 
            this.txtOrigin.Location = new System.Drawing.Point(93, 60);
            this.txtOrigin.Margin = new System.Windows.Forms.Padding(2);
            this.txtOrigin.Name = "txtOrigin";
            this.txtOrigin.Size = new System.Drawing.Size(80, 26);
            this.txtOrigin.TabIndex = 9;
            // 
            // lvFlight
            // 
            this.lvFlight.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colCallsign,
            this.colOrigin,
            this.colDestination,
            this.colRoute,
            this.colSquawk,
            this.colGate,
            this.colFlightMode,
            this.colClearance,
            this.colPush,
            this.colTaxi,
            this.colHandoff});
            this.lvFlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lvFlight.FullRowSelect = true;
            this.lvFlight.Location = new System.Drawing.Point(9, 192);
            this.lvFlight.Margin = new System.Windows.Forms.Padding(2);
            this.lvFlight.MultiSelect = false;
            this.lvFlight.Name = "lvFlight";
            this.lvFlight.Size = new System.Drawing.Size(538, 162);
            this.lvFlight.TabIndex = 10;
            this.lvFlight.UseCompatibleStateImageBehavior = false;
            this.lvFlight.View = System.Windows.Forms.View.Details;
            // 
            // colCallsign
            // 
            this.colCallsign.Text = "Callsign";
            this.colCallsign.Width = 80;
            // 
            // colOrigin
            // 
            this.colOrigin.Text = "Origin";
            this.colOrigin.Width = 50;
            // 
            // colDestination
            // 
            this.colDestination.Text = "Destin";
            this.colDestination.Width = 50;
            // 
            // colRoute
            // 
            this.colRoute.Text = "SID / STAR";
            this.colRoute.Width = 80;
            // 
            // colSquawk
            // 
            this.colSquawk.Text = "Squawk";
            // 
            // colGate
            // 
            this.colGate.Text = "Gate";
            this.colGate.Width = 40;
            // 
            // colFlightMode
            // 
            this.colFlightMode.Text = "Mode";
            this.colFlightMode.Width = 40;
            // 
            // colClearance
            // 
            this.colClearance.Text = "CL";
            this.colClearance.Width = 30;
            // 
            // colPush
            // 
            this.colPush.Text = "PB";
            this.colPush.Width = 30;
            // 
            // colTaxi
            // 
            this.colTaxi.Text = "TX";
            this.colTaxi.Width = 30;
            // 
            // colHandoff
            // 
            this.colHandoff.Text = "HO";
            this.colHandoff.Width = 30;
            // 
            // radIFR
            // 
            this.radIFR.AutoSize = true;
            this.radIFR.Location = new System.Drawing.Point(446, 60);
            this.radIFR.Margin = new System.Windows.Forms.Padding(2);
            this.radIFR.Name = "radIFR";
            this.radIFR.Size = new System.Drawing.Size(48, 24);
            this.radIFR.TabIndex = 11;
            this.radIFR.TabStop = true;
            this.radIFR.Text = "IFR";
            this.radIFR.UseVisualStyleBackColor = true;
            // 
            // radVFR
            // 
            this.radVFR.AutoSize = true;
            this.radVFR.Location = new System.Drawing.Point(493, 60);
            this.radVFR.Margin = new System.Windows.Forms.Padding(2);
            this.radVFR.Name = "radVFR";
            this.radVFR.Size = new System.Drawing.Size(54, 24);
            this.radVFR.TabIndex = 12;
            this.radVFR.TabStop = true;
            this.radVFR.Text = "VFR";
            this.radVFR.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(89, 88);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "STAR";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(174, 88);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "SID";
            // 
            // txtStar
            // 
            this.txtStar.Location = new System.Drawing.Point(93, 111);
            this.txtStar.Name = "txtStar";
            this.txtStar.Size = new System.Drawing.Size(80, 26);
            this.txtStar.TabIndex = 15;
            // 
            // txtSid
            // 
            this.txtSid.Location = new System.Drawing.Point(177, 111);
            this.txtSid.Name = "txtSid";
            this.txtSid.Size = new System.Drawing.Size(80, 26);
            this.txtSid.TabIndex = 16;
            // 
            // chkClearance
            // 
            this.chkClearance.AutoSize = true;
            this.chkClearance.Location = new System.Drawing.Point(261, 113);
            this.chkClearance.Name = "chkClearance";
            this.chkClearance.Size = new System.Drawing.Size(47, 24);
            this.chkClearance.TabIndex = 17;
            this.chkClearance.Text = "CL";
            this.chkClearance.UseVisualStyleBackColor = true;
            // 
            // chkTaxi
            // 
            this.chkTaxi.AutoSize = true;
            this.chkTaxi.Location = new System.Drawing.Point(366, 113);
            this.chkTaxi.Name = "chkTaxi";
            this.chkTaxi.Size = new System.Drawing.Size(42, 24);
            this.chkTaxi.TabIndex = 18;
            this.chkTaxi.Text = "TX";
            this.chkTaxi.UseVisualStyleBackColor = true;
            // 
            // chkHandOff
            // 
            this.chkHandOff.AutoSize = true;
            this.chkHandOff.Location = new System.Drawing.Point(414, 113);
            this.chkHandOff.Name = "chkHandOff";
            this.chkHandOff.Size = new System.Drawing.Size(51, 24);
            this.chkHandOff.TabIndex = 19;
            this.chkHandOff.Text = "HO";
            this.chkHandOff.UseVisualStyleBackColor = true;
            // 
            // chkPushback
            // 
            this.chkPushback.AutoSize = true;
            this.chkPushback.Location = new System.Drawing.Point(314, 113);
            this.chkPushback.Name = "chkPushback";
            this.chkPushback.Size = new System.Drawing.Size(46, 24);
            this.chkPushback.TabIndex = 20;
            this.chkPushback.Text = "PB";
            this.chkPushback.UseVisualStyleBackColor = true;
            // 
            // chkParking
            // 
            this.chkParking.AutoSize = true;
            this.chkParking.Location = new System.Drawing.Point(471, 113);
            this.chkParking.Name = "chkParking";
            this.chkParking.Size = new System.Drawing.Size(48, 24);
            this.chkParking.TabIndex = 21;
            this.chkParking.Text = "PA";
            this.chkParking.UseVisualStyleBackColor = true;
            // 
            // cmdEnter
            // 
            this.cmdEnter.AutoSize = true;
            this.cmdEnter.Location = new System.Drawing.Point(451, 157);
            this.cmdEnter.Name = "cmdEnter";
            this.cmdEnter.Size = new System.Drawing.Size(96, 30);
            this.cmdEnter.TabIndex = 22;
            this.cmdEnter.Text = "Eintragen";
            this.cmdEnter.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SeaGreen;
            this.panel2.Location = new System.Drawing.Point(9, 142);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(538, 10);
            this.panel2.TabIndex = 3;
            // 
            // cmdReport
            // 
            this.cmdReport.AutoSize = true;
            this.cmdReport.Location = new System.Drawing.Point(449, 359);
            this.cmdReport.Name = "cmdReport";
            this.cmdReport.Size = new System.Drawing.Size(98, 30);
            this.cmdReport.TabIndex = 23;
            this.cmdReport.Text = "Auswerten";
            this.cmdReport.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(324, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 20);
            this.label8.TabIndex = 24;
            this.label8.Text = "Gate";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(328, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(44, 26);
            this.textBox1.TabIndex = 25;
            // 
            // cmdCancel
            // 
            this.cmdCancel.AutoSize = true;
            this.cmdCancel.BackColor = System.Drawing.Color.Red;
            this.cmdCancel.Location = new System.Drawing.Point(365, 157);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(80, 30);
            this.cmdCancel.TabIndex = 26;
            this.cmdCancel.Text = "CANCEL";
            this.cmdCancel.UseVisualStyleBackColor = false;
            // 
            // cmdClearance
            // 
            this.cmdClearance.AutoSize = true;
            this.cmdClearance.Location = new System.Drawing.Point(9, 157);
            this.cmdClearance.Name = "cmdClearance";
            this.cmdClearance.Size = new System.Drawing.Size(98, 30);
            this.cmdClearance.TabIndex = 27;
            this.cmdClearance.Text = "Clearance";
            this.cmdClearance.UseVisualStyleBackColor = true;
            this.cmdClearance.Click += new System.EventHandler(this.cmdClearance_Click);
            // 
            // cmdBeenden
            // 
            this.cmdBeenden.AutoSize = true;
            this.cmdBeenden.Location = new System.Drawing.Point(9, 359);
            this.cmdBeenden.Name = "cmdBeenden";
            this.cmdBeenden.Size = new System.Drawing.Size(86, 30);
            this.cmdBeenden.TabIndex = 28;
            this.cmdBeenden.Text = "Beenden";
            this.cmdBeenden.UseVisualStyleBackColor = true;
            this.cmdBeenden.Click += new System.EventHandler(this.cmdBeenden_Click);
            // 
            // txtDestination
            // 
            this.txtDestination.AutoCompleteCustomSource.AddRange(new string[] {
            "EDDN",
            "EDDM",
            "EDDS"});
            this.txtDestination.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtDestination.Location = new System.Drawing.Point(177, 60);
            this.txtDestination.Margin = new System.Windows.Forms.Padding(2);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Size = new System.Drawing.Size(80, 26);
            this.txtDestination.TabIndex = 29;
            // 
            // frmEuroScope
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 401);
            this.Controls.Add(this.txtDestination);
            this.Controls.Add(this.cmdBeenden);
            this.Controls.Add(this.cmdClearance);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmdReport);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.cmdEnter);
            this.Controls.Add(this.chkParking);
            this.Controls.Add(this.chkPushback);
            this.Controls.Add(this.chkHandOff);
            this.Controls.Add(this.chkTaxi);
            this.Controls.Add(this.chkClearance);
            this.Controls.Add(this.txtSid);
            this.Controls.Add(this.txtStar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.radVFR);
            this.Controls.Add(this.radIFR);
            this.Controls.Add(this.lvFlight);
            this.Controls.Add(this.txtOrigin);
            this.Controls.Add(this.txtSquawk);
            this.Controls.Add(this.txtCallsign);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Name = "frmEuroScope";
            this.Text = "EuroScope - LogHelper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCallsign;
        private System.Windows.Forms.TextBox txtSquawk;
        private System.Windows.Forms.TextBox txtOrigin;
        private System.Windows.Forms.ListView lvFlight;
        private System.Windows.Forms.ColumnHeader colCallsign;
        private System.Windows.Forms.ColumnHeader colOrigin;
        private System.Windows.Forms.ColumnHeader colDestination;
        private System.Windows.Forms.ColumnHeader colRoute;
        private System.Windows.Forms.ColumnHeader colSquawk;
        private System.Windows.Forms.ColumnHeader colGate;
        private System.Windows.Forms.ColumnHeader colFlightMode;
        private System.Windows.Forms.ColumnHeader colClearance;
        private System.Windows.Forms.ColumnHeader colPush;
        private System.Windows.Forms.ColumnHeader colTaxi;
        private System.Windows.Forms.ColumnHeader colHandoff;
        private System.Windows.Forms.RadioButton radIFR;
        private System.Windows.Forms.RadioButton radVFR;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtStar;
        private System.Windows.Forms.TextBox txtSid;
        private System.Windows.Forms.CheckBox chkClearance;
        private System.Windows.Forms.CheckBox chkTaxi;
        private System.Windows.Forms.CheckBox chkHandOff;
        private System.Windows.Forms.CheckBox chkPushback;
        private System.Windows.Forms.CheckBox chkParking;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button cmdEnter;
        private System.Windows.Forms.Button cmdReport;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Button cmdClearance;
        private System.Windows.Forms.Button cmdBeenden;
        private System.Windows.Forms.TextBox txtDestination;
    }
}

