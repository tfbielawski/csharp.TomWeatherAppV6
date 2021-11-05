namespace TomWeatherApp
{
    partial class StormDataForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StormDataForm));
            this.logInTopLabel = new System.Windows.Forms.Label();
            this.devCreditLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.stormDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stormTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.indicatorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stormStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.latDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.windspeedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pressureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stormIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storms2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cDInventory_20171_BackupDataSet = new TomWeatherApp.CDInventory_20171_BackupDataSet();
            this.userInfoLabel = new System.Windows.Forms.Label();
            this.resultsGroupBox = new System.Windows.Forms.GroupBox();
            this.fillByWindSpeedToolStrip = new System.Windows.Forms.ToolStrip();
            this.windspeedToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.windspeedToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByWindSpeedToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.fillByStormIDToolStrip = new System.Windows.Forms.ToolStrip();
            this.stormIDToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.stormIDToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByStormIDToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.fillByAllStormDataToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByAllStormDataToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.storms2TableAdapter = new TomWeatherApp.CDInventory_20171_BackupDataSetTableAdapters.Storms2TableAdapter();
            this.tableAdapterManager = new TomWeatherApp.CDInventory_20171_BackupDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storms2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDInventory_20171_BackupDataSet)).BeginInit();
            this.resultsGroupBox.SuspendLayout();
            this.fillByWindSpeedToolStrip.SuspendLayout();
            this.fillByStormIDToolStrip.SuspendLayout();
            this.fillByAllStormDataToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // logInTopLabel
            // 
            this.logInTopLabel.AutoSize = true;
            this.logInTopLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.logInTopLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logInTopLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logInTopLabel.Location = new System.Drawing.Point(405, 45);
            this.logInTopLabel.Name = "logInTopLabel";
            this.logInTopLabel.Size = new System.Drawing.Size(235, 52);
            this.logInTopLabel.TabIndex = 4;
            this.logInTopLabel.Text = "Tom\'s C# Weather App\r\nStorm Data Form";
            this.logInTopLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // devCreditLabel
            // 
            this.devCreditLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.devCreditLabel.Location = new System.Drawing.Point(439, 487);
            this.devCreditLabel.Name = "devCreditLabel";
            this.devCreditLabel.Size = new System.Drawing.Size(184, 73);
            this.devCreditLabel.TabIndex = 8;
            this.devCreditLabel.Text = "Tom\'s C# Weather App\r\nDeveloper: Tom Bielawski\r\n11/13/2020\r\nCOP2360C FSCJ Profess" +
    "or Gehrig\r\nModified 11/25/2020";
            this.devCreditLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(481, 420);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(94, 52);
            this.closeButton.TabIndex = 7;
            this.closeButton.Text = "C&LOSE";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stormDateDataGridViewTextBoxColumn,
            this.stormTimeDataGridViewTextBoxColumn,
            this.indicatorDataGridViewTextBoxColumn,
            this.stormStatusDataGridViewTextBoxColumn,
            this.latDataGridViewTextBoxColumn,
            this.lonDataGridViewTextBoxColumn,
            this.windspeedDataGridViewTextBoxColumn,
            this.pressureDataGridViewTextBoxColumn,
            this.stormIDDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.storms2BindingSource;
            this.dataGridView.Location = new System.Drawing.Point(68, 127);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(952, 150);
            this.dataGridView.TabIndex = 5;
            // 
            // stormDateDataGridViewTextBoxColumn
            // 
            this.stormDateDataGridViewTextBoxColumn.DataPropertyName = "StormDate";
            this.stormDateDataGridViewTextBoxColumn.HeaderText = "StormDate";
            this.stormDateDataGridViewTextBoxColumn.Name = "stormDateDataGridViewTextBoxColumn";
            // 
            // stormTimeDataGridViewTextBoxColumn
            // 
            this.stormTimeDataGridViewTextBoxColumn.DataPropertyName = "StormTime";
            this.stormTimeDataGridViewTextBoxColumn.HeaderText = "StormTime";
            this.stormTimeDataGridViewTextBoxColumn.Name = "stormTimeDataGridViewTextBoxColumn";
            // 
            // indicatorDataGridViewTextBoxColumn
            // 
            this.indicatorDataGridViewTextBoxColumn.DataPropertyName = "Indicator";
            this.indicatorDataGridViewTextBoxColumn.HeaderText = "Indicator";
            this.indicatorDataGridViewTextBoxColumn.Name = "indicatorDataGridViewTextBoxColumn";
            // 
            // stormStatusDataGridViewTextBoxColumn
            // 
            this.stormStatusDataGridViewTextBoxColumn.DataPropertyName = "StormStatus";
            this.stormStatusDataGridViewTextBoxColumn.HeaderText = "StormStatus";
            this.stormStatusDataGridViewTextBoxColumn.Name = "stormStatusDataGridViewTextBoxColumn";
            // 
            // latDataGridViewTextBoxColumn
            // 
            this.latDataGridViewTextBoxColumn.DataPropertyName = "Lat";
            this.latDataGridViewTextBoxColumn.HeaderText = "Lat";
            this.latDataGridViewTextBoxColumn.Name = "latDataGridViewTextBoxColumn";
            // 
            // lonDataGridViewTextBoxColumn
            // 
            this.lonDataGridViewTextBoxColumn.DataPropertyName = "Lon";
            this.lonDataGridViewTextBoxColumn.HeaderText = "Lon";
            this.lonDataGridViewTextBoxColumn.Name = "lonDataGridViewTextBoxColumn";
            // 
            // windspeedDataGridViewTextBoxColumn
            // 
            this.windspeedDataGridViewTextBoxColumn.DataPropertyName = "Windspeed";
            this.windspeedDataGridViewTextBoxColumn.HeaderText = "Windspeed";
            this.windspeedDataGridViewTextBoxColumn.Name = "windspeedDataGridViewTextBoxColumn";
            // 
            // pressureDataGridViewTextBoxColumn
            // 
            this.pressureDataGridViewTextBoxColumn.DataPropertyName = "Pressure";
            this.pressureDataGridViewTextBoxColumn.HeaderText = "Pressure";
            this.pressureDataGridViewTextBoxColumn.Name = "pressureDataGridViewTextBoxColumn";
            // 
            // stormIDDataGridViewTextBoxColumn
            // 
            this.stormIDDataGridViewTextBoxColumn.DataPropertyName = "StormID";
            this.stormIDDataGridViewTextBoxColumn.HeaderText = "StormID";
            this.stormIDDataGridViewTextBoxColumn.Name = "stormIDDataGridViewTextBoxColumn";
            // 
            // storms2BindingSource
            // 
            this.storms2BindingSource.DataMember = "Storms2";
            this.storms2BindingSource.DataSource = this.cDInventory_20171_BackupDataSet;
            // 
            // cDInventory_20171_BackupDataSet
            // 
            this.cDInventory_20171_BackupDataSet.DataSetName = "CDInventory_20171_BackupDataSet";
            this.cDInventory_20171_BackupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userInfoLabel
            // 
            this.userInfoLabel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.userInfoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userInfoLabel.Location = new System.Drawing.Point(6, 16);
            this.userInfoLabel.Name = "userInfoLabel";
            this.userInfoLabel.Size = new System.Drawing.Size(223, 76);
            this.userInfoLabel.TabIndex = 1;
            // 
            // resultsGroupBox
            // 
            this.resultsGroupBox.Controls.Add(this.userInfoLabel);
            this.resultsGroupBox.Location = new System.Drawing.Point(405, 302);
            this.resultsGroupBox.Name = "resultsGroupBox";
            this.resultsGroupBox.Size = new System.Drawing.Size(235, 100);
            this.resultsGroupBox.TabIndex = 6;
            this.resultsGroupBox.TabStop = false;
            this.resultsGroupBox.Text = "User Information";
            // 
            // fillByWindSpeedToolStrip
            // 
            this.fillByWindSpeedToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.windspeedToolStripLabel,
            this.windspeedToolStripTextBox,
            this.fillByWindSpeedToolStripButton});
            this.fillByWindSpeedToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByWindSpeedToolStrip.Name = "fillByWindSpeedToolStrip";
            this.fillByWindSpeedToolStrip.Size = new System.Drawing.Size(1130, 25);
            this.fillByWindSpeedToolStrip.TabIndex = 1;
            this.fillByWindSpeedToolStrip.Text = "fillByWindSpeedToolStrip";
            // 
            // windspeedToolStripLabel
            // 
            this.windspeedToolStripLabel.Name = "windspeedToolStripLabel";
            this.windspeedToolStripLabel.Size = new System.Drawing.Size(99, 22);
            this.windspeedToolStripLabel.Text = "Enter Windspeed:";
            // 
            // windspeedToolStripTextBox
            // 
            this.windspeedToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.windspeedToolStripTextBox.Name = "windspeedToolStripTextBox";
            this.windspeedToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillByWindSpeedToolStripButton
            // 
            this.fillByWindSpeedToolStripButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.fillByWindSpeedToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByWindSpeedToolStripButton.Name = "fillByWindSpeedToolStripButton";
            this.fillByWindSpeedToolStripButton.Size = new System.Drawing.Size(46, 22);
            this.fillByWindSpeedToolStripButton.Text = "Search";
            this.fillByWindSpeedToolStripButton.Click += new System.EventHandler(this.fillByWindSpeedToolStripButton_Click);
            // 
            // fillByStormIDToolStrip
            // 
            this.fillByStormIDToolStrip.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.fillByStormIDToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.fillByStormIDToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stormIDToolStripLabel,
            this.stormIDToolStripTextBox,
            this.fillByStormIDToolStripButton});
            this.fillByStormIDToolStrip.Location = new System.Drawing.Point(461, 0);
            this.fillByStormIDToolStrip.Name = "fillByStormIDToolStrip";
            this.fillByStormIDToolStrip.Size = new System.Drawing.Size(243, 25);
            this.fillByStormIDToolStrip.TabIndex = 2;
            this.fillByStormIDToolStrip.Text = "fillByStormIDToolStrip";
            // 
            // stormIDToolStripLabel
            // 
            this.stormIDToolStripLabel.Name = "stormIDToolStripLabel";
            this.stormIDToolStripLabel.Size = new System.Drawing.Size(83, 22);
            this.stormIDToolStripLabel.Text = "Enter StormID:";
            // 
            // stormIDToolStripTextBox
            // 
            this.stormIDToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.stormIDToolStripTextBox.Name = "stormIDToolStripTextBox";
            this.stormIDToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillByStormIDToolStripButton
            // 
            this.fillByStormIDToolStripButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.fillByStormIDToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByStormIDToolStripButton.Name = "fillByStormIDToolStripButton";
            this.fillByStormIDToolStripButton.Size = new System.Drawing.Size(46, 22);
            this.fillByStormIDToolStripButton.Text = "Search";
            this.fillByStormIDToolStripButton.Click += new System.EventHandler(this.fillByStormIDToolStripButton_Click);
            // 
            // fillByAllStormDataToolStrip
            // 
            this.fillByAllStormDataToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.fillByAllStormDataToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByAllStormDataToolStripButton});
            this.fillByAllStormDataToolStrip.Location = new System.Drawing.Point(911, 0);
            this.fillByAllStormDataToolStrip.Name = "fillByAllStormDataToolStrip";
            this.fillByAllStormDataToolStrip.Size = new System.Drawing.Size(137, 25);
            this.fillByAllStormDataToolStrip.TabIndex = 3;
            this.fillByAllStormDataToolStrip.Text = "fillByAllStormDataToolStrip";
            // 
            // fillByAllStormDataToolStripButton
            // 
            this.fillByAllStormDataToolStripButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.fillByAllStormDataToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByAllStormDataToolStripButton.Name = "fillByAllStormDataToolStripButton";
            this.fillByAllStormDataToolStripButton.Size = new System.Drawing.Size(125, 22);
            this.fillByAllStormDataToolStripButton.Text = "Search All Storm Data";
            this.fillByAllStormDataToolStripButton.Click += new System.EventHandler(this.fillByAllStormDataToolStripButton_Click);
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
            // StormDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1130, 585);
            this.Controls.Add(this.fillByAllStormDataToolStrip);
            this.Controls.Add(this.fillByStormIDToolStrip);
            this.Controls.Add(this.fillByWindSpeedToolStrip);
            this.Controls.Add(this.resultsGroupBox);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.devCreditLabel);
            this.Controls.Add(this.logInTopLabel);
            this.DoubleBuffered = true;
            this.Name = "StormDataForm";
            this.Text = "Storm Data Form";
            this.Load += new System.EventHandler(this.StormDataForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storms2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDInventory_20171_BackupDataSet)).EndInit();
            this.resultsGroupBox.ResumeLayout(false);
            this.fillByWindSpeedToolStrip.ResumeLayout(false);
            this.fillByWindSpeedToolStrip.PerformLayout();
            this.fillByStormIDToolStrip.ResumeLayout(false);
            this.fillByStormIDToolStrip.PerformLayout();
            this.fillByAllStormDataToolStrip.ResumeLayout(false);
            this.fillByAllStormDataToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label logInTopLabel;
        private System.Windows.Forms.Label devCreditLabel;
        private CDInventory_20171_BackupDataSet cDInventory_20171_BackupDataSet;
        private System.Windows.Forms.BindingSource storms2BindingSource;
        private CDInventory_20171_BackupDataSetTableAdapters.Storms2TableAdapter storms2TableAdapter;
        private CDInventory_20171_BackupDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn stormDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stormTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn indicatorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stormStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn latDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn windspeedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pressureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stormIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label userInfoLabel;
        private System.Windows.Forms.GroupBox resultsGroupBox;
        private System.Windows.Forms.ToolStrip fillByWindSpeedToolStrip;
        private System.Windows.Forms.ToolStripLabel windspeedToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox windspeedToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByWindSpeedToolStripButton;
        private System.Windows.Forms.ToolStrip fillByStormIDToolStrip;
        private System.Windows.Forms.ToolStripLabel stormIDToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox stormIDToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByStormIDToolStripButton;
        private System.Windows.Forms.ToolStrip fillByAllStormDataToolStrip;
        private System.Windows.Forms.ToolStripButton fillByAllStormDataToolStripButton;
    }
}