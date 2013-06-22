namespace WinUI_PresentationView.Views
{
    partial class MainView
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
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.gbAddHousehold = new System.Windows.Forms.GroupBox();
            this.tlpAddHousehold = new System.Windows.Forms.TableLayoutPanel();
            this.lblOiB = new System.Windows.Forms.Label();
            this.tbOiB = new System.Windows.Forms.TextBox();
            this.lblOwner = new System.Windows.Forms.Label();
            this.tbOwner = new System.Windows.Forms.TextBox();
            this.lblStreet = new System.Windows.Forms.Label();
            this.tbStreet = new System.Windows.Forms.TextBox();
            this.clbBillKind = new System.Windows.Forms.CheckedListBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gbMyHouseHold = new System.Windows.Forms.GroupBox();
            this.tlpCurrentHousehold = new System.Windows.Forms.TableLayoutPanel();
            this.lblCurerntHousehold = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tlpMain.SuspendLayout();
            this.gbAddHousehold.SuspendLayout();
            this.tlpAddHousehold.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbMyHouseHold.SuspendLayout();
            this.tlpCurrentHousehold.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.64067F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.35933F));
            this.tlpMain.Controls.Add(this.gbAddHousehold, 0, 0);
            this.tlpMain.Controls.Add(this.dataGridView1, 1, 0);
            this.tlpMain.Controls.Add(this.gbMyHouseHold, 0, 1);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 24);
            this.tlpMain.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 2;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.Size = new System.Drawing.Size(1084, 938);
            this.tlpMain.TabIndex = 0;
            // 
            // gbAddHousehold
            // 
            this.gbAddHousehold.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbAddHousehold.Controls.Add(this.tlpAddHousehold);
            this.gbAddHousehold.ForeColor = System.Drawing.SystemColors.InfoText;
            this.gbAddHousehold.Location = new System.Drawing.Point(0, 0);
            this.gbAddHousehold.Margin = new System.Windows.Forms.Padding(0);
            this.gbAddHousehold.Name = "gbAddHousehold";
            this.gbAddHousehold.Size = new System.Drawing.Size(299, 266);
            this.gbAddHousehold.TabIndex = 0;
            this.gbAddHousehold.TabStop = false;
            this.gbAddHousehold.Text = "Kreiraj kućanstvo";
            // 
            // tlpAddHousehold
            // 
            this.tlpAddHousehold.ColumnCount = 2;
            this.tlpAddHousehold.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAddHousehold.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpAddHousehold.Controls.Add(this.lblOiB, 0, 0);
            this.tlpAddHousehold.Controls.Add(this.tbOiB, 0, 1);
            this.tlpAddHousehold.Controls.Add(this.lblOwner, 0, 2);
            this.tlpAddHousehold.Controls.Add(this.tbOwner, 0, 3);
            this.tlpAddHousehold.Controls.Add(this.lblStreet, 0, 4);
            this.tlpAddHousehold.Controls.Add(this.tbStreet, 0, 5);
            this.tlpAddHousehold.Controls.Add(this.clbBillKind, 0, 6);
            this.tlpAddHousehold.Controls.Add(this.btnOK, 0, 8);
            this.tlpAddHousehold.Controls.Add(this.btnCancel, 1, 8);
            this.tlpAddHousehold.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpAddHousehold.Location = new System.Drawing.Point(3, 16);
            this.tlpAddHousehold.Margin = new System.Windows.Forms.Padding(0);
            this.tlpAddHousehold.Name = "tlpAddHousehold";
            this.tlpAddHousehold.RowCount = 9;
            this.tlpAddHousehold.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpAddHousehold.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpAddHousehold.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpAddHousehold.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpAddHousehold.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpAddHousehold.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpAddHousehold.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAddHousehold.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpAddHousehold.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpAddHousehold.Size = new System.Drawing.Size(293, 247);
            this.tlpAddHousehold.TabIndex = 0;
            // 
            // lblOiB
            // 
            this.lblOiB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOiB.AutoSize = true;
            this.tlpAddHousehold.SetColumnSpan(this.lblOiB, 2);
            this.lblOiB.ForeColor = System.Drawing.Color.Chocolate;
            this.lblOiB.Location = new System.Drawing.Point(0, 0);
            this.lblOiB.Margin = new System.Windows.Forms.Padding(0);
            this.lblOiB.Name = "lblOiB";
            this.lblOiB.Size = new System.Drawing.Size(293, 13);
            this.lblOiB.TabIndex = 0;
            this.lblOiB.Text = "OiB:";
            // 
            // tbOiB
            // 
            this.tbOiB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpAddHousehold.SetColumnSpan(this.tbOiB, 2);
            this.tbOiB.Location = new System.Drawing.Point(0, 18);
            this.tbOiB.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.tbOiB.Name = "tbOiB";
            this.tbOiB.Size = new System.Drawing.Size(293, 20);
            this.tbOiB.TabIndex = 1;
            // 
            // lblOwner
            // 
            this.lblOwner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOwner.AutoSize = true;
            this.tlpAddHousehold.SetColumnSpan(this.lblOwner, 2);
            this.lblOwner.ForeColor = System.Drawing.Color.Chocolate;
            this.lblOwner.Location = new System.Drawing.Point(0, 38);
            this.lblOwner.Margin = new System.Windows.Forms.Padding(0);
            this.lblOwner.Name = "lblOwner";
            this.lblOwner.Size = new System.Drawing.Size(293, 13);
            this.lblOwner.TabIndex = 2;
            this.lblOwner.Text = "Vlasnik:";
            // 
            // tbOwner
            // 
            this.tbOwner.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpAddHousehold.SetColumnSpan(this.tbOwner, 2);
            this.tbOwner.Location = new System.Drawing.Point(0, 56);
            this.tbOwner.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.tbOwner.Name = "tbOwner";
            this.tbOwner.Size = new System.Drawing.Size(293, 20);
            this.tbOwner.TabIndex = 3;
            // 
            // lblStreet
            // 
            this.lblStreet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStreet.AutoSize = true;
            this.tlpAddHousehold.SetColumnSpan(this.lblStreet, 2);
            this.lblStreet.ForeColor = System.Drawing.Color.Chocolate;
            this.lblStreet.Location = new System.Drawing.Point(0, 76);
            this.lblStreet.Margin = new System.Windows.Forms.Padding(0);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(293, 13);
            this.lblStreet.TabIndex = 4;
            this.lblStreet.Text = "Ulica i k.br.:";
            // 
            // tbStreet
            // 
            this.tbStreet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpAddHousehold.SetColumnSpan(this.tbStreet, 2);
            this.tbStreet.Location = new System.Drawing.Point(0, 94);
            this.tbStreet.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.tbStreet.Name = "tbStreet";
            this.tbStreet.Size = new System.Drawing.Size(293, 20);
            this.tbStreet.TabIndex = 5;
            // 
            // clbBillKind
            // 
            this.tlpAddHousehold.SetColumnSpan(this.clbBillKind, 2);
            this.clbBillKind.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clbBillKind.FormattingEnabled = true;
            this.clbBillKind.Items.AddRange(new object[] {
            "Holding",
            "HEP",
            "Gradska Plinara "});
            this.clbBillKind.Location = new System.Drawing.Point(0, 119);
            this.clbBillKind.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.clbBillKind.Name = "clbBillKind";
            this.clbBillKind.Size = new System.Drawing.Size(293, 95);
            this.clbBillKind.TabIndex = 6;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(137, 224);
            this.btnOK.Margin = new System.Windows.Forms.Padding(0);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "Prihvati";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(218, 224);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Odustani";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(302, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.tlpMain.SetRowSpan(this.dataGridView1, 2);
            this.dataGridView1.Size = new System.Drawing.Size(779, 932);
            this.dataGridView1.TabIndex = 1;
            // 
            // gbMyHouseHold
            // 
            this.gbMyHouseHold.Controls.Add(this.tlpCurrentHousehold);
            this.gbMyHouseHold.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbMyHouseHold.Location = new System.Drawing.Point(3, 269);
            this.gbMyHouseHold.Name = "gbMyHouseHold";
            this.gbMyHouseHold.Size = new System.Drawing.Size(293, 666);
            this.gbMyHouseHold.TabIndex = 2;
            this.gbMyHouseHold.TabStop = false;
            this.gbMyHouseHold.Text = "Moje kućanstvo";
            // 
            // tlpCurrentHousehold
            // 
            this.tlpCurrentHousehold.ColumnCount = 2;
            this.tlpCurrentHousehold.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCurrentHousehold.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpCurrentHousehold.Controls.Add(this.lblCurerntHousehold, 0, 0);
            this.tlpCurrentHousehold.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCurrentHousehold.Location = new System.Drawing.Point(3, 16);
            this.tlpCurrentHousehold.Name = "tlpCurrentHousehold";
            this.tlpCurrentHousehold.RowCount = 2;
            this.tlpCurrentHousehold.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCurrentHousehold.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCurrentHousehold.Size = new System.Drawing.Size(287, 647);
            this.tlpCurrentHousehold.TabIndex = 0;
            // 
            // lblCurerntHousehold
            // 
            this.lblCurerntHousehold.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCurerntHousehold.AutoSize = true;
            this.tlpCurrentHousehold.SetColumnSpan(this.lblCurerntHousehold, 2);
            this.lblCurerntHousehold.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblCurerntHousehold.Location = new System.Drawing.Point(3, 0);
            this.lblCurerntHousehold.MaximumSize = new System.Drawing.Size(100, 100);
            this.lblCurerntHousehold.Name = "lblCurerntHousehold";
            this.lblCurerntHousehold.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.lblCurerntHousehold.Size = new System.Drawing.Size(100, 32);
            this.lblCurerntHousehold.TabIndex = 0;
            this.lblCurerntHousehold.Text = "Trenutno kućanstvo:";
            this.lblCurerntHousehold.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(1084, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(61, 20);
            this.toolStripMenuItem1.Text = "Izbornik";
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 962);
            this.Controls.Add(this.tlpMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainView";
            this.ShowIcon = false;
            this.Text = "MainView";
            this.tlpMain.ResumeLayout(false);
            this.gbAddHousehold.ResumeLayout(false);
            this.tlpAddHousehold.ResumeLayout(false);
            this.tlpAddHousehold.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbMyHouseHold.ResumeLayout(false);
            this.tlpCurrentHousehold.ResumeLayout(false);
            this.tlpCurrentHousehold.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.GroupBox gbAddHousehold;
        private System.Windows.Forms.TableLayoutPanel tlpAddHousehold;
        private System.Windows.Forms.Label lblOiB;
        private System.Windows.Forms.TextBox tbOiB;
        private System.Windows.Forms.Label lblOwner;
        private System.Windows.Forms.TextBox tbOwner;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.TextBox tbStreet;
        private System.Windows.Forms.CheckedListBox clbBillKind;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox gbMyHouseHold;
        private System.Windows.Forms.TableLayoutPanel tlpCurrentHousehold;
        private System.Windows.Forms.Label lblCurerntHousehold;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;


    }
}