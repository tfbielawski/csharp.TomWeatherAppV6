namespace TomWeatherApp
{
    partial class StormDataMaintenanceForm
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
            System.Windows.Forms.Label indicatorLabel;
            System.Windows.Forms.Label stormStatusLabel;
            System.Windows.Forms.Label latLabel;
            System.Windows.Forms.Label lonLabel;
            System.Windows.Forms.Label windspeedLabel;
            System.Windows.Forms.Label pressureLabel;
            System.Windows.Forms.Label stormIDLabel;
            System.Windows.Forms.Label stormDateLabel;
            System.Windows.Forms.Label stormTimeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StormDataMaintenanceForm));
            this.stormMaintTopLabel = new System.Windows.Forms.Label();
            this.devCreditLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.cDInventory_20171_BackupDataSet = new TomWeatherApp.CDInventory_20171_BackupDataSet();
            this.storms2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.storms2TableAdapter = new TomWeatherApp.CDInventory_20171_BackupDataSetTableAdapters.Storms2TableAdapter();
            this.tableAdapterManager = new TomWeatherApp.CDInventory_20171_BackupDataSetTableAdapters.TableAdapterManager();
            this.storms2BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.storms2BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.adminControlsGroupBox = new System.Windows.Forms.GroupBox();
            this.resultsGroupBox = new System.Windows.Forms.GroupBox();
            this.userInfoLabel = new System.Windows.Forms.Label();
            this.stormDateTextBox = new System.Windows.Forms.TextBox();
            this.stormTimeTextBox = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.indicatorTextBox = new System.Windows.Forms.TextBox();
            this.stormStatusTextBox = new System.Windows.Forms.TextBox();
            this.latTextBox = new System.Windows.Forms.TextBox();
            this.lonTextBox = new System.Windows.Forms.TextBox();
            this.windspeedTextBox = new System.Windows.Forms.TextBox();
            this.pressureTextBox = new System.Windows.Forms.TextBox();
            this.stormIDTextBox = new System.Windows.Forms.TextBox();
            indicatorLabel = new System.Windows.Forms.Label();
            stormStatusLabel = new System.Windows.Forms.Label();
            latLabel = new System.Windows.Forms.Label();
            lonLabel = new System.Windows.Forms.Label();
            windspeedLabel = new System.Windows.Forms.Label();
            pressureLabel = new System.Windows.Forms.Label();
            stormIDLabel = new System.Windows.Forms.Label();
            stormDateLabel = new System.Windows.Forms.Label();
            stormTimeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cDInventory_20171_BackupDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storms2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storms2BindingNavigator)).BeginInit();
            this.storms2BindingNavigator.SuspendLayout();
            this.adminControlsGroupBox.SuspendLayout();
            this.resultsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // indicatorLabel
            // 
            indicatorLabel.AutoSize = true;
            indicatorLabel.Location = new System.Drawing.Point(27, 88);
            indicatorLabel.Name = "indicatorLabel";
            indicatorLabel.Size = new System.Drawing.Size(51, 13);
            indicatorLabel.TabIndex = 5;
            indicatorLabel.Text = "Indicator:";
            // 
            // stormStatusLabel
            // 
            stormStatusLabel.AutoSize = true;
            stormStatusLabel.Location = new System.Drawing.Point(27, 114);
            stormStatusLabel.Name = "stormStatusLabel";
            stormStatusLabel.Size = new System.Drawing.Size(70, 13);
            stormStatusLabel.TabIndex = 7;
            stormStatusLabel.Text = "Storm Status:";
            // 
            // latLabel
            // 
            latLabel.AutoSize = true;
            latLabel.Location = new System.Drawing.Point(27, 140);
            latLabel.Name = "latLabel";
            latLabel.Size = new System.Drawing.Size(48, 13);
            latLabel.TabIndex = 9;
            latLabel.Text = "Latitude:";
            // 
            // lonLabel
            // 
            lonLabel.AutoSize = true;
            lonLabel.Location = new System.Drawing.Point(27, 166);
            lonLabel.Name = "lonLabel";
            lonLabel.Size = new System.Drawing.Size(57, 13);
            lonLabel.TabIndex = 11;
            lonLabel.Text = "Longitude:";
            // 
            // windspeedLabel
            // 
            windspeedLabel.AutoSize = true;
            windspeedLabel.Location = new System.Drawing.Point(27, 192);
            windspeedLabel.Name = "windspeedLabel";
            windspeedLabel.Size = new System.Drawing.Size(64, 13);
            windspeedLabel.TabIndex = 13;
            windspeedLabel.Text = "Windspeed:";
            // 
            // pressureLabel
            // 
            pressureLabel.AutoSize = true;
            pressureLabel.Location = new System.Drawing.Point(27, 218);
            pressureLabel.Name = "pressureLabel";
            pressureLabel.Size = new System.Drawing.Size(51, 13);
            pressureLabel.TabIndex = 15;
            pressureLabel.Text = "Pressure:";
            // 
            // stormIDLabel
            // 
            stormIDLabel.AutoSize = true;
            stormIDLabel.Location = new System.Drawing.Point(27, 245);
            stormIDLabel.Name = "stormIDLabel";
            stormIDLabel.Size = new System.Drawing.Size(51, 13);
            stormIDLabel.TabIndex = 17;
            stormIDLabel.Text = "Storm ID:";
            // 
            // stormDateLabel
            // 
            stormDateLabel.AutoSize = true;
            stormDateLabel.Location = new System.Drawing.Point(27, 32);
            stormDateLabel.Name = "stormDateLabel";
            stormDateLabel.Size = new System.Drawing.Size(63, 13);
            stormDateLabel.TabIndex = 1;
            stormDateLabel.Text = "Storm Date:";
            // 
            // stormTimeLabel
            // 
            stormTimeLabel.AutoSize = true;
            stormTimeLabel.Location = new System.Drawing.Point(27, 58);
            stormTimeLabel.Name = "stormTimeLabel";
            stormTimeLabel.Size = new System.Drawing.Size(63, 13);
            stormTimeLabel.TabIndex = 3;
            stormTimeLabel.Text = "Storm Time:";
            // 
            // stormMaintTopLabel
            // 
            this.stormMaintTopLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.stormMaintTopLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stormMaintTopLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stormMaintTopLabel.Location = new System.Drawing.Point(118, 60);
            this.stormMaintTopLabel.Name = "stormMaintTopLabel";
            this.stormMaintTopLabel.Size = new System.Drawing.Size(354, 77);
            this.stormMaintTopLabel.TabIndex = 2;
            this.stormMaintTopLabel.Text = "Tom\'s C# Weather App\r\nStorm Data Maintenance Form\r\nAdministrator Use Only!";
            this.stormMaintTopLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // devCreditLabel
            // 
            this.devCreditLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.devCreditLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.devCreditLabel.Location = new System.Drawing.Point(196, 632);
            this.devCreditLabel.Name = "devCreditLabel";
            this.devCreditLabel.Size = new System.Drawing.Size(194, 90);
            this.devCreditLabel.TabIndex = 4;
            this.devCreditLabel.Text = "Tom\'s C# Weather App\r\nDeveloper: Tom Bielawski\r\n11/13/2020\r\nCOP2360C FSCJ Profess" +
    "or Gehrig";
            this.devCreditLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(221, 431);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(94, 52);
            this.exitButton.TabIndex = 20;
            this.exitButton.Text = "CL&OSE";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // cDInventory_20171_BackupDataSet
            // 
            this.cDInventory_20171_BackupDataSet.DataSetName = "CDInventory_20171_BackupDataSet";
            this.cDInventory_20171_BackupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // storms2BindingSource
            // 
            this.storms2BindingSource.DataMember = "Storms2";
            this.storms2BindingSource.DataSource = this.cDInventory_20171_BackupDataSet;
            // 
            // storms2TableAdapter
            // 
            this.storms2TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.StormNamesTableAdapter = null;
            this.tableAdapterManager.Storms2TableAdapter = this.storms2TableAdapter;
            this.tableAdapterManager.SystemStatusTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TomWeatherApp.CDInventory_20171_BackupDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // storms2BindingNavigator
            // 
            this.storms2BindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.storms2BindingNavigator.BindingSource = this.storms2BindingSource;
            this.storms2BindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.storms2BindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.storms2BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.storms2BindingNavigatorSaveItem});
            this.storms2BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.storms2BindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.storms2BindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.storms2BindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.storms2BindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.storms2BindingNavigator.Name = "storms2BindingNavigator";
            this.storms2BindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.storms2BindingNavigator.Size = new System.Drawing.Size(577, 25);
            this.storms2BindingNavigator.TabIndex = 1;
            this.storms2BindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // storms2BindingNavigatorSaveItem
            // 
            this.storms2BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.storms2BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("storms2BindingNavigatorSaveItem.Image")));
            this.storms2BindingNavigatorSaveItem.Name = "storms2BindingNavigatorSaveItem";
            this.storms2BindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.storms2BindingNavigatorSaveItem.Text = "Save Data";
            this.storms2BindingNavigatorSaveItem.Click += new System.EventHandler(this.storms2BindingNavigatorSaveItem_Click);
            // 
            // adminControlsGroupBox
            // 
            this.adminControlsGroupBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.adminControlsGroupBox.Controls.Add(this.resultsGroupBox);
            this.adminControlsGroupBox.Controls.Add(stormTimeLabel);
            this.adminControlsGroupBox.Controls.Add(stormDateLabel);
            this.adminControlsGroupBox.Controls.Add(this.stormDateTextBox);
            this.adminControlsGroupBox.Controls.Add(this.stormTimeTextBox);
            this.adminControlsGroupBox.Controls.Add(indicatorLabel);
            this.adminControlsGroupBox.Controls.Add(stormStatusLabel);
            this.adminControlsGroupBox.Controls.Add(latLabel);
            this.adminControlsGroupBox.Controls.Add(lonLabel);
            this.adminControlsGroupBox.Controls.Add(windspeedLabel);
            this.adminControlsGroupBox.Controls.Add(pressureLabel);
            this.adminControlsGroupBox.Controls.Add(stormIDLabel);
            this.adminControlsGroupBox.Controls.Add(this.clearButton);
            this.adminControlsGroupBox.Controls.Add(this.exitButton);
            this.adminControlsGroupBox.Controls.Add(this.indicatorTextBox);
            this.adminControlsGroupBox.Controls.Add(this.stormStatusTextBox);
            this.adminControlsGroupBox.Controls.Add(this.latTextBox);
            this.adminControlsGroupBox.Controls.Add(this.lonTextBox);
            this.adminControlsGroupBox.Controls.Add(this.windspeedTextBox);
            this.adminControlsGroupBox.Controls.Add(this.pressureTextBox);
            this.adminControlsGroupBox.Controls.Add(this.stormIDTextBox);
            this.adminControlsGroupBox.Location = new System.Drawing.Point(118, 140);
            this.adminControlsGroupBox.Name = "adminControlsGroupBox";
            this.adminControlsGroupBox.Size = new System.Drawing.Size(354, 489);
            this.adminControlsGroupBox.TabIndex = 3;
            this.adminControlsGroupBox.TabStop = false;
            this.adminControlsGroupBox.Text = "Administrator Controls";
            // 
            // resultsGroupBox
            // 
            this.resultsGroupBox.Controls.Add(this.userInfoLabel);
            this.resultsGroupBox.Location = new System.Drawing.Point(30, 264);
            this.resultsGroupBox.Name = "resultsGroupBox";
            this.resultsGroupBox.Size = new System.Drawing.Size(285, 156);
            this.resultsGroupBox.TabIndex = 21;
            this.resultsGroupBox.TabStop = false;
            this.resultsGroupBox.Text = "User Information";
            // 
            // userInfoLabel
            // 
            this.userInfoLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.userInfoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userInfoLabel.Location = new System.Drawing.Point(6, 14);
            this.userInfoLabel.Name = "userInfoLabel";
            this.userInfoLabel.Size = new System.Drawing.Size(273, 139);
            this.userInfoLabel.TabIndex = 1;
            this.userInfoLabel.Text = "Exception Messages and User Info Appear Here";
            this.userInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // stormDateTextBox
            // 
            this.stormDateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.storms2BindingSource, "StormDate", true));
            this.stormDateTextBox.Location = new System.Drawing.Point(133, 29);
            this.stormDateTextBox.Name = "stormDateTextBox";
            this.stormDateTextBox.Size = new System.Drawing.Size(182, 20);
            this.stormDateTextBox.TabIndex = 2;
            this.stormDateTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // stormTimeTextBox
            // 
            this.stormTimeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.storms2BindingSource, "StormTime", true));
            this.stormTimeTextBox.Location = new System.Drawing.Point(133, 55);
            this.stormTimeTextBox.Name = "stormTimeTextBox";
            this.stormTimeTextBox.Size = new System.Drawing.Size(182, 20);
            this.stormTimeTextBox.TabIndex = 4;
            this.stormTimeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(30, 431);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(94, 52);
            this.clearButton.TabIndex = 19;
            this.clearButton.Text = "C&LEAR";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // indicatorTextBox
            // 
            this.indicatorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.storms2BindingSource, "Indicator", true));
            this.indicatorTextBox.Location = new System.Drawing.Point(133, 81);
            this.indicatorTextBox.Name = "indicatorTextBox";
            this.indicatorTextBox.Size = new System.Drawing.Size(182, 20);
            this.indicatorTextBox.TabIndex = 6;
            // 
            // stormStatusTextBox
            // 
            this.stormStatusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.storms2BindingSource, "StormStatus", true));
            this.stormStatusTextBox.Location = new System.Drawing.Point(133, 107);
            this.stormStatusTextBox.Name = "stormStatusTextBox";
            this.stormStatusTextBox.Size = new System.Drawing.Size(182, 20);
            this.stormStatusTextBox.TabIndex = 8;
            // 
            // latTextBox
            // 
            this.latTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.storms2BindingSource, "Lat", true));
            this.latTextBox.Location = new System.Drawing.Point(133, 133);
            this.latTextBox.Name = "latTextBox";
            this.latTextBox.Size = new System.Drawing.Size(182, 20);
            this.latTextBox.TabIndex = 10;
            // 
            // lonTextBox
            // 
            this.lonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.storms2BindingSource, "Lon", true));
            this.lonTextBox.Location = new System.Drawing.Point(133, 159);
            this.lonTextBox.Name = "lonTextBox";
            this.lonTextBox.Size = new System.Drawing.Size(182, 20);
            this.lonTextBox.TabIndex = 12;
            // 
            // windspeedTextBox
            // 
            this.windspeedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.storms2BindingSource, "Windspeed", true));
            this.windspeedTextBox.Location = new System.Drawing.Point(133, 185);
            this.windspeedTextBox.Name = "windspeedTextBox";
            this.windspeedTextBox.Size = new System.Drawing.Size(182, 20);
            this.windspeedTextBox.TabIndex = 14;
            // 
            // pressureTextBox
            // 
            this.pressureTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.storms2BindingSource, "Pressure", true));
            this.pressureTextBox.Location = new System.Drawing.Point(133, 211);
            this.pressureTextBox.Name = "pressureTextBox";
            this.pressureTextBox.Size = new System.Drawing.Size(182, 20);
            this.pressureTextBox.TabIndex = 16;
            // 
            // stormIDTextBox
            // 
            this.stormIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.storms2BindingSource, "StormID", true));
            this.stormIDTextBox.Location = new System.Drawing.Point(133, 238);
            this.stormIDTextBox.Name = "stormIDTextBox";
            this.stormIDTextBox.Size = new System.Drawing.Size(182, 20);
            this.stormIDTextBox.TabIndex = 18;
            // 
            // StormDataMaintenanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(577, 720);
            this.Controls.Add(this.adminControlsGroupBox);
            this.Controls.Add(this.storms2BindingNavigator);
            this.Controls.Add(this.devCreditLabel);
            this.Controls.Add(this.stormMaintTopLabel);
            this.DoubleBuffered = true;
            this.Name = "StormDataMaintenanceForm";
            this.Text = "Storm Data Maintenance Form";
            this.Load += new System.EventHandler(this.StormMaintenanceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cDInventory_20171_BackupDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storms2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storms2BindingNavigator)).EndInit();
            this.storms2BindingNavigator.ResumeLayout(false);
            this.storms2BindingNavigator.PerformLayout();
            this.adminControlsGroupBox.ResumeLayout(false);
            this.adminControlsGroupBox.PerformLayout();
            this.resultsGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label stormMaintTopLabel;
        private System.Windows.Forms.Label devCreditLabel;
        private System.Windows.Forms.Button exitButton;
        private CDInventory_20171_BackupDataSet cDInventory_20171_BackupDataSet;
        private System.Windows.Forms.BindingSource storms2BindingSource;
        private CDInventory_20171_BackupDataSetTableAdapters.Storms2TableAdapter storms2TableAdapter;
        private CDInventory_20171_BackupDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator storms2BindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton storms2BindingNavigatorSaveItem;
        private System.Windows.Forms.GroupBox adminControlsGroupBox;
        private System.Windows.Forms.TextBox stormDateTextBox;
        private System.Windows.Forms.TextBox stormTimeTextBox;
        private System.Windows.Forms.TextBox indicatorTextBox;
        private System.Windows.Forms.TextBox stormStatusTextBox;
        private System.Windows.Forms.TextBox latTextBox;
        private System.Windows.Forms.TextBox lonTextBox;
        private System.Windows.Forms.TextBox windspeedTextBox;
        private System.Windows.Forms.TextBox pressureTextBox;
        private System.Windows.Forms.TextBox stormIDTextBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.GroupBox resultsGroupBox;
        private System.Windows.Forms.Label userInfoLabel;
    }
}