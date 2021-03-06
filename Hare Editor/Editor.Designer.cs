﻿namespace HareEditor {
    partial class Editor {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editor));
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.FileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.NewSceneMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenSceneMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveSceneMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveASSceneMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.BuildSettingsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.BuildRunMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.playToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.projectSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.physicsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cScriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showInExplorerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripSeparator();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripSeparator();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameObjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createEmptyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dObjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sphereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cubeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dObjectToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.spriteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.audioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cameraToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.themeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lightToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.darkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hybridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showConsoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sceneCameraPropertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HierarchyMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CopyMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.PasteMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripSeparator();
            this.DuplicateMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripSeparator();
            this.CreateEmptyMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.TObjectMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.SphereMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.CubeMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.TwObjectMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.SpriteMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.LightMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.AudioMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.CameraMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.lblLastLog = new System.Windows.Forms.Label();
            this.wrapperPanel = new HareEditor.DBPanel();
            this.renderPanel = new HareEditor.DBPanel();
            this.gameViewPanel = new HareEditor.DBPanel();
            this.Sceneview = new HareEditor.Sceneview();
            this.lblScene = new System.Windows.Forms.Label();
            this.dataPanel = new HareEditor.DBPanel();
            this.assetsPanel = new HareEditor.DBPanel();
            this.Assets = new HareEditor.Assets();
            this.lblAssets = new System.Windows.Forms.Label();
            this.hierarchyPanel = new HareEditor.DBPanel();
            this.Hierarchy = new HareEditor.Hierarchy();
            this.lblHierarchy = new System.Windows.Forms.Label();
            this.inspectorPanel = new HareEditor.DBPanel();
            this.Inspector = new HareEditor.Inspector();
            this.bntAddComponent = new System.Windows.Forms.Button();
            this.lblInspector = new System.Windows.Forms.Label();
            this.Appbar = new HareEditor.DBPanel();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.PauseButton = new System.Windows.Forms.Button();
            this.PlayButton = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.ScaleButton = new System.Windows.Forms.Button();
            this.RotateButton = new System.Windows.Forms.Button();
            this.MoveBoutton = new System.Windows.Forms.Button();
            this.GrabButton = new System.Windows.Forms.Button();
            this.MenuStrip.SuspendLayout();
            this.HierarchyMenu.SuspendLayout();
            this.wrapperPanel.SuspendLayout();
            this.renderPanel.SuspendLayout();
            this.gameViewPanel.SuspendLayout();
            this.dataPanel.SuspendLayout();
            this.assetsPanel.SuspendLayout();
            this.hierarchyPanel.SuspendLayout();
            this.inspectorPanel.SuspendLayout();
            this.Appbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenu,
            this.editToolStripMenuItem,
            this.assetsToolStripMenuItem,
            this.gameObjectToolStripMenuItem,
            this.windowToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(784, 24);
            this.MenuStrip.TabIndex = 1;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // FileMenu
            // 
            this.FileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewSceneMenu,
            this.OpenSceneMenu,
            this.SaveSceneMenu,
            this.SaveASSceneMenu,
            this.toolStripMenuItem1,
            this.BuildSettingsMenu,
            this.BuildRunMenu,
            this.toolStripMenuItem2,
            this.exitToolStripMenuItem});
            this.FileMenu.Name = "FileMenu";
            this.FileMenu.Size = new System.Drawing.Size(37, 20);
            this.FileMenu.Text = "File";
            // 
            // NewSceneMenu
            // 
            this.NewSceneMenu.Name = "NewSceneMenu";
            this.NewSceneMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.NewSceneMenu.Size = new System.Drawing.Size(234, 22);
            this.NewSceneMenu.Text = "New Scene";
            this.NewSceneMenu.Click += new System.EventHandler(this.NewSceneMenu_Click);
            // 
            // OpenSceneMenu
            // 
            this.OpenSceneMenu.Name = "OpenSceneMenu";
            this.OpenSceneMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.OpenSceneMenu.Size = new System.Drawing.Size(234, 22);
            this.OpenSceneMenu.Text = "Open Scene";
            this.OpenSceneMenu.Click += new System.EventHandler(this.OpenSceneMenu_Click);
            // 
            // SaveSceneMenu
            // 
            this.SaveSceneMenu.Name = "SaveSceneMenu";
            this.SaveSceneMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SaveSceneMenu.Size = new System.Drawing.Size(234, 22);
            this.SaveSceneMenu.Text = "Save Scene";
            this.SaveSceneMenu.Click += new System.EventHandler(this.SaveSceneMenu_Click);
            // 
            // SaveASSceneMenu
            // 
            this.SaveASSceneMenu.Name = "SaveASSceneMenu";
            this.SaveASSceneMenu.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.SaveASSceneMenu.Size = new System.Drawing.Size(234, 22);
            this.SaveASSceneMenu.Text = "Save Scene As";
            this.SaveASSceneMenu.Click += new System.EventHandler(this.SaveASSceneMenu_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(231, 6);
            // 
            // BuildSettingsMenu
            // 
            this.BuildSettingsMenu.Name = "BuildSettingsMenu";
            this.BuildSettingsMenu.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.B)));
            this.BuildSettingsMenu.Size = new System.Drawing.Size(234, 22);
            this.BuildSettingsMenu.Text = "Build Settings";
            // 
            // BuildRunMenu
            // 
            this.BuildRunMenu.Name = "BuildRunMenu";
            this.BuildRunMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.BuildRunMenu.Size = new System.Drawing.Size(234, 22);
            this.BuildRunMenu.Text = "Build && Run";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(231, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.exitToolStripMenuItem.Text = "Close Project";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripMenuItem3,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripMenuItem4,
            this.preferencesToolStripMenuItem,
            this.toolStripMenuItem5,
            this.playToolStripMenuItem,
            this.pauseToolStripMenuItem,
            this.toolStripMenuItem6,
            this.projectSettingsToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.redoToolStripMenuItem.Text = "Redo";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(189, 6);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(189, 6);
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.preferencesToolStripMenuItem.Text = "Preferences";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(189, 6);
            // 
            // playToolStripMenuItem
            // 
            this.playToolStripMenuItem.Name = "playToolStripMenuItem";
            this.playToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.playToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.playToolStripMenuItem.Text = "Play";
            // 
            // pauseToolStripMenuItem
            // 
            this.pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
            this.pauseToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.P)));
            this.pauseToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.pauseToolStripMenuItem.Text = "Pause";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(189, 6);
            // 
            // projectSettingsToolStripMenuItem
            // 
            this.projectSettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.physicsToolStripMenuItem});
            this.projectSettingsToolStripMenuItem.Name = "projectSettingsToolStripMenuItem";
            this.projectSettingsToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.projectSettingsToolStripMenuItem.Text = "Project Settings";
            // 
            // physicsToolStripMenuItem
            // 
            this.physicsToolStripMenuItem.Name = "physicsToolStripMenuItem";
            this.physicsToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.physicsToolStripMenuItem.Text = "Physics";
            // 
            // assetsToolStripMenuItem
            // 
            this.assetsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem,
            this.showInExplorerToolStripMenuItem,
            this.toolStripMenuItem7,
            this.importToolStripMenuItem,
            this.toolStripMenuItem8,
            this.refreshToolStripMenuItem});
            this.assetsToolStripMenuItem.Name = "assetsToolStripMenuItem";
            this.assetsToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.assetsToolStripMenuItem.Text = "Assets";
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.folderToolStripMenuItem,
            this.cScriptToolStripMenuItem});
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.createToolStripMenuItem.Text = "Create";
            // 
            // folderToolStripMenuItem
            // 
            this.folderToolStripMenuItem.Name = "folderToolStripMenuItem";
            this.folderToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.folderToolStripMenuItem.Text = "Folder";
            // 
            // cScriptToolStripMenuItem
            // 
            this.cScriptToolStripMenuItem.Name = "cScriptToolStripMenuItem";
            this.cScriptToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.cScriptToolStripMenuItem.Text = "C# Script";
            this.cScriptToolStripMenuItem.Click += new System.EventHandler(this.cScriptToolStripMenuItem_Click);
            // 
            // showInExplorerToolStripMenuItem
            // 
            this.showInExplorerToolStripMenuItem.Name = "showInExplorerToolStripMenuItem";
            this.showInExplorerToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.showInExplorerToolStripMenuItem.Text = "Show in Explorer";
            this.showInExplorerToolStripMenuItem.Click += new System.EventHandler(this.showInExplorerToolStripMenuItem_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(158, 6);
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.importToolStripMenuItem.Text = "Import";
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(158, 6);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.RefreshMenu_Click);
            // 
            // gameObjectToolStripMenuItem
            // 
            this.gameObjectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createEmptyToolStripMenuItem,
            this.dObjectToolStripMenuItem,
            this.dObjectToolStripMenuItem1,
            this.lightToolStripMenuItem,
            this.audioToolStripMenuItem,
            this.cameraToolStripMenuItem1});
            this.gameObjectToolStripMenuItem.Name = "gameObjectToolStripMenuItem";
            this.gameObjectToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.gameObjectToolStripMenuItem.Text = "GameObject";
            // 
            // createEmptyToolStripMenuItem
            // 
            this.createEmptyToolStripMenuItem.Name = "createEmptyToolStripMenuItem";
            this.createEmptyToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.createEmptyToolStripMenuItem.Text = "Create Empty";
            this.createEmptyToolStripMenuItem.Click += new System.EventHandler(this.CreateEmptyMenu_Click);
            // 
            // dObjectToolStripMenuItem
            // 
            this.dObjectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sphereToolStripMenuItem,
            this.cubeToolStripMenuItem});
            this.dObjectToolStripMenuItem.Name = "dObjectToolStripMenuItem";
            this.dObjectToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.dObjectToolStripMenuItem.Text = "3D Object";
            // 
            // sphereToolStripMenuItem
            // 
            this.sphereToolStripMenuItem.Name = "sphereToolStripMenuItem";
            this.sphereToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.sphereToolStripMenuItem.Text = "Sphere";
            // 
            // cubeToolStripMenuItem
            // 
            this.cubeToolStripMenuItem.Name = "cubeToolStripMenuItem";
            this.cubeToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.cubeToolStripMenuItem.Text = "Cube";
            this.cubeToolStripMenuItem.Click += new System.EventHandler(this.CubeMenu_Click);
            // 
            // dObjectToolStripMenuItem1
            // 
            this.dObjectToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.spriteToolStripMenuItem});
            this.dObjectToolStripMenuItem1.Name = "dObjectToolStripMenuItem1";
            this.dObjectToolStripMenuItem1.Size = new System.Drawing.Size(145, 22);
            this.dObjectToolStripMenuItem1.Text = "2D Object";
            // 
            // spriteToolStripMenuItem
            // 
            this.spriteToolStripMenuItem.Name = "spriteToolStripMenuItem";
            this.spriteToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.spriteToolStripMenuItem.Text = "Sprite";
            this.spriteToolStripMenuItem.Click += new System.EventHandler(this.SpriteMenu_Click);
            // 
            // lightToolStripMenuItem
            // 
            this.lightToolStripMenuItem.Name = "lightToolStripMenuItem";
            this.lightToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.lightToolStripMenuItem.Text = "Light";
            // 
            // audioToolStripMenuItem
            // 
            this.audioToolStripMenuItem.Name = "audioToolStripMenuItem";
            this.audioToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.audioToolStripMenuItem.Text = "Audio";
            // 
            // cameraToolStripMenuItem1
            // 
            this.cameraToolStripMenuItem1.Name = "cameraToolStripMenuItem1";
            this.cameraToolStripMenuItem1.Size = new System.Drawing.Size(145, 22);
            this.cameraToolStripMenuItem1.Text = "Camera";
            this.cameraToolStripMenuItem1.Click += new System.EventHandler(this.CameraMenu_Click);
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.themeToolStripMenuItem,
            this.showConsoleToolStripMenuItem,
            this.sceneCameraPropertiesToolStripMenuItem});
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.windowToolStripMenuItem.Text = "Window";
            // 
            // themeToolStripMenuItem
            // 
            this.themeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lightToolStripMenuItem1,
            this.darkToolStripMenuItem,
            this.hybridToolStripMenuItem});
            this.themeToolStripMenuItem.Name = "themeToolStripMenuItem";
            this.themeToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.themeToolStripMenuItem.Text = "Theme";
            // 
            // lightToolStripMenuItem1
            // 
            this.lightToolStripMenuItem1.Name = "lightToolStripMenuItem1";
            this.lightToolStripMenuItem1.Size = new System.Drawing.Size(110, 22);
            this.lightToolStripMenuItem1.Text = "Light";
            this.lightToolStripMenuItem1.Click += new System.EventHandler(this.lightToolStripMenuItem1_Click);
            // 
            // darkToolStripMenuItem
            // 
            this.darkToolStripMenuItem.Name = "darkToolStripMenuItem";
            this.darkToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.darkToolStripMenuItem.Text = "Dark";
            this.darkToolStripMenuItem.Click += new System.EventHandler(this.darkToolStripMenuItem_Click);
            // 
            // hybridToolStripMenuItem
            // 
            this.hybridToolStripMenuItem.Name = "hybridToolStripMenuItem";
            this.hybridToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.hybridToolStripMenuItem.Text = "Hybrid";
            this.hybridToolStripMenuItem.Click += new System.EventHandler(this.hybridToolStripMenuItem_Click);
            // 
            // showConsoleToolStripMenuItem
            // 
            this.showConsoleToolStripMenuItem.Name = "showConsoleToolStripMenuItem";
            this.showConsoleToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.showConsoleToolStripMenuItem.Text = "Show Console";
            this.showConsoleToolStripMenuItem.Click += new System.EventHandler(this.showConsoleToolStripMenuItem_Click);
            // 
            // sceneCameraPropertiesToolStripMenuItem
            // 
            this.sceneCameraPropertiesToolStripMenuItem.Name = "sceneCameraPropertiesToolStripMenuItem";
            this.sceneCameraPropertiesToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.sceneCameraPropertiesToolStripMenuItem.Text = "Scene Camera Properties";
            this.sceneCameraPropertiesToolStripMenuItem.Click += new System.EventHandler(this.sceneCameraPropertiesToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // HierarchyMenu
            // 
            this.HierarchyMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CopyMenu,
            this.PasteMenu,
            this.toolStripMenuItem9,
            this.DuplicateMenu,
            this.DeleteMenu,
            this.toolStripMenuItem10,
            this.CreateEmptyMenu,
            this.TObjectMenu,
            this.TwObjectMenu,
            this.LightMenu,
            this.AudioMenu,
            this.CameraMenu});
            this.HierarchyMenu.Name = "contextMenuStrip1";
            this.HierarchyMenu.Size = new System.Drawing.Size(146, 236);
            // 
            // CopyMenu
            // 
            this.CopyMenu.Name = "CopyMenu";
            this.CopyMenu.Size = new System.Drawing.Size(145, 22);
            this.CopyMenu.Text = "Copy";
            this.CopyMenu.Click += new System.EventHandler(this.CopyMenu_Click);
            // 
            // PasteMenu
            // 
            this.PasteMenu.Name = "PasteMenu";
            this.PasteMenu.Size = new System.Drawing.Size(145, 22);
            this.PasteMenu.Text = "Paste";
            this.PasteMenu.Click += new System.EventHandler(this.PasteMenu_Click);
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(142, 6);
            // 
            // DuplicateMenu
            // 
            this.DuplicateMenu.Name = "DuplicateMenu";
            this.DuplicateMenu.Size = new System.Drawing.Size(145, 22);
            this.DuplicateMenu.Text = "Duplicate";
            this.DuplicateMenu.Click += new System.EventHandler(this.DuplicateMenu_Click);
            // 
            // DeleteMenu
            // 
            this.DeleteMenu.Name = "DeleteMenu";
            this.DeleteMenu.Size = new System.Drawing.Size(145, 22);
            this.DeleteMenu.Text = "Delete";
            this.DeleteMenu.Click += new System.EventHandler(this.DeleteMenu_Click);
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(142, 6);
            // 
            // CreateEmptyMenu
            // 
            this.CreateEmptyMenu.Name = "CreateEmptyMenu";
            this.CreateEmptyMenu.Size = new System.Drawing.Size(145, 22);
            this.CreateEmptyMenu.Text = "Create Empty";
            this.CreateEmptyMenu.Click += new System.EventHandler(this.CreateEmptyMenu_Click);
            // 
            // TObjectMenu
            // 
            this.TObjectMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SphereMenu,
            this.CubeMenu});
            this.TObjectMenu.Name = "TObjectMenu";
            this.TObjectMenu.Size = new System.Drawing.Size(145, 22);
            this.TObjectMenu.Text = "3D Object";
            // 
            // SphereMenu
            // 
            this.SphereMenu.Name = "SphereMenu";
            this.SphereMenu.Size = new System.Drawing.Size(110, 22);
            this.SphereMenu.Text = "Sphere";
            // 
            // CubeMenu
            // 
            this.CubeMenu.Name = "CubeMenu";
            this.CubeMenu.Size = new System.Drawing.Size(110, 22);
            this.CubeMenu.Text = "Cube";
            this.CubeMenu.Click += new System.EventHandler(this.CubeMenu_Click);
            // 
            // TwObjectMenu
            // 
            this.TwObjectMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SpriteMenu});
            this.TwObjectMenu.Name = "TwObjectMenu";
            this.TwObjectMenu.Size = new System.Drawing.Size(145, 22);
            this.TwObjectMenu.Text = "2D Object";
            // 
            // SpriteMenu
            // 
            this.SpriteMenu.Name = "SpriteMenu";
            this.SpriteMenu.Size = new System.Drawing.Size(104, 22);
            this.SpriteMenu.Text = "Sprite";
            this.SpriteMenu.Click += new System.EventHandler(this.SpriteMenu_Click);
            // 
            // LightMenu
            // 
            this.LightMenu.Name = "LightMenu";
            this.LightMenu.Size = new System.Drawing.Size(145, 22);
            this.LightMenu.Text = "Light";
            // 
            // AudioMenu
            // 
            this.AudioMenu.Name = "AudioMenu";
            this.AudioMenu.Size = new System.Drawing.Size(145, 22);
            this.AudioMenu.Text = "Audio";
            // 
            // CameraMenu
            // 
            this.CameraMenu.Name = "CameraMenu";
            this.CameraMenu.Size = new System.Drawing.Size(145, 22);
            this.CameraMenu.Text = "Camera";
            this.CameraMenu.Click += new System.EventHandler(this.CameraMenu_Click);
            // 
            // lblLastLog
            // 
            this.lblLastLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.lblLastLog.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblLastLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblLastLog.Location = new System.Drawing.Point(0, 537);
            this.lblLastLog.Name = "lblLastLog";
            this.lblLastLog.Size = new System.Drawing.Size(784, 24);
            this.lblLastLog.TabIndex = 0;
            this.lblLastLog.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblLastLog.DoubleClick += new System.EventHandler(this.lblLastLog_DoubleClick);
            // 
            // wrapperPanel
            // 
            this.wrapperPanel.BackColor = System.Drawing.Color.Transparent;
            this.wrapperPanel.Controls.Add(this.renderPanel);
            this.wrapperPanel.Controls.Add(this.dataPanel);
            this.wrapperPanel.Controls.Add(this.inspectorPanel);
            this.wrapperPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wrapperPanel.Location = new System.Drawing.Point(0, 80);
            this.wrapperPanel.Name = "wrapperPanel";
            this.wrapperPanel.Size = new System.Drawing.Size(784, 457);
            this.wrapperPanel.TabIndex = 0;
            // 
            // renderPanel
            // 
            this.renderPanel.Controls.Add(this.gameViewPanel);
            this.renderPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.renderPanel.Location = new System.Drawing.Point(200, 0);
            this.renderPanel.Name = "renderPanel";
            this.renderPanel.Size = new System.Drawing.Size(384, 457);
            this.renderPanel.TabIndex = 4;
            // 
            // gameViewPanel
            // 
            this.gameViewPanel.BackColor = System.Drawing.Color.Transparent;
            this.gameViewPanel.Controls.Add(this.Sceneview);
            this.gameViewPanel.Controls.Add(this.lblScene);
            this.gameViewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameViewPanel.Location = new System.Drawing.Point(0, 0);
            this.gameViewPanel.Name = "gameViewPanel";
            this.gameViewPanel.Size = new System.Drawing.Size(384, 457);
            this.gameViewPanel.TabIndex = 0;
            // 
            // Sceneview
            // 
            this.Sceneview.BackColor = System.Drawing.Color.Black;
            this.Sceneview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Sceneview.Location = new System.Drawing.Point(0, 28);
            this.Sceneview.Name = "Sceneview";
            this.Sceneview.Size = new System.Drawing.Size(384, 429);
            this.Sceneview.TabIndex = 4;
            // 
            // lblScene
            // 
            this.lblScene.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblScene.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblScene.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScene.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblScene.Location = new System.Drawing.Point(0, 0);
            this.lblScene.Name = "lblScene";
            this.lblScene.Size = new System.Drawing.Size(384, 28);
            this.lblScene.TabIndex = 2;
            this.lblScene.Text = "Scene";
            this.lblScene.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataPanel
            // 
            this.dataPanel.Controls.Add(this.assetsPanel);
            this.dataPanel.Controls.Add(this.hierarchyPanel);
            this.dataPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataPanel.Location = new System.Drawing.Point(0, 0);
            this.dataPanel.Name = "dataPanel";
            this.dataPanel.Size = new System.Drawing.Size(200, 457);
            this.dataPanel.TabIndex = 2;
            // 
            // assetsPanel
            // 
            this.assetsPanel.BackColor = System.Drawing.Color.Transparent;
            this.assetsPanel.Controls.Add(this.Assets);
            this.assetsPanel.Controls.Add(this.lblAssets);
            this.assetsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.assetsPanel.Location = new System.Drawing.Point(0, 217);
            this.assetsPanel.Name = "assetsPanel";
            this.assetsPanel.Size = new System.Drawing.Size(200, 240);
            this.assetsPanel.TabIndex = 1;
            // 
            // Assets
            // 
            this.Assets.AutoScroll = true;
            this.Assets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Assets.Location = new System.Drawing.Point(0, 28);
            this.Assets.Name = "Assets";
            this.Assets.Size = new System.Drawing.Size(200, 212);
            this.Assets.TabIndex = 2;
            // 
            // lblAssets
            // 
            this.lblAssets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblAssets.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAssets.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssets.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblAssets.Location = new System.Drawing.Point(0, 0);
            this.lblAssets.Name = "lblAssets";
            this.lblAssets.Size = new System.Drawing.Size(200, 28);
            this.lblAssets.TabIndex = 1;
            this.lblAssets.Text = "Assets";
            this.lblAssets.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // hierarchyPanel
            // 
            this.hierarchyPanel.BackColor = System.Drawing.Color.Transparent;
            this.hierarchyPanel.Controls.Add(this.Hierarchy);
            this.hierarchyPanel.Controls.Add(this.lblHierarchy);
            this.hierarchyPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.hierarchyPanel.Location = new System.Drawing.Point(0, 0);
            this.hierarchyPanel.Name = "hierarchyPanel";
            this.hierarchyPanel.Size = new System.Drawing.Size(200, 240);
            this.hierarchyPanel.TabIndex = 0;
            // 
            // Hierarchy
            // 
            this.Hierarchy.AutoScroll = true;
            this.Hierarchy.ContextMenuStrip = this.HierarchyMenu;
            this.Hierarchy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Hierarchy.Location = new System.Drawing.Point(0, 28);
            this.Hierarchy.Name = "Hierarchy";
            this.Hierarchy.Size = new System.Drawing.Size(200, 212);
            this.Hierarchy.TabIndex = 1;
            // 
            // lblHierarchy
            // 
            this.lblHierarchy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblHierarchy.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHierarchy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHierarchy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblHierarchy.Location = new System.Drawing.Point(0, 0);
            this.lblHierarchy.Name = "lblHierarchy";
            this.lblHierarchy.Size = new System.Drawing.Size(200, 28);
            this.lblHierarchy.TabIndex = 0;
            this.lblHierarchy.Text = "Hierarchy";
            this.lblHierarchy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // inspectorPanel
            // 
            this.inspectorPanel.BackColor = System.Drawing.Color.Transparent;
            this.inspectorPanel.Controls.Add(this.Inspector);
            this.inspectorPanel.Controls.Add(this.bntAddComponent);
            this.inspectorPanel.Controls.Add(this.lblInspector);
            this.inspectorPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.inspectorPanel.Location = new System.Drawing.Point(584, 0);
            this.inspectorPanel.Name = "inspectorPanel";
            this.inspectorPanel.Size = new System.Drawing.Size(200, 457);
            this.inspectorPanel.TabIndex = 3;
            // 
            // Inspector
            // 
            this.Inspector.AutoScroll = true;
            this.Inspector.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Inspector.Location = new System.Drawing.Point(0, 28);
            this.Inspector.Name = "Inspector";
            this.Inspector.Size = new System.Drawing.Size(200, 397);
            this.Inspector.TabIndex = 5;
            // 
            // bntAddComponent
            // 
            this.bntAddComponent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bntAddComponent.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bntAddComponent.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.bntAddComponent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntAddComponent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.bntAddComponent.Location = new System.Drawing.Point(0, 425);
            this.bntAddComponent.Name = "bntAddComponent";
            this.bntAddComponent.Size = new System.Drawing.Size(200, 32);
            this.bntAddComponent.TabIndex = 0;
            this.bntAddComponent.Text = "Add Behaviour";
            this.bntAddComponent.UseVisualStyleBackColor = false;
            this.bntAddComponent.Click += new System.EventHandler(this.bntAddComponent_Click);
            // 
            // lblInspector
            // 
            this.lblInspector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblInspector.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblInspector.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInspector.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblInspector.Location = new System.Drawing.Point(0, 0);
            this.lblInspector.Name = "lblInspector";
            this.lblInspector.Size = new System.Drawing.Size(200, 28);
            this.lblInspector.TabIndex = 4;
            this.lblInspector.Text = "Inspector";
            this.lblInspector.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Appbar
            // 
            this.Appbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.Appbar.Controls.Add(this.pbxLogo);
            this.Appbar.Controls.Add(this.PauseButton);
            this.Appbar.Controls.Add(this.PlayButton);
            this.Appbar.Controls.Add(this.button5);
            this.Appbar.Controls.Add(this.ScaleButton);
            this.Appbar.Controls.Add(this.RotateButton);
            this.Appbar.Controls.Add(this.MoveBoutton);
            this.Appbar.Controls.Add(this.GrabButton);
            this.Appbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.Appbar.Location = new System.Drawing.Point(0, 24);
            this.Appbar.Name = "Appbar";
            this.Appbar.Size = new System.Drawing.Size(784, 56);
            this.Appbar.TabIndex = 0;
            // 
            // pbxLogo
            // 
            this.pbxLogo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxLogo.Image = global::HareEditor.Properties.Resources.Hare_Editor_Logo;
            this.pbxLogo.Location = new System.Drawing.Point(736, 8);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(40, 40);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLogo.TabIndex = 7;
            this.pbxLogo.TabStop = false;
            // 
            // PauseButton
            // 
            this.PauseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.PauseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.PauseButton.BackgroundImage = global::HareEditor.Properties.Resources.pause;
            this.PauseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PauseButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            this.PauseButton.FlatAppearance.BorderSize = 2;
            this.PauseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PauseButton.Location = new System.Drawing.Point(392, 8);
            this.PauseButton.Margin = new System.Windows.Forms.Padding(0);
            this.PauseButton.Name = "PauseButton";
            this.PauseButton.Size = new System.Drawing.Size(40, 40);
            this.PauseButton.TabIndex = 6;
            this.PauseButton.UseVisualStyleBackColor = false;
            this.PauseButton.Click += new System.EventHandler(this.PauseButton_Click);
            // 
            // PlayButton
            // 
            this.PlayButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.PlayButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.PlayButton.BackgroundImage = global::HareEditor.Properties.Resources.play;
            this.PlayButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PlayButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            this.PlayButton.FlatAppearance.BorderSize = 2;
            this.PlayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayButton.Location = new System.Drawing.Point(352, 8);
            this.PlayButton.Margin = new System.Windows.Forms.Padding(0);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(40, 40);
            this.PlayButton.TabIndex = 5;
            this.PlayButton.UseVisualStyleBackColor = false;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.button5.BackgroundImage = global::HareEditor.Properties.Resources.Transform;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            this.button5.FlatAppearance.BorderSize = 2;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(168, 8);
            this.button5.Margin = new System.Windows.Forms.Padding(0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(40, 40);
            this.button5.TabIndex = 4;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Visible = false;
            // 
            // ScaleButton
            // 
            this.ScaleButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ScaleButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.ScaleButton.BackgroundImage = global::HareEditor.Properties.Resources.resize;
            this.ScaleButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ScaleButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            this.ScaleButton.FlatAppearance.BorderSize = 2;
            this.ScaleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ScaleButton.Location = new System.Drawing.Point(128, 8);
            this.ScaleButton.Margin = new System.Windows.Forms.Padding(0);
            this.ScaleButton.Name = "ScaleButton";
            this.ScaleButton.Size = new System.Drawing.Size(40, 40);
            this.ScaleButton.TabIndex = 3;
            this.ScaleButton.UseVisualStyleBackColor = false;
            this.ScaleButton.Visible = false;
            // 
            // RotateButton
            // 
            this.RotateButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.RotateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.RotateButton.BackgroundImage = global::HareEditor.Properties.Resources.reload;
            this.RotateButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RotateButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            this.RotateButton.FlatAppearance.BorderSize = 2;
            this.RotateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RotateButton.Location = new System.Drawing.Point(88, 8);
            this.RotateButton.Margin = new System.Windows.Forms.Padding(0);
            this.RotateButton.Name = "RotateButton";
            this.RotateButton.Size = new System.Drawing.Size(40, 40);
            this.RotateButton.TabIndex = 2;
            this.RotateButton.UseVisualStyleBackColor = false;
            this.RotateButton.Visible = false;
            // 
            // MoveBoutton
            // 
            this.MoveBoutton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.MoveBoutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.MoveBoutton.BackgroundImage = global::HareEditor.Properties.Resources.directions;
            this.MoveBoutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MoveBoutton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            this.MoveBoutton.FlatAppearance.BorderSize = 2;
            this.MoveBoutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MoveBoutton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MoveBoutton.Location = new System.Drawing.Point(48, 8);
            this.MoveBoutton.Margin = new System.Windows.Forms.Padding(0);
            this.MoveBoutton.Name = "MoveBoutton";
            this.MoveBoutton.Size = new System.Drawing.Size(40, 40);
            this.MoveBoutton.TabIndex = 1;
            this.MoveBoutton.UseMnemonic = false;
            this.MoveBoutton.UseVisualStyleBackColor = false;
            this.MoveBoutton.Visible = false;
            // 
            // GrabButton
            // 
            this.GrabButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.GrabButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.GrabButton.BackgroundImage = global::HareEditor.Properties.Resources.grab2;
            this.GrabButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GrabButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            this.GrabButton.FlatAppearance.BorderSize = 2;
            this.GrabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GrabButton.Location = new System.Drawing.Point(8, 8);
            this.GrabButton.Margin = new System.Windows.Forms.Padding(0);
            this.GrabButton.Name = "GrabButton";
            this.GrabButton.Size = new System.Drawing.Size(40, 40);
            this.GrabButton.TabIndex = 0;
            this.GrabButton.UseVisualStyleBackColor = false;
            this.GrabButton.Visible = false;
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.wrapperPanel);
            this.Controls.Add(this.lblLastLog);
            this.Controls.Add(this.Appbar);
            this.Controls.Add(this.MenuStrip);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStrip;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Editor";
            this.Text = "Hare Editor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Editor_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Editor_FormClosed);
            this.Resize += new System.EventHandler(this.Editor_Resize);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.HierarchyMenu.ResumeLayout(false);
            this.wrapperPanel.ResumeLayout(false);
            this.renderPanel.ResumeLayout(false);
            this.gameViewPanel.ResumeLayout(false);
            this.dataPanel.ResumeLayout(false);
            this.assetsPanel.ResumeLayout(false);
            this.hierarchyPanel.ResumeLayout(false);
            this.inspectorPanel.ResumeLayout(false);
            this.Appbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DBPanel Appbar;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem FileMenu;
        private System.Windows.Forms.ToolStripMenuItem NewSceneMenu;
        private System.Windows.Forms.ToolStripMenuItem SaveSceneMenu;
        private System.Windows.Forms.ToolStripMenuItem SaveASSceneMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private DBPanel dataPanel;
        private DBPanel assetsPanel;
        private DBPanel hierarchyPanel;
        private DBPanel inspectorPanel;
        private DBPanel renderPanel;
        private DBPanel gameViewPanel;
        private DBPanel wrapperPanel;
        private System.Windows.Forms.ToolStripMenuItem OpenSceneMenu;
        private System.Windows.Forms.ToolStripMenuItem BuildSettingsMenu;
        private System.Windows.Forms.ToolStripMenuItem BuildRunMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem playToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pauseToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem projectSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem physicsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assetsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showInExplorerToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gameObjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createEmptyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dObjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dObjectToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem lightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem audioToolStripMenuItem;
        private System.Windows.Forms.Label lblAssets;
        private System.Windows.Forms.Label lblHierarchy;
        private System.Windows.Forms.Label lblInspector;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button ScaleButton;
        private System.Windows.Forms.Button RotateButton;
        private System.Windows.Forms.Button MoveBoutton;
        private System.Windows.Forms.Button GrabButton;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Button PauseButton;
        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.ToolStripMenuItem spriteToolStripMenuItem;
        public Inspector Inspector;
        public Sceneview Sceneview;
        public Assets Assets;
        public Hierarchy Hierarchy;
        private System.Windows.Forms.ContextMenuStrip HierarchyMenu;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.ToolStripMenuItem cameraToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem CopyMenu;
        private System.Windows.Forms.ToolStripMenuItem PasteMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem DuplicateMenu;
        private System.Windows.Forms.ToolStripMenuItem DeleteMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem10;
        private System.Windows.Forms.ToolStripMenuItem CreateEmptyMenu;
        private System.Windows.Forms.ToolStripMenuItem TObjectMenu;
        private System.Windows.Forms.ToolStripMenuItem TwObjectMenu;
        private System.Windows.Forms.ToolStripMenuItem LightMenu;
        private System.Windows.Forms.ToolStripMenuItem AudioMenu;
        private System.Windows.Forms.ToolStripMenuItem CameraMenu;
        private System.Windows.Forms.ToolStripMenuItem sphereToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cubeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SphereMenu;
        private System.Windows.Forms.ToolStripMenuItem CubeMenu;
        private System.Windows.Forms.ToolStripMenuItem SpriteMenu;
        private System.Windows.Forms.ToolStripMenuItem themeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lightToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem darkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hybridToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showConsoleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sceneCameraPropertiesToolStripMenuItem;
        private System.Windows.Forms.Label lblScene;
        private System.Windows.Forms.Button bntAddComponent;
        private System.Windows.Forms.Label lblLastLog;
        private System.Windows.Forms.ToolStripMenuItem folderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cScriptToolStripMenuItem;
    }
}
