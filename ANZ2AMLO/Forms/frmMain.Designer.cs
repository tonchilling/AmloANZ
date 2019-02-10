namespace ANZ2AMLO.Forms
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
            DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::ANZ2AMLO.Forms.frmSplashScreen), false, false);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barLinkContainerItem1 = new DevExpress.XtraBars.BarLinkContainerItem();
            this.barButtonLogOff = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonExit = new DevExpress.XtraBars.BarButtonItem();
            this.barMdiChildrenListItem1 = new DevExpress.XtraBars.BarMdiChildrenListItem();
            this.skinBarSubItem1 = new DevExpress.XtraBars.SkinBarSubItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barStaticUser = new DevExpress.XtraBars.BarStaticItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.navBarControlMain = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarAuthorize = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarUserGroup = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarUser = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarMenuGroup = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarSubMenu = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarMenuPermission = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItemUserProfile = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navImportAll = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup3 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarCustomerMaster = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarTransactionMaster = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup2 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarGenAutoAMLO = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup4 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navSourceFileConfig = new DevExpress.XtraNavBar.NavBarItem();
            this.navSourceFileMapping = new DevExpress.XtraNavBar.NavBarItem();
            this.navCutomerMasterMapping = new DevExpress.XtraNavBar.NavBarItem();
            this.navTransactionMasterMapping = new DevExpress.XtraNavBar.NavBarItem();
            this.navReportMapping = new DevExpress.XtraNavBar.NavBarItem();
            this.navReportFilterRole = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem3 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem4 = new DevExpress.XtraNavBar.NavBarItem();
            this.pnLogin = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCancelLogin = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControlMain)).BeginInit();
            this.pnLogin.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // splashScreenManager1
            // 
            splashScreenManager1.ClosingDelay = 5000;
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barLinkContainerItem1,
            this.barButtonLogOff,
            this.barButtonItem2,
            this.barButtonExit,
            this.barStaticUser,
            this.barMdiChildrenListItem1,
            this.skinBarSubItem1});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 7;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barLinkContainerItem1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barMdiChildrenListItem1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.skinBarSubItem1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.AllowQuickCustomization = false;
            this.bar2.OptionsBar.DrawBorder = false;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barLinkContainerItem1
            // 
            this.barLinkContainerItem1.Caption = "Menu";
            this.barLinkContainerItem1.Id = 0;
            this.barLinkContainerItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barLinkContainerItem1.ImageOptions.Image")));
            this.barLinkContainerItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barLinkContainerItem1.ImageOptions.LargeImage")));
            this.barLinkContainerItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonLogOff, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem2, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonExit, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.barLinkContainerItem1.Name = "barLinkContainerItem1";
            // 
            // barButtonLogOff
            // 
            this.barButtonLogOff.Caption = "Logoff";
            this.barButtonLogOff.Id = 1;
            this.barButtonLogOff.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonLogOff.ImageOptions.Image")));
            this.barButtonLogOff.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonLogOff.ImageOptions.LargeImage")));
            this.barButtonLogOff.Name = "barButtonLogOff";
            this.barButtonLogOff.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonLogOff_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "System Config";
            this.barButtonItem2.Id = 2;
            this.barButtonItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.barButtonItem2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage")));
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonExit
            // 
            this.barButtonExit.Caption = "Exit";
            this.barButtonExit.Id = 3;
            this.barButtonExit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonExit.ImageOptions.Image")));
            this.barButtonExit.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonExit.ImageOptions.LargeImage")));
            this.barButtonExit.Name = "barButtonExit";
            this.barButtonExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonExit_ItemClick);
            // 
            // barMdiChildrenListItem1
            // 
            this.barMdiChildrenListItem1.Caption = "Active Form";
            this.barMdiChildrenListItem1.Id = 5;
            this.barMdiChildrenListItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barMdiChildrenListItem1.ImageOptions.Image")));
            this.barMdiChildrenListItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barMdiChildrenListItem1.ImageOptions.LargeImage")));
            this.barMdiChildrenListItem1.Name = "barMdiChildrenListItem1";
            // 
            // skinBarSubItem1
            // 
            this.skinBarSubItem1.Caption = "Theme";
            this.skinBarSubItem1.Id = 6;
            this.skinBarSubItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("skinBarSubItem1.ImageOptions.Image")));
            this.skinBarSubItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("skinBarSubItem1.ImageOptions.LargeImage")));
            this.skinBarSubItem1.Name = "skinBarSubItem1";
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticUser)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barStaticUser
            // 
            this.barStaticUser.Caption = "User : xxxx";
            this.barStaticUser.Id = 4;
            this.barStaticUser.Name = "barStaticUser";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(975, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 644);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(975, 38);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 620);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(975, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 620);
            // 
            // navBarControlMain
            // 
            this.navBarControlMain.ActiveGroup = this.navBarAuthorize;
            this.navBarControlMain.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.navBarControlMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.navBarControlMain.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1,
            this.navBarGroup3,
            this.navBarGroup2,
            this.navBarGroup4,
            this.navBarAuthorize});
            this.navBarControlMain.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navImportAll,
            this.navBarItem3,
            this.navBarItem4,
            this.navBarCustomerMaster,
            this.navSourceFileConfig,
            this.navBarTransactionMaster,
            this.navSourceFileMapping,
            this.navCutomerMasterMapping,
            this.navTransactionMasterMapping,
            this.navReportMapping,
            this.navReportFilterRole,
            this.navBarGenAutoAMLO,
            this.navBarUserGroup,
            this.navBarUser,
            this.navBarMenuGroup,
            this.navBarSubMenu,
            this.navBarMenuPermission,
            this.navBarItemUserProfile});
            this.navBarControlMain.Location = new System.Drawing.Point(0, 24);
            this.navBarControlMain.Name = "navBarControlMain";
            this.navBarControlMain.OptionsNavPane.ExpandedWidth = 214;
            this.navBarControlMain.Size = new System.Drawing.Size(214, 620);
            this.navBarControlMain.TabIndex = 5;
            this.navBarControlMain.Text = "navBarControl1";
            this.navBarControlMain.View = new DevExpress.XtraNavBar.ViewInfo.SkinNavigationPaneViewInfoRegistrator();
            // 
            // navBarAuthorize
            // 
            this.navBarAuthorize.Caption = "Authorize";
            this.navBarAuthorize.Expanded = true;
            this.navBarAuthorize.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.LargeIconsList;
            this.navBarAuthorize.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarUserGroup),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarUser),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarMenuGroup),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarSubMenu),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarMenuPermission),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemUserProfile)});
            this.navBarAuthorize.Name = "navBarAuthorize";
            // 
            // navBarUserGroup
            // 
            this.navBarUserGroup.Caption = "User Group";
            this.navBarUserGroup.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarUserGroup.ImageOptions.LargeImage")));
            this.navBarUserGroup.Name = "navBarUserGroup";
            this.navBarUserGroup.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem1_LinkClicked_1);
            // 
            // navBarUser
            // 
            this.navBarUser.Caption = "Users";
            this.navBarUser.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarUser.ImageOptions.LargeImage")));
            this.navBarUser.Name = "navBarUser";
            this.navBarUser.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarUser_LinkClicked);
            // 
            // navBarMenuGroup
            // 
            this.navBarMenuGroup.Caption = "Menu Group";
            this.navBarMenuGroup.Name = "navBarMenuGroup";
            this.navBarMenuGroup.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarMenuGroup_LinkClicked);
            // 
            // navBarSubMenu
            // 
            this.navBarSubMenu.Caption = "Sub Menu";
            this.navBarSubMenu.Name = "navBarSubMenu";
            this.navBarSubMenu.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarSubMenu_LinkClicked);
            // 
            // navBarMenuPermission
            // 
            this.navBarMenuPermission.Caption = "Menu Permission";
            this.navBarMenuPermission.Name = "navBarMenuPermission";
            this.navBarMenuPermission.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarMenuPermission_LinkClicked);
            // 
            // navBarItemUserProfile
            // 
            this.navBarItemUserProfile.Caption = "User Profile";
            this.navBarItemUserProfile.Name = "navBarItemUserProfile";
            this.navBarItemUserProfile.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItemUserProfile_LinkClicked);
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "Import File";
            this.navBarGroup1.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.LargeIconsText;
            this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navImportAll)});
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // navImportAll
            // 
            this.navImportAll.Caption = "Import All";
            this.navImportAll.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("navImportAll.ImageOptions.LargeImage")));
            this.navImportAll.Name = "navImportAll";
            this.navImportAll.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navImportAll_LinkClicked);
            // 
            // navBarGroup3
            // 
            this.navBarGroup3.Caption = "Generate Master";
            this.navBarGroup3.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.LargeIconsText;
            this.navBarGroup3.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarCustomerMaster),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarTransactionMaster)});
            this.navBarGroup3.Name = "navBarGroup3";
            // 
            // navBarCustomerMaster
            // 
            this.navBarCustomerMaster.Caption = "Customer Master";
            this.navBarCustomerMaster.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarCustomerMaster.ImageOptions.LargeImage")));
            this.navBarCustomerMaster.Name = "navBarCustomerMaster";
            this.navBarCustomerMaster.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarCustomerMaster_LinkClicked);
            // 
            // navBarTransactionMaster
            // 
            this.navBarTransactionMaster.Caption = "Transection Master";
            this.navBarTransactionMaster.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarTransactionMaster.ImageOptions.LargeImage")));
            this.navBarTransactionMaster.Name = "navBarTransactionMaster";
            this.navBarTransactionMaster.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarTransactionMaster_LinkClicked);
            // 
            // navBarGroup2
            // 
            this.navBarGroup2.Caption = "Generate AMLO";
            this.navBarGroup2.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.LargeIconsList;
            this.navBarGroup2.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarGenAutoAMLO)});
            this.navBarGroup2.Name = "navBarGroup2";
            // 
            // navBarGenAutoAMLO
            // 
            this.navBarGenAutoAMLO.Caption = "Generate Auto AMLO";
            this.navBarGenAutoAMLO.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarGenAutoAMLO.ImageOptions.LargeImage")));
            this.navBarGenAutoAMLO.Name = "navBarGenAutoAMLO";
            this.navBarGenAutoAMLO.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarGenAutoAMLO_LinkClicked);
            // 
            // navBarGroup4
            // 
            this.navBarGroup4.Caption = "Setting";
            this.navBarGroup4.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.LargeIconsText;
            this.navBarGroup4.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navSourceFileConfig),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navSourceFileMapping),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navCutomerMasterMapping),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navTransactionMasterMapping),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navReportMapping),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navReportFilterRole)});
            this.navBarGroup4.Name = "navBarGroup4";
            // 
            // navSourceFileConfig
            // 
            this.navSourceFileConfig.Caption = "Source File Config";
            this.navSourceFileConfig.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("navSourceFileConfig.ImageOptions.LargeImage")));
            this.navSourceFileConfig.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navSourceFileConfig.ImageOptions.SmallImage")));
            this.navSourceFileConfig.Name = "navSourceFileConfig";
            this.navSourceFileConfig.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navSettingCustomerSebel_LinkClicked);
            // 
            // navSourceFileMapping
            // 
            this.navSourceFileMapping.Caption = "Source File Mapping";
            this.navSourceFileMapping.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("navSourceFileMapping.ImageOptions.LargeImage")));
            this.navSourceFileMapping.Name = "navSourceFileMapping";
            this.navSourceFileMapping.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navSourceFileMapping_LinkClicked);
            // 
            // navCutomerMasterMapping
            // 
            this.navCutomerMasterMapping.Caption = "Customer Master Mapping";
            this.navCutomerMasterMapping.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("navCutomerMasterMapping.ImageOptions.LargeImage")));
            this.navCutomerMasterMapping.Name = "navCutomerMasterMapping";
            this.navCutomerMasterMapping.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navCutomerMasterMapping_LinkClicked);
            // 
            // navTransactionMasterMapping
            // 
            this.navTransactionMasterMapping.Caption = "Transaction Master Mapping";
            this.navTransactionMasterMapping.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("navTransactionMasterMapping.ImageOptions.LargeImage")));
            this.navTransactionMasterMapping.Name = "navTransactionMasterMapping";
            this.navTransactionMasterMapping.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navTransactionMasterMapping_LinkClicked);
            // 
            // navReportMapping
            // 
            this.navReportMapping.Caption = "Report Mapping";
            this.navReportMapping.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("navReportMapping.ImageOptions.LargeImage")));
            this.navReportMapping.Name = "navReportMapping";
            this.navReportMapping.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navReportMapping_LinkClicked);
            // 
            // navReportFilterRole
            // 
            this.navReportFilterRole.Caption = "Report Filter Rule";
            this.navReportFilterRole.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("navReportFilterRole.ImageOptions.LargeImage")));
            this.navReportFilterRole.Name = "navReportFilterRole";
            this.navReportFilterRole.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navReportFilterRole_LinkClicked);
            // 
            // navBarItem3
            // 
            this.navBarItem3.Caption = "Validate";
            this.navBarItem3.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItem3.ImageOptions.SmallImage")));
            this.navBarItem3.Name = "navBarItem3";
            // 
            // navBarItem4
            // 
            this.navBarItem4.Caption = "Export";
            this.navBarItem4.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItem4.ImageOptions.SmallImage")));
            this.navBarItem4.Name = "navBarItem4";
            // 
            // pnLogin
            // 
            this.pnLogin.BackColor = System.Drawing.SystemColors.Menu;
            this.pnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnLogin.Controls.Add(this.pictureEdit2);
            this.pnLogin.Controls.Add(this.groupBox2);
            this.pnLogin.Location = new System.Drawing.Point(342, 131);
            this.pnLogin.Margin = new System.Windows.Forms.Padding(2);
            this.pnLogin.Name = "pnLogin";
            this.pnLogin.Size = new System.Drawing.Size(497, 324);
            this.pnLogin.TabIndex = 23;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCancelLogin);
            this.groupBox2.Controls.Add(this.btnLogin);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtPassword);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtUserName);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(24, 161);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(442, 141);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Login";
            // 
            // btnCancelLogin
            // 
            this.btnCancelLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelLogin.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelLogin.Location = new System.Drawing.Point(266, 101);
            this.btnCancelLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelLogin.Name = "btnCancelLogin";
            this.btnCancelLogin.Size = new System.Drawing.Size(132, 29);
            this.btnCancelLogin.TabIndex = 37;
            this.btnCancelLogin.Text = "CANCEL";
            this.btnCancelLogin.UseVisualStyleBackColor = true;
            this.btnCancelLogin.Click += new System.EventHandler(this.btnCancelLogin_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogin.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(139, 101);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(123, 29);
            this.btnLogin.TabIndex = 36;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 18);
            this.label2.TabIndex = 35;
            this.label2.Text = "PASSWORD";
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Location = new System.Drawing.Point(140, 65);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(258, 30);
            this.txtPassword.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 18);
            this.label1.TabIndex = 33;
            this.label1.Text = "USER NAME";
            // 
            // txtUserName
            // 
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserName.Location = new System.Drawing.Point(140, 29);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(2);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(258, 30);
            this.txtUserName.TabIndex = 32;
            // 
            // pictureEdit2
            // 
            this.pictureEdit2.EditValue = ((object)(resources.GetObject("pictureEdit2.EditValue")));
            this.pictureEdit2.Location = new System.Drawing.Point(29, 16);
            this.pictureEdit2.Name = "pictureEdit2";
            this.pictureEdit2.Properties.AllowFocused = false;
            this.pictureEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit2.Properties.ShowMenu = false;
            this.pictureEdit2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit2.Size = new System.Drawing.Size(426, 140);
            this.pictureEdit2.TabIndex = 33;
            // 
            // frmMain
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 682);
            this.Controls.Add(this.pnLogin);
            this.Controls.Add(this.navBarControlMain);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.DoubleBuffered = true;
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ANZ AMLO";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControlMain)).EndInit();
            this.pnLogin.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraNavBar.NavBarControl navBarControlMain;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarLinkContainerItem barLinkContainerItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonLogOff;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonExit;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraNavBar.NavBarItem navBarItem3;
        private DevExpress.XtraNavBar.NavBarItem navBarItem4;
        private DevExpress.XtraBars.BarStaticItem barStaticUser;
        private DevExpress.XtraBars.BarMdiChildrenListItem barMdiChildrenListItem1;
        private DevExpress.XtraBars.SkinBarSubItem skinBarSubItem1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup3;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup4;
        private DevExpress.XtraNavBar.NavBarItem navBarCustomerMaster;
        private DevExpress.XtraNavBar.NavBarItem navSourceFileConfig;
        private DevExpress.XtraNavBar.NavBarItem navImportAll;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup2;
        private DevExpress.XtraNavBar.NavBarGroup navBarAuthorize;
        private DevExpress.XtraNavBar.NavBarItem navSourceFileMapping;
        private DevExpress.XtraNavBar.NavBarItem navBarTransactionMaster;
        private DevExpress.XtraNavBar.NavBarItem navCutomerMasterMapping;
        private DevExpress.XtraNavBar.NavBarItem navTransactionMasterMapping;
        private DevExpress.XtraNavBar.NavBarItem navReportMapping;
        private DevExpress.XtraNavBar.NavBarItem navReportFilterRole;
        private DevExpress.XtraNavBar.NavBarItem navBarGenAutoAMLO;
        private DevExpress.XtraNavBar.NavBarItem navBarUserGroup;
        private DevExpress.XtraNavBar.NavBarItem navBarUser;
        private System.Windows.Forms.Panel pnLogin;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCancelLogin;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUserName;
        private DevExpress.XtraNavBar.NavBarItem navBarMenuGroup;
        private DevExpress.XtraNavBar.NavBarItem navBarSubMenu;
        private DevExpress.XtraNavBar.NavBarItem navBarMenuPermission;
        private DevExpress.XtraNavBar.NavBarItem navBarItemUserProfile;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
    }
}