namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.hiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyCtrlCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteCtrlVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importFromFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expandALLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.collapseAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoCtrlIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.stepEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deviceServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stepEditorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolWInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.megaViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOnfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Device_Server = new System.Windows.Forms.TabPage();
            this.Step_Editor = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.treeView2 = new System.Windows.Forms.TreeView();
            this.Step_Parameters = new System.Windows.Forms.TabPage();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.bindingNavigator2 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.Compile = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.ToolWinBN = new System.Windows.Forms.ToolStripButton();
            this.MegaViewBN = new System.Windows.Forms.ToolStripButton();
            this.LoginBN = new System.Windows.Forms.ToolStripButton();
            this.LogoutBN = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.DeviceServerBN = new System.Windows.Forms.ToolStripButton();
            this.StepEditorBN = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.Device_Server.SuspendLayout();
            this.Step_Editor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Step_Parameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).BeginInit();
            this.bindingNavigator2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(6, 60);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(607, 799);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.treeView1_AfterLabelEdit);
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.treeView1_MouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hiToolStripMenuItem,
            this.oKToolStripMenuItem,
            this.copyCtrlCToolStripMenuItem,
            this.pasteCtrlVToolStripMenuItem,
            this.exportToFileToolStripMenuItem,
            this.importFromFileToolStripMenuItem,
            this.expandALLToolStripMenuItem,
            this.collapseAllToolStripMenuItem,
            this.infoCtrlIToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(219, 256);
            // 
            // hiToolStripMenuItem
            // 
            this.hiToolStripMenuItem.Name = "hiToolStripMenuItem";
            this.hiToolStripMenuItem.Size = new System.Drawing.Size(218, 28);
            this.hiToolStripMenuItem.Text = "Edit F2";
            // 
            // oKToolStripMenuItem
            // 
            this.oKToolStripMenuItem.Name = "oKToolStripMenuItem";
            this.oKToolStripMenuItem.Size = new System.Drawing.Size(218, 28);
            this.oKToolStripMenuItem.Text = "Remove Del";
            this.oKToolStripMenuItem.Click += new System.EventHandler(this.oKToolStripMenuItem_Click);
            // 
            // copyCtrlCToolStripMenuItem
            // 
            this.copyCtrlCToolStripMenuItem.Name = "copyCtrlCToolStripMenuItem";
            this.copyCtrlCToolStripMenuItem.Size = new System.Drawing.Size(218, 28);
            this.copyCtrlCToolStripMenuItem.Text = "Copy Ctrl/C";
            // 
            // pasteCtrlVToolStripMenuItem
            // 
            this.pasteCtrlVToolStripMenuItem.Name = "pasteCtrlVToolStripMenuItem";
            this.pasteCtrlVToolStripMenuItem.Size = new System.Drawing.Size(218, 28);
            this.pasteCtrlVToolStripMenuItem.Text = "Paste Ctrl/V";
            // 
            // exportToFileToolStripMenuItem
            // 
            this.exportToFileToolStripMenuItem.Name = "exportToFileToolStripMenuItem";
            this.exportToFileToolStripMenuItem.Size = new System.Drawing.Size(218, 28);
            this.exportToFileToolStripMenuItem.Text = "Export to File";
            this.exportToFileToolStripMenuItem.Click += new System.EventHandler(this.exportToFileToolStripMenuItem_Click);
            // 
            // importFromFileToolStripMenuItem
            // 
            this.importFromFileToolStripMenuItem.Name = "importFromFileToolStripMenuItem";
            this.importFromFileToolStripMenuItem.Size = new System.Drawing.Size(218, 28);
            this.importFromFileToolStripMenuItem.Text = "Import from File";
            // 
            // expandALLToolStripMenuItem
            // 
            this.expandALLToolStripMenuItem.Name = "expandALLToolStripMenuItem";
            this.expandALLToolStripMenuItem.Size = new System.Drawing.Size(218, 28);
            this.expandALLToolStripMenuItem.Text = "ExpandAll +";
            // 
            // collapseAllToolStripMenuItem
            // 
            this.collapseAllToolStripMenuItem.Name = "collapseAllToolStripMenuItem";
            this.collapseAllToolStripMenuItem.Size = new System.Drawing.Size(218, 28);
            this.collapseAllToolStripMenuItem.Text = "CollapseAll -";
            // 
            // infoCtrlIToolStripMenuItem
            // 
            this.infoCtrlIToolStripMenuItem.Name = "infoCtrlIToolStripMenuItem";
            this.infoCtrlIToolStripMenuItem.Size = new System.Drawing.Size(218, 28);
            this.infoCtrlIToolStripMenuItem.Text = "Info Ctrl/I";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(1247, 60);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(625, 784);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(612, 808);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(209, 51);
            this.button2.TabIndex = 4;
            this.button2.Text = "Read";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.stepEditorToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.cOnfigToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1888, 31);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem1});
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(51, 27);
            this.startToolStripMenuItem.Text = "File";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // startToolStripMenuItem1
            // 
            this.startToolStripMenuItem1.Name = "startToolStripMenuItem1";
            this.startToolStripMenuItem1.Size = new System.Drawing.Size(133, 30);
            this.startToolStripMenuItem1.Text = "Start";
            this.startToolStripMenuItem1.Click += new System.EventHandler(this.startToolStripMenuItem1_Click);
            // 
            // stepEditorToolStripMenuItem
            // 
            this.stepEditorToolStripMenuItem.Name = "stepEditorToolStripMenuItem";
            this.stepEditorToolStripMenuItem.Size = new System.Drawing.Size(90, 27);
            this.stepEditorToolStripMenuItem.Text = "Security";
            this.stepEditorToolStripMenuItem.Click += new System.EventHandler(this.stepEditorToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(63, 27);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deviceServerToolStripMenuItem,
            this.stepEditorToolStripMenuItem1,
            this.toolWInToolStripMenuItem,
            this.megaViewToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(67, 27);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // deviceServerToolStripMenuItem
            // 
            this.deviceServerToolStripMenuItem.Image = global::XML_Program.Properties.Resources._2019_06_25_13_20_04_設定;
            this.deviceServerToolStripMenuItem.Name = "deviceServerToolStripMenuItem";
            this.deviceServerToolStripMenuItem.Size = new System.Drawing.Size(207, 30);
            this.deviceServerToolStripMenuItem.Text = "Device Server";
            // 
            // stepEditorToolStripMenuItem1
            // 
            this.stepEditorToolStripMenuItem1.Image = global::XML_Program.Properties.Resources._2019_06_25_13_20_15_設定;
            this.stepEditorToolStripMenuItem1.Name = "stepEditorToolStripMenuItem1";
            this.stepEditorToolStripMenuItem1.Size = new System.Drawing.Size(207, 30);
            this.stepEditorToolStripMenuItem1.Text = "Step Editor";
            // 
            // toolWInToolStripMenuItem
            // 
            this.toolWInToolStripMenuItem.Image = global::XML_Program.Properties.Resources._2019_06_25_13_20_23_設定;
            this.toolWInToolStripMenuItem.Name = "toolWInToolStripMenuItem";
            this.toolWInToolStripMenuItem.Size = new System.Drawing.Size(207, 30);
            this.toolWInToolStripMenuItem.Text = "Tool Win";
            // 
            // megaViewToolStripMenuItem
            // 
            this.megaViewToolStripMenuItem.Image = global::XML_Program.Properties.Resources._2019_06_25_13_22_10_設定;
            this.megaViewToolStripMenuItem.Name = "megaViewToolStripMenuItem";
            this.megaViewToolStripMenuItem.Size = new System.Drawing.Size(207, 30);
            this.megaViewToolStripMenuItem.Text = "MegaView";
            // 
            // cOnfigToolStripMenuItem
            // 
            this.cOnfigToolStripMenuItem.Name = "cOnfigToolStripMenuItem";
            this.cOnfigToolStripMenuItem.Size = new System.Drawing.Size(78, 27);
            this.cOnfigToolStripMenuItem.Text = "Config";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(55, 27);
            this.infoToolStripMenuItem.Text = "Info";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(144, 30);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Location = new System.Drawing.Point(612, 63);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(636, 799);
            this.propertyGrid1.TabIndex = 7;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Device_Server);
            this.tabControl1.Controls.Add(this.Step_Editor);
            this.tabControl1.Controls.Add(this.Step_Parameters);
            this.tabControl1.Location = new System.Drawing.Point(0, 79);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1888, 937);
            this.tabControl1.TabIndex = 8;
            this.tabControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.treeView1_MouseDown);
            // 
            // Device_Server
            // 
            this.Device_Server.Controls.Add(this.treeView1);
            this.Device_Server.Controls.Add(this.propertyGrid1);
            this.Device_Server.Controls.Add(this.button2);
            this.Device_Server.Controls.Add(this.richTextBox1);
            this.Device_Server.Location = new System.Drawing.Point(4, 28);
            this.Device_Server.Name = "Device_Server";
            this.Device_Server.Padding = new System.Windows.Forms.Padding(3);
            this.Device_Server.Size = new System.Drawing.Size(1880, 905);
            this.Device_Server.TabIndex = 0;
            this.Device_Server.Text = "Device_Server";
            this.Device_Server.UseVisualStyleBackColor = true;
            // 
            // Step_Editor
            // 
            this.Step_Editor.Controls.Add(this.dataGridView1);
            this.Step_Editor.Controls.Add(this.treeView2);
            this.Step_Editor.Location = new System.Drawing.Point(4, 28);
            this.Step_Editor.Name = "Step_Editor";
            this.Step_Editor.Padding = new System.Windows.Forms.Padding(3);
            this.Step_Editor.Size = new System.Drawing.Size(1880, 905);
            this.Step_Editor.TabIndex = 1;
            this.Step_Editor.Text = "Step Editor";
            this.Step_Editor.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(538, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 31;
            this.dataGridView1.Size = new System.Drawing.Size(1320, 748);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // treeView2
            // 
            this.treeView2.Location = new System.Drawing.Point(31, 75);
            this.treeView2.Name = "treeView2";
            this.treeView2.Size = new System.Drawing.Size(482, 748);
            this.treeView2.TabIndex = 0;
            this.treeView2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.treeView1_MouseDown);
            // 
            // Step_Parameters
            // 
            this.Step_Parameters.AutoScroll = true;
            this.Step_Parameters.Controls.Add(this.richTextBox3);
            this.Step_Parameters.Controls.Add(this.richTextBox2);
            this.Step_Parameters.Controls.Add(this.bindingNavigator2);
            this.Step_Parameters.Location = new System.Drawing.Point(4, 28);
            this.Step_Parameters.Name = "Step_Parameters";
            this.Step_Parameters.Size = new System.Drawing.Size(1880, 905);
            this.Step_Parameters.TabIndex = 2;
            this.Step_Parameters.Text = "Step Parameters";
            this.Step_Parameters.UseVisualStyleBackColor = true;
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(8, 0);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(1869, 623);
            this.richTextBox3.TabIndex = 3;
            this.richTextBox3.Text = "";
            this.richTextBox3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.richTextBox3_KeyDown);

            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(8, 660);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(1869, 242);
            this.richTextBox2.TabIndex = 2;
            this.richTextBox2.Text = "";
            this.richTextBox2.DoubleClick += new System.EventHandler(this.richTextBox2_DoubleClick);
            // 
            // bindingNavigator2
            // 
            this.bindingNavigator2.AddNewItem = null;
            this.bindingNavigator2.CountItem = null;
            this.bindingNavigator2.DeleteItem = null;
            this.bindingNavigator2.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.bindingNavigator2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorSeparator,
            this.toolStripButton1,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripButton2,
            this.bindingNavigatorSeparator3,
            this.bindingNavigatorSeparator4,
            this.Compile});
            this.bindingNavigator2.Location = new System.Drawing.Point(8, 626);
            this.bindingNavigator2.MoveFirstItem = this.Compile;
            this.bindingNavigator2.MoveLastItem = null;
            this.bindingNavigator2.MoveNextItem = null;
            this.bindingNavigator2.MovePreviousItem = null;
            this.bindingNavigator2.Name = "bindingNavigator2";
            this.bindingNavigator2.PositionItem = null;
            this.bindingNavigator2.Size = new System.Drawing.Size(317, 31);
            this.bindingNavigator2.TabIndex = 1;
            this.bindingNavigator2.Text = "bindingNavigator2";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(85, 28);
            this.toolStripButton1.Text = "Compile";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(80, 28);
            this.toolStripButton3.Text = "Execute";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(28, 28);
            this.toolStripButton4.Text = "Debug";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(71, 28);
            this.toolStripButton2.Text = "Debug";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // bindingNavigatorSeparator3
            // 
            this.bindingNavigatorSeparator3.Name = "bindingNavigatorSeparator3";
            this.bindingNavigatorSeparator3.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorSeparator4
            // 
            this.bindingNavigatorSeparator4.Name = "bindingNavigatorSeparator4";
            this.bindingNavigatorSeparator4.Size = new System.Drawing.Size(6, 31);
            // 
            // Compile
            // 
            this.Compile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Compile.Name = "Compile";
            this.Compile.RightToLeftAutoMirrorImage = true;
            this.Compile.Size = new System.Drawing.Size(23, 28);
            this.Compile.Text = "Compile";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.ToolWinBN;
            this.bindingNavigator1.CountItem = null;
            this.bindingNavigator1.DeleteItem = this.MegaViewBN;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LoginBN,
            this.LogoutBN,
            this.bindingNavigatorSeparator1,
            this.DeviceServerBN,
            this.StepEditorBN,
            this.bindingNavigatorSeparator2,
            this.ToolWinBN,
            this.MegaViewBN});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 31);
            this.bindingNavigator1.MoveFirstItem = this.LoginBN;
            this.bindingNavigator1.MoveLastItem = this.StepEditorBN;
            this.bindingNavigator1.MoveNextItem = this.DeviceServerBN;
            this.bindingNavigator1.MovePreviousItem = this.LogoutBN;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.Size = new System.Drawing.Size(1888, 31);
            this.bindingNavigator1.TabIndex = 9;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // ToolWinBN
            // 
            this.ToolWinBN.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolWinBN.Image = ((System.Drawing.Image)(resources.GetObject("ToolWinBN.Image")));
            this.ToolWinBN.Name = "ToolWinBN";
            this.ToolWinBN.RightToLeftAutoMirrorImage = true;
            this.ToolWinBN.Size = new System.Drawing.Size(28, 28);
            this.ToolWinBN.Text = "Tool Win";
            this.ToolWinBN.ToolTipText = "Tool Win";
            // 
            // MegaViewBN
            // 
            this.MegaViewBN.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MegaViewBN.Image = ((System.Drawing.Image)(resources.GetObject("MegaViewBN.Image")));
            this.MegaViewBN.Name = "MegaViewBN";
            this.MegaViewBN.RightToLeftAutoMirrorImage = true;
            this.MegaViewBN.Size = new System.Drawing.Size(28, 28);
            this.MegaViewBN.Text = "Mega View";
            this.MegaViewBN.ToolTipText = "Mega View";
            // 
            // LoginBN
            // 
            this.LoginBN.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.LoginBN.Image = ((System.Drawing.Image)(resources.GetObject("LoginBN.Image")));
            this.LoginBN.Name = "LoginBN";
            this.LoginBN.RightToLeftAutoMirrorImage = true;
            this.LoginBN.Size = new System.Drawing.Size(28, 28);
            this.LoginBN.Text = "Login";
            this.LoginBN.ToolTipText = "Login";
            // 
            // LogoutBN
            // 
            this.LogoutBN.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.LogoutBN.Image = ((System.Drawing.Image)(resources.GetObject("LogoutBN.Image")));
            this.LogoutBN.Name = "LogoutBN";
            this.LogoutBN.RightToLeftAutoMirrorImage = true;
            this.LogoutBN.Size = new System.Drawing.Size(28, 28);
            this.LogoutBN.Text = "Logout";
            this.LogoutBN.ToolTipText = "Logout";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // DeviceServerBN
            // 
            this.DeviceServerBN.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DeviceServerBN.Image = ((System.Drawing.Image)(resources.GetObject("DeviceServerBN.Image")));
            this.DeviceServerBN.Name = "DeviceServerBN";
            this.DeviceServerBN.RightToLeftAutoMirrorImage = true;
            this.DeviceServerBN.Size = new System.Drawing.Size(28, 28);
            this.DeviceServerBN.Text = "Device Server";
            this.DeviceServerBN.ToolTipText = "Device Server";
            this.DeviceServerBN.Click += new System.EventHandler(this.DeviceServerBN_Click);
            // 
            // StepEditorBN
            // 
            this.StepEditorBN.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.StepEditorBN.Image = ((System.Drawing.Image)(resources.GetObject("StepEditorBN.Image")));
            this.StepEditorBN.Name = "StepEditorBN";
            this.StepEditorBN.RightToLeftAutoMirrorImage = true;
            this.StepEditorBN.Size = new System.Drawing.Size(28, 28);
            this.StepEditorBN.Text = "Step Editor";
            this.StepEditorBN.ToolTipText = "Step Editor";
            this.StepEditorBN.Click += new System.EventHandler(this.StepEditorBN_Click);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1888, 1016);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.Device_Server.ResumeLayout(false);
            this.Step_Editor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Step_Parameters.ResumeLayout(false);
            this.Step_Parameters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).EndInit();
            this.bindingNavigator2.ResumeLayout(false);
            this.bindingNavigator2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oKToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyCtrlCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteCtrlVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importFromFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expandALLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem collapseAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoCtrlIToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private System.Windows.Forms.ToolStripMenuItem stepEditorToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Device_Server;
        private System.Windows.Forms.TabPage Step_Editor;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cOnfigToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton ToolWinBN;
        private System.Windows.Forms.ToolStripButton MegaViewBN;
        private System.Windows.Forms.ToolStripButton LoginBN;
        private System.Windows.Forms.ToolStripButton LogoutBN;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton DeviceServerBN;
        private System.Windows.Forms.ToolStripButton StepEditorBN;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripMenuItem deviceServerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stepEditorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolWInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem megaViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TreeView treeView2;
        private System.Windows.Forms.TabPage Step_Parameters;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.BindingNavigator bindingNavigator2;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator3;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton Compile;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.RichTextBox richTextBox3;
    }
}

