namespace TomWeatherApp
{
    partial class stormNameMaintenanceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(stormNameMaintenanceForm));
            this.stormMaintTopLabel = new System.Windows.Forms.Label();
            this.devCreditLabel = new System.Windows.Forms.Label();
            this.cDInventory_20171_BackupDataSet = new TomWeatherApp.CDInventory_20171_BackupDataSet();
            this.stormNamesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stormNamesTableAdapter = new TomWeatherApp.CDInventory_20171_BackupDataSetTableAdapters.StormNamesTableAdapter();
            this.tableAdapterManager = new TomWeatherApp.CDInventory_20171_BackupDataSetTableAdapters.TableAdapterManager();
            this.stormNamesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.stormNamesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.administratorGroupBox = new System.Windows.Forms.GroupBox();
            this.stormNameGroupBox = new System.Windows.Forms.GroupBox();
            this.stormNameTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.stormIdTextBox = new System.Windows.Forms.TextBox();
            this.resultsGroupBox = new System.Windows.Forms.GroupBox();
            this.userInfoLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cDInventory_20171_BackupDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stormNamesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stormNamesBindingNavigator)).BeginInit();
            this.stormNamesBindingNavigator.SuspendLayout();
            this.administratorGroupBox.SuspendLayout();
            this.stormNameGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.resultsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // stormMaintTopLabel
            // 
            this.stormMaintTopLabel.AutoSize = true;
            this.stormMaintTopLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.stormMaintTopLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stormMaintTopLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stormMaintTopLabel.Location = new System.Drawing.Point(151, 60);
            this.stormMaintTopLabel.Name = "stormMaintTopLabel";
            this.stormMaintTopLabel.Size = new System.Drawing.Size(317, 77);
            this.stormMaintTopLabel.TabIndex = 2;
            this.stormMaintTopLabel.Text = "Tom\'s C# Weather App\r\nStorm Name Maintenance Form\r\nAdministrator Use Only!";
            this.stormMaintTopLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // devCreditLabel
            // 
            this.devCreditLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.devCreditLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.devCreditLabel.Location = new System.Drawing.Point(221, 555);
            this.devCreditLabel.Name = "devCreditLabel";
            this.devCreditLabel.Size = new System.Drawing.Size(194, 90);
            this.devCreditLabel.TabIndex = 6;
            this.devCreditLabel.Text = "Tom\'s C# Weather App\r\nDeveloper: Tom Bielawski\r\n11/13/2020\r\nCOP2360C FSCJ Profess" +
    "or Gehrig";
            this.devCreditLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cDInventory_20171_BackupDataSet
            // 
            this.cDInventory_20171_BackupDataSet.DataSetName = "CDInventory_20171_BackupDataSet";
            this.cDInventory_20171_BackupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stormNamesBindingSource
            // 
            this.stormNamesBindingSource.DataMember = "StormNames";
            this.stormNamesBindingSource.DataSource = this.cDInventory_20171_BackupDataSet;
            // 
            // stormNamesTableAdapter
            // 
            this.stormNamesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.StormNamesTableAdapter = this.stormNamesTableAdapter;
            this.tableAdapterManager.Storms2TableAdapter = null;
            this.tableAdapterManager.SystemStatusTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TomWeatherApp.CDInventory_20171_BackupDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // stormNamesBindingNavigator
            // 
            this.stormNamesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.stormNamesBindingNavigator.BindingSource = this.stormNamesBindingSource;
            this.stormNamesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.stormNamesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.stormNamesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.stormNamesBindingNavigatorSaveItem});
            this.stormNamesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.stormNamesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.stormNamesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.stormNamesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.stormNamesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.stormNamesBindingNavigator.Name = "stormNamesBindingNavigator";
            this.stormNamesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.stormNamesBindingNavigator.Size = new System.Drawing.Size(606, 25);
            this.stormNamesBindingNavigator.TabIndex = 1;
            this.stormNamesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
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
            // stormNamesBindingNavigatorSaveItem
            // 
            this.stormNamesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.stormNamesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("stormNamesBindingNavigatorSaveItem.Image")));
            this.stormNamesBindingNavigatorSaveItem.Name = "stormNamesBindingNavigatorSaveItem";
            this.stormNamesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.stormNamesBindingNavigatorSaveItem.Text = "Save Data";
            this.stormNamesBindingNavigatorSaveItem.Click += new System.EventHandler(this.stormNamesBindingNavigatorSaveItem_Click);
            // 
            // administratorGroupBox
            // 
            this.administratorGroupBox.Controls.Add(this.stormNameGroupBox);
            this.administratorGroupBox.Controls.Add(this.groupBox1);
            this.administratorGroupBox.Controls.Add(this.resultsGroupBox);
            this.administratorGroupBox.Controls.Add(this.clearButton);
            this.administratorGroupBox.Controls.Add(this.exitButton);
            this.administratorGroupBox.Location = new System.Drawing.Point(151, 172);
            this.administratorGroupBox.Name = "administratorGroupBox";
            this.administratorGroupBox.Size = new System.Drawing.Size(317, 339);
            this.administratorGroupBox.TabIndex = 3;
            this.administratorGroupBox.TabStop = false;
            this.administratorGroupBox.Text = "Administrator Controls";
            // 
            // stormNameGroupBox
            // 
            this.stormNameGroupBox.Controls.Add(this.stormNameTextBox);
            this.stormNameGroupBox.Location = new System.Drawing.Point(51, 84);
            this.stormNameGroupBox.Name = "stormNameGroupBox";
            this.stormNameGroupBox.Size = new System.Drawing.Size(223, 59);
            this.stormNameGroupBox.TabIndex = 2;
            this.stormNameGroupBox.TabStop = false;
            this.stormNameGroupBox.Text = "Storm Name";
            // 
            // stormNameTextBox
            // 
            this.stormNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stormNamesBindingSource, "StormName", true));
            this.stormNameTextBox.Location = new System.Drawing.Point(6, 19);
            this.stormNameTextBox.Name = "stormNameTextBox";
            this.stormNameTextBox.Size = new System.Drawing.Size(207, 20);
            this.stormNameTextBox.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.stormIdTextBox);
            this.groupBox1.Location = new System.Drawing.Point(51, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 59);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Storm ID";
            // 
            // stormIdTextBox
            // 
            this.stormIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stormNamesBindingSource, "StormId", true));
            this.stormIdTextBox.Location = new System.Drawing.Point(6, 21);
            this.stormIdTextBox.Name = "stormIdTextBox";
            this.stormIdTextBox.Size = new System.Drawing.Size(207, 20);
            this.stormIdTextBox.TabIndex = 1;
            // 
            // resultsGroupBox
            // 
            this.resultsGroupBox.Controls.Add(this.userInfoLabel);
            this.resultsGroupBox.Location = new System.Drawing.Point(51, 145);
            this.resultsGroupBox.Name = "resultsGroupBox";
            this.resultsGroupBox.Size = new System.Drawing.Size(223, 100);
            this.resultsGroupBox.TabIndex = 5;
            this.resultsGroupBox.TabStop = false;
            this.resultsGroupBox.Text = "User Information";
            // 
            // userInfoLabel
            // 
            this.userInfoLabel.BackColor = System.Drawing.SystemColors.Control;
            this.userInfoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userInfoLabel.Location = new System.Drawing.Point(6, 16);
            this.userInfoLabel.Name = "userInfoLabel";
            this.userInfoLabel.Size = new System.Drawing.Size(211, 71);
            this.userInfoLabel.TabIndex = 1;
            this.userInfoLabel.Text = "Exception Messages and User Information Appear Here";
            this.userInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(51, 268);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(94, 52);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "C&LEAR";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(174, 268);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(94, 52);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "C&LOSE";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // stormNameMaintenanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(606, 651);
            this.Controls.Add(this.administratorGroupBox);
            this.Controls.Add(this.stormNamesBindingNavigator);
            this.Controls.Add(this.devCreditLabel);
            this.Controls.Add(this.stormMaintTopLabel);
            this.DoubleBuffered = true;
            this.Name = "stormNameMaintenanceForm";
            this.Load += new System.EventHandler(this.stormNameMaintenanceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cDInventory_20171_BackupDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stormNamesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stormNamesBindingNavigator)).EndInit();
            this.stormNamesBindingNavigator.ResumeLayout(false);
            this.stormNamesBindingNavigator.PerformLayout();
            this.administratorGroupBox.ResumeLayout(false);
            this.stormNameGroupBox.ResumeLayout(false);
            this.stormNameGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.resultsGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label stormMaintTopLabel;
        private System.Windows.Forms.Label devCreditLabel;
        private CDInventory_20171_BackupDataSet cDInventory_20171_BackupDataSet;
        private System.Windows.Forms.BindingSource stormNamesBindingSource;
        private CDInventory_20171_BackupDataSetTableAdapters.StormNamesTableAdapter stormNamesTableAdapter;
        private CDInventory_20171_BackupDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator stormNamesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton stormNamesBindingNavigatorSaveItem;
        private System.Windows.Forms.GroupBox administratorGroupBox;
        private System.Windows.Forms.TextBox stormIdTextBox;
        private System.Windows.Forms.TextBox stormNameTextBox;
        private System.Windows.Forms.Label userInfoLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.GroupBox resultsGroupBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.GroupBox stormNameGroupBox;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}