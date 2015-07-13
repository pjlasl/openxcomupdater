namespace WindowsFormsApplication1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.sideNav1 = new DevComponents.DotNetBar.Controls.SideNav();
            this.sideNavPanel1 = new DevComponents.DotNetBar.Controls.SideNavPanel();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.listView1 = new System.Windows.Forms.ListView();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.progressBarX1 = new DevComponents.DotNetBar.Controls.ProgressBarX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.sideNavPanel2 = new DevComponents.DotNetBar.Controls.SideNavPanel();
            this.chkPerformBackup = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txtDomain = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblDomain = new DevComponents.DotNetBar.LabelX();
            this.buttonX4 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX3 = new DevComponents.DotNetBar.ButtonX();
            this.checkBoxX2 = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.checkBoxX1 = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.txtProxyUrl = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtProxyPort = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtProxyUserId = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtProxyPassword = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblPassword = new DevComponents.DotNetBar.LabelX();
            this.lblUser = new DevComponents.DotNetBar.LabelX();
            this.lblPort = new DevComponents.DotNetBar.LabelX();
            this.lblUrl = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.sideNavItem1 = new DevComponents.DotNetBar.Controls.SideNavItem();
            this.separator1 = new DevComponents.DotNetBar.Separator();
            this.sideNavItem2 = new DevComponents.DotNetBar.Controls.SideNavItem();
            this.sideNavItem3 = new DevComponents.DotNetBar.Controls.SideNavItem();
            this.sideNav1.SuspendLayout();
            this.sideNavPanel1.SuspendLayout();
            this.panelEx1.SuspendLayout();
            this.panelEx2.SuspendLayout();
            this.sideNavPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2013;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // sideNav1
            // 
            this.sideNav1.Controls.Add(this.sideNavPanel1);
            this.sideNav1.Controls.Add(this.sideNavPanel2);
            this.sideNav1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sideNav1.EnableClose = false;
            this.sideNav1.EnableMaximize = false;
            this.sideNav1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.sideNavItem1,
            this.separator1,
            this.sideNavItem2,
            this.sideNavItem3});
            this.sideNav1.Location = new System.Drawing.Point(0, 0);
            this.sideNav1.Name = "sideNav1";
            this.sideNav1.Padding = new System.Windows.Forms.Padding(1);
            this.sideNav1.Size = new System.Drawing.Size(791, 391);
            this.sideNav1.TabIndex = 0;
            this.sideNav1.Text = "sideNav1";
            // 
            // sideNavPanel1
            // 
            this.sideNavPanel1.Controls.Add(this.labelX1);
            this.sideNavPanel1.Controls.Add(this.listView1);
            this.sideNavPanel1.Controls.Add(this.panelEx1);
            this.sideNavPanel1.Controls.Add(this.panelEx2);
            this.sideNavPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sideNavPanel1.Location = new System.Drawing.Point(88, 31);
            this.sideNavPanel1.Name = "sideNavPanel1";
            this.sideNavPanel1.Size = new System.Drawing.Size(698, 359);
            this.sideNavPanel1.TabIndex = 2;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelX1.Location = new System.Drawing.Point(296, 38);
            this.labelX1.Name = "labelX1";
            this.labelX1.PaddingLeft = 5;
            this.labelX1.PaddingTop = 5;
            this.labelX1.Size = new System.Drawing.Size(270, 321);
            this.labelX1.TabIndex = 22;
            this.labelX1.TextLineAlignment = System.Drawing.StringAlignment.Near;
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.listView1.Location = new System.Drawing.Point(0, 38);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(296, 321);
            this.listView1.TabIndex = 23;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.SmallIcon;
            this.listView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView1_ItemSelectionChanged_1);
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.buttonX2);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(566, 38);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            this.panelEx1.Text = "Available Nightly Downloads";
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX2.Location = new System.Drawing.Point(8, 8);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(75, 23);
            this.buttonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX2.Symbol = "";
            this.buttonX2.SymbolSize = 12F;
            this.buttonX2.TabIndex = 0;
            this.buttonX2.Text = "Retrieve";
            this.buttonX2.Click += new System.EventHandler(this.buttonX2_Click);
            // 
            // panelEx2
            // 
            this.panelEx2.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx2.Controls.Add(this.progressBarX1);
            this.panelEx2.Controls.Add(this.buttonX1);
            this.panelEx2.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelEx2.Location = new System.Drawing.Point(566, 0);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Size = new System.Drawing.Size(132, 359);
            this.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx2.Style.GradientAngle = 90;
            this.panelEx2.TabIndex = 4;
            // 
            // progressBarX1
            // 
            // 
            // 
            // 
            this.progressBarX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.progressBarX1.Location = new System.Drawing.Point(6, 111);
            this.progressBarX1.Name = "progressBarX1";
            this.progressBarX1.Size = new System.Drawing.Size(119, 23);
            this.progressBarX1.TabIndex = 1;
            this.progressBarX1.Text = "Downloading...";
            this.progressBarX1.TextVisible = true;
            this.progressBarX1.Visible = false;
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonX1.ImageTextSpacing = 5;
            this.buttonX1.Location = new System.Drawing.Point(31, 18);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(75, 77);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.Symbol = "";
            this.buttonX1.TabIndex = 0;
            this.buttonX1.Text = "Install";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // sideNavPanel2
            // 
            this.sideNavPanel2.Controls.Add(this.chkPerformBackup);
            this.sideNavPanel2.Controls.Add(this.labelX3);
            this.sideNavPanel2.Controls.Add(this.txtDomain);
            this.sideNavPanel2.Controls.Add(this.lblDomain);
            this.sideNavPanel2.Controls.Add(this.buttonX4);
            this.sideNavPanel2.Controls.Add(this.buttonX3);
            this.sideNavPanel2.Controls.Add(this.checkBoxX2);
            this.sideNavPanel2.Controls.Add(this.checkBoxX1);
            this.sideNavPanel2.Controls.Add(this.txtProxyUrl);
            this.sideNavPanel2.Controls.Add(this.txtProxyPort);
            this.sideNavPanel2.Controls.Add(this.txtProxyUserId);
            this.sideNavPanel2.Controls.Add(this.txtProxyPassword);
            this.sideNavPanel2.Controls.Add(this.lblPassword);
            this.sideNavPanel2.Controls.Add(this.lblUser);
            this.sideNavPanel2.Controls.Add(this.lblPort);
            this.sideNavPanel2.Controls.Add(this.lblUrl);
            this.sideNavPanel2.Controls.Add(this.labelX2);
            this.sideNavPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sideNavPanel2.Location = new System.Drawing.Point(88, 31);
            this.sideNavPanel2.Name = "sideNavPanel2";
            this.sideNavPanel2.Size = new System.Drawing.Size(698, 359);
            this.sideNavPanel2.TabIndex = 6;
            this.sideNavPanel2.Visible = false;
            // 
            // chkPerformBackup
            // 
            this.chkPerformBackup.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.chkPerformBackup.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkPerformBackup.Location = new System.Drawing.Point(37, 262);
            this.chkPerformBackup.Name = "chkPerformBackup";
            this.chkPerformBackup.Size = new System.Drawing.Size(216, 23);
            this.chkPerformBackup.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chkPerformBackup.TabIndex = 15;
            this.chkPerformBackup.Text = "Perform Backup of Game Before Install";
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.FontBold = true;
            this.labelX3.Location = new System.Drawing.Point(11, 233);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(96, 23);
            this.labelX3.TabIndex = 14;
            this.labelX3.Text = "General:";
            // 
            // txtDomain
            // 
            this.txtDomain.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtDomain.Border.Class = "TextBoxBorder";
            this.txtDomain.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDomain.DisabledBackColor = System.Drawing.Color.White;
            this.txtDomain.Enabled = false;
            this.txtDomain.ForeColor = System.Drawing.Color.Black;
            this.txtDomain.Location = new System.Drawing.Point(120, 140);
            this.txtDomain.Name = "txtDomain";
            this.txtDomain.PreventEnterBeep = true;
            this.txtDomain.Size = new System.Drawing.Size(70, 20);
            this.txtDomain.TabIndex = 4;
            // 
            // lblDomain
            // 
            this.lblDomain.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblDomain.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblDomain.Enabled = false;
            this.lblDomain.Location = new System.Drawing.Point(60, 137);
            this.lblDomain.Name = "lblDomain";
            this.lblDomain.Size = new System.Drawing.Size(54, 23);
            this.lblDomain.TabIndex = 13;
            this.lblDomain.Text = "Domain:";
            // 
            // buttonX4
            // 
            this.buttonX4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX4.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX4.Location = new System.Drawing.Point(244, 195);
            this.buttonX4.Name = "buttonX4";
            this.buttonX4.Size = new System.Drawing.Size(26, 20);
            this.buttonX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX4.Symbol = "";
            this.buttonX4.SymbolSize = 12F;
            this.buttonX4.TabIndex = 12;
            this.buttonX4.Tooltip = "Show Password";
            this.buttonX4.Click += new System.EventHandler(this.buttonX4_Click);
            // 
            // buttonX3
            // 
            this.buttonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX3.Location = new System.Drawing.Point(11, 325);
            this.buttonX3.Name = "buttonX3";
            this.buttonX3.Size = new System.Drawing.Size(75, 23);
            this.buttonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX3.Symbol = "";
            this.buttonX3.SymbolSize = 12F;
            this.buttonX3.TabIndex = 11;
            this.buttonX3.Text = "Save";
            this.buttonX3.Click += new System.EventHandler(this.buttonX3_Click);
            // 
            // checkBoxX2
            // 
            this.checkBoxX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.checkBoxX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.checkBoxX2.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.checkBoxX2.Location = new System.Drawing.Point(37, 57);
            this.checkBoxX2.Name = "checkBoxX2";
            this.checkBoxX2.Size = new System.Drawing.Size(100, 23);
            this.checkBoxX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.checkBoxX2.TabIndex = 1;
            this.checkBoxX2.Text = "Manual Proxy:";
            this.checkBoxX2.CheckedChanged += new System.EventHandler(this.checkBoxX2_CheckedChanged_1);
            // 
            // checkBoxX1
            // 
            this.checkBoxX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.checkBoxX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.checkBoxX1.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.checkBoxX1.Checked = true;
            this.checkBoxX1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxX1.CheckValue = "Y";
            this.checkBoxX1.Location = new System.Drawing.Point(37, 37);
            this.checkBoxX1.Name = "checkBoxX1";
            this.checkBoxX1.Size = new System.Drawing.Size(100, 23);
            this.checkBoxX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.checkBoxX1.TabIndex = 0;
            this.checkBoxX1.Text = "No Proxy";
            // 
            // txtProxyUrl
            // 
            this.txtProxyUrl.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtProxyUrl.Border.Class = "TextBoxBorder";
            this.txtProxyUrl.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtProxyUrl.DisabledBackColor = System.Drawing.Color.White;
            this.txtProxyUrl.Enabled = false;
            this.txtProxyUrl.ForeColor = System.Drawing.Color.Black;
            this.txtProxyUrl.Location = new System.Drawing.Point(120, 86);
            this.txtProxyUrl.Name = "txtProxyUrl";
            this.txtProxyUrl.PreventEnterBeep = true;
            this.txtProxyUrl.Size = new System.Drawing.Size(218, 20);
            this.txtProxyUrl.TabIndex = 2;
            // 
            // txtProxyPort
            // 
            this.txtProxyPort.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtProxyPort.Border.Class = "TextBoxBorder";
            this.txtProxyPort.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtProxyPort.DisabledBackColor = System.Drawing.Color.White;
            this.txtProxyPort.Enabled = false;
            this.txtProxyPort.ForeColor = System.Drawing.Color.Black;
            this.txtProxyPort.Location = new System.Drawing.Point(120, 114);
            this.txtProxyPort.Name = "txtProxyPort";
            this.txtProxyPort.PreventEnterBeep = true;
            this.txtProxyPort.Size = new System.Drawing.Size(70, 20);
            this.txtProxyPort.TabIndex = 3;
            // 
            // txtProxyUserId
            // 
            this.txtProxyUserId.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtProxyUserId.Border.Class = "TextBoxBorder";
            this.txtProxyUserId.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtProxyUserId.DisabledBackColor = System.Drawing.Color.White;
            this.txtProxyUserId.Enabled = false;
            this.txtProxyUserId.ForeColor = System.Drawing.Color.Black;
            this.txtProxyUserId.Location = new System.Drawing.Point(120, 166);
            this.txtProxyUserId.Name = "txtProxyUserId";
            this.txtProxyUserId.PreventEnterBeep = true;
            this.txtProxyUserId.Size = new System.Drawing.Size(118, 20);
            this.txtProxyUserId.TabIndex = 5;
            // 
            // txtProxyPassword
            // 
            this.txtProxyPassword.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtProxyPassword.Border.Class = "TextBoxBorder";
            this.txtProxyPassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtProxyPassword.DisabledBackColor = System.Drawing.Color.White;
            this.txtProxyPassword.Enabled = false;
            this.txtProxyPassword.ForeColor = System.Drawing.Color.Black;
            this.txtProxyPassword.Location = new System.Drawing.Point(120, 195);
            this.txtProxyPassword.Name = "txtProxyPassword";
            this.txtProxyPassword.PreventEnterBeep = true;
            this.txtProxyPassword.Size = new System.Drawing.Size(118, 20);
            this.txtProxyPassword.TabIndex = 6;
            this.txtProxyPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblPassword.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblPassword.Enabled = false;
            this.lblPassword.Location = new System.Drawing.Point(60, 192);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(54, 23);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Password:";
            // 
            // lblUser
            // 
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblUser.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblUser.Enabled = false;
            this.lblUser.Location = new System.Drawing.Point(60, 163);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(54, 23);
            this.lblUser.TabIndex = 3;
            this.lblUser.Text = "UserId:";
            // 
            // lblPort
            // 
            this.lblPort.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblPort.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblPort.Enabled = false;
            this.lblPort.Location = new System.Drawing.Point(60, 111);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(54, 23);
            this.lblPort.TabIndex = 2;
            this.lblPort.Text = "Port:";
            // 
            // lblUrl
            // 
            this.lblUrl.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblUrl.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblUrl.Enabled = false;
            this.lblUrl.Location = new System.Drawing.Point(60, 83);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(42, 23);
            this.lblUrl.TabIndex = 1;
            this.lblUrl.Text = "Url:";
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.FontBold = true;
            this.labelX2.Location = new System.Drawing.Point(11, 15);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(96, 23);
            this.labelX2.TabIndex = 0;
            this.labelX2.Text = "Proxy Information:";
            // 
            // sideNavItem1
            // 
            this.sideNavItem1.IsSystemMenu = true;
            this.sideNavItem1.Name = "sideNavItem1";
            this.sideNavItem1.Symbol = "";
            this.sideNavItem1.Text = "Menu";
            // 
            // separator1
            // 
            this.separator1.FixedSize = new System.Drawing.Size(3, 1);
            this.separator1.Name = "separator1";
            this.separator1.Padding.Bottom = 2;
            this.separator1.Padding.Left = 6;
            this.separator1.Padding.Right = 6;
            this.separator1.Padding.Top = 2;
            this.separator1.SeparatorOrientation = DevComponents.DotNetBar.eDesignMarkerOrientation.Vertical;
            // 
            // sideNavItem2
            // 
            this.sideNavItem2.Checked = true;
            this.sideNavItem2.Name = "sideNavItem2";
            this.sideNavItem2.Panel = this.sideNavPanel1;
            this.sideNavItem2.Symbol = "";
            this.sideNavItem2.Text = "Home";
            // 
            // sideNavItem3
            // 
            this.sideNavItem3.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far;
            this.sideNavItem3.Name = "sideNavItem3";
            this.sideNavItem3.Panel = this.sideNavPanel2;
            this.sideNavItem3.Symbol = "";
            this.sideNavItem3.Text = "Settings";
            this.sideNavItem3.Click += new System.EventHandler(this.sideNavItem3_Click);
            // 
            // frmMain
            // 
            this.ClientSize = new System.Drawing.Size(791, 391);
            this.Controls.Add(this.sideNav1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "OpenXcom Updater";
            this.sideNav1.ResumeLayout(false);
            this.sideNav1.PerformLayout();
            this.sideNavPanel1.ResumeLayout(false);
            this.panelEx1.ResumeLayout(false);
            this.panelEx2.ResumeLayout(false);
            this.sideNavPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.Controls.SideNav sideNav1;
        private DevComponents.DotNetBar.Controls.SideNavPanel sideNavPanel1;
        private DevComponents.DotNetBar.PanelEx panelEx2;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.Controls.SideNavPanel sideNavPanel2;
        private DevComponents.DotNetBar.Controls.SideNavItem sideNavItem1;
        private DevComponents.DotNetBar.Separator separator1;
        private DevComponents.DotNetBar.Controls.SideNavItem sideNavItem2;
        private DevComponents.DotNetBar.Controls.SideNavItem sideNavItem3;
        private DevComponents.DotNetBar.ButtonX buttonX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.ListView listView1;
        private DevComponents.DotNetBar.Controls.ProgressBarX progressBarX1;
        private DevComponents.DotNetBar.LabelX lblUrl;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtProxyUrl;
        private DevComponents.DotNetBar.Controls.TextBoxX txtProxyPort;
        private DevComponents.DotNetBar.Controls.TextBoxX txtProxyUserId;
        private DevComponents.DotNetBar.Controls.TextBoxX txtProxyPassword;
        private DevComponents.DotNetBar.LabelX lblPassword;
        private DevComponents.DotNetBar.LabelX lblUser;
        private DevComponents.DotNetBar.LabelX lblPort;
        private DevComponents.DotNetBar.Controls.CheckBoxX checkBoxX2;
        private DevComponents.DotNetBar.Controls.CheckBoxX checkBoxX1;
        private DevComponents.DotNetBar.ButtonX buttonX3;
        private DevComponents.DotNetBar.ButtonX buttonX4;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDomain;
        private DevComponents.DotNetBar.LabelX lblDomain;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkPerformBackup;
        private DevComponents.DotNetBar.LabelX labelX3;
    }
}