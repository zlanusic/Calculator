namespace WinUI_PresentationView.Views
{
    partial class LogonView
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
            this.tlpLogon = new System.Windows.Forms.TableLayoutPanel();
            this.lblID = new System.Windows.Forms.Label();
            this.mTxtBoxUserName = new System.Windows.Forms.TextBox();
            this.lblPwd = new System.Windows.Forms.Label();
            this.mTxtBoxPwd = new System.Windows.Forms.TextBox();
            this.mbtnOK = new System.Windows.Forms.Button();
            this.mbtnAbort = new System.Windows.Forms.Button();
            this.mSatusStripNotification = new System.Windows.Forms.StatusStrip();
            this.mTsslNotification = new System.Windows.Forms.ToolStripStatusLabel();
            this.tlpLogon.SuspendLayout();
            this.mSatusStripNotification.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpLogon
            // 
            this.tlpLogon.ColumnCount = 2;
            this.tlpLogon.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpLogon.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpLogon.Controls.Add(this.lblID, 0, 0);
            this.tlpLogon.Controls.Add(this.mTxtBoxUserName, 0, 1);
            this.tlpLogon.Controls.Add(this.lblPwd, 0, 2);
            this.tlpLogon.Controls.Add(this.mTxtBoxPwd, 0, 3);
            this.tlpLogon.Controls.Add(this.mbtnOK, 0, 5);
            this.tlpLogon.Controls.Add(this.mbtnAbort, 1, 5);
            this.tlpLogon.Controls.Add(this.mSatusStripNotification, 0, 6);
            this.tlpLogon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpLogon.Location = new System.Drawing.Point(15, 15);
            this.tlpLogon.Name = "tlpLogon";
            this.tlpLogon.RowCount = 7;
            this.tlpLogon.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpLogon.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpLogon.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpLogon.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpLogon.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpLogon.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpLogon.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpLogon.Size = new System.Drawing.Size(245, 214);
            this.tlpLogon.TabIndex = 0;
            // 
            // lblID
            // 
            this.lblID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblID.AutoSize = true;
            this.tlpLogon.SetColumnSpan(this.lblID, 2);
            this.lblID.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblID.Location = new System.Drawing.Point(0, 0);
            this.lblID.Margin = new System.Windows.Forms.Padding(0);
            this.lblID.Name = "lblID";
            this.lblID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblID.Size = new System.Drawing.Size(245, 13);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "Korisničko ime:";
            // 
            // mTxtBoxUserName
            // 
            this.mTxtBoxUserName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpLogon.SetColumnSpan(this.mTxtBoxUserName, 2);
            this.mTxtBoxUserName.Location = new System.Drawing.Point(0, 18);
            this.mTxtBoxUserName.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.mTxtBoxUserName.Name = "mTxtBoxUserName";
            this.mTxtBoxUserName.Size = new System.Drawing.Size(245, 20);
            this.mTxtBoxUserName.TabIndex = 1;
            // 
            // lblPwd
            // 
            this.lblPwd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPwd.AutoSize = true;
            this.tlpLogon.SetColumnSpan(this.lblPwd, 2);
            this.lblPwd.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblPwd.Location = new System.Drawing.Point(0, 44);
            this.lblPwd.Margin = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(245, 13);
            this.lblPwd.TabIndex = 2;
            this.lblPwd.Text = "Lozinka:";
            // 
            // mTxtBoxPwd
            // 
            this.mTxtBoxPwd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpLogon.SetColumnSpan(this.mTxtBoxPwd, 2);
            this.mTxtBoxPwd.Location = new System.Drawing.Point(0, 62);
            this.mTxtBoxPwd.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.mTxtBoxPwd.Name = "mTxtBoxPwd";
            this.mTxtBoxPwd.Size = new System.Drawing.Size(245, 20);
            this.mTxtBoxPwd.TabIndex = 3;
            // 
            // mbtnOK
            // 
            this.mbtnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mbtnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.mbtnOK.Location = new System.Drawing.Point(89, 161);
            this.mbtnOK.Margin = new System.Windows.Forms.Padding(0);
            this.mbtnOK.Name = "mbtnOK";
            this.mbtnOK.Size = new System.Drawing.Size(75, 23);
            this.mbtnOK.TabIndex = 4;
            this.mbtnOK.Text = "Prijava";
            this.mbtnOK.UseVisualStyleBackColor = true;
            this.mbtnOK.Click += new System.EventHandler(this.mbtnOK_Click);
            // 
            // mbtnAbort
            // 
            this.mbtnAbort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mbtnAbort.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.mbtnAbort.Location = new System.Drawing.Point(170, 161);
            this.mbtnAbort.Margin = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.mbtnAbort.Name = "mbtnAbort";
            this.mbtnAbort.Size = new System.Drawing.Size(75, 23);
            this.mbtnAbort.TabIndex = 5;
            this.mbtnAbort.Text = "Odustani";
            this.mbtnAbort.UseVisualStyleBackColor = true;
            // 
            // mSatusStripNotification
            // 
            this.mSatusStripNotification.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpLogon.SetColumnSpan(this.mSatusStripNotification, 2);
            this.mSatusStripNotification.Dock = System.Windows.Forms.DockStyle.None;
            this.mSatusStripNotification.GripMargin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.mSatusStripNotification.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mTsslNotification});
            this.mSatusStripNotification.Location = new System.Drawing.Point(0, 190);
            this.mSatusStripNotification.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.mSatusStripNotification.Name = "mSatusStripNotification";
            this.mSatusStripNotification.Size = new System.Drawing.Size(245, 22);
            this.mSatusStripNotification.TabIndex = 6;
            this.mSatusStripNotification.Text = "statusStrip1";
            // 
            // mTsslNotification
            // 
            this.mTsslNotification.ForeColor = System.Drawing.Color.Red;
            this.mTsslNotification.Name = "mTsslNotification";
            this.mTsslNotification.Size = new System.Drawing.Size(0, 17);
            // 
            // LoginView
            // 
            this.AcceptButton = this.mbtnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.mbtnAbort;
            this.ClientSize = new System.Drawing.Size(275, 244);
            this.Controls.Add(this.tlpLogon);
            this.ForeColor = System.Drawing.SystemColors.InfoText;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginView";
            this.Padding = new System.Windows.Forms.Padding(15);
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.Text = "Windows prijava";
            this.tlpLogon.ResumeLayout(false);
            this.tlpLogon.PerformLayout();
            this.mSatusStripNotification.ResumeLayout(false);
            this.mSatusStripNotification.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpLogon;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox mTxtBoxUserName;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.TextBox mTxtBoxPwd;
        private System.Windows.Forms.Button mbtnOK;
        private System.Windows.Forms.Button mbtnAbort;
        private System.Windows.Forms.StatusStrip mSatusStripNotification;
        private System.Windows.Forms.ToolStripStatusLabel mTsslNotification;




    }
}