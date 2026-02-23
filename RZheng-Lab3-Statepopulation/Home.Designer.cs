namespace RZheng_Lab3_Statepopulation
{
    partial class Home
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
            System.Windows.Forms.Label stateNameLabel;
            this.ViewDetailsBtn = new System.Windows.Forms.Button();
            this.seeDatabaseBtn = new System.Windows.Forms.Button();
            this.stateNameComboBox = new System.Windows.Forms.ComboBox();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new RZheng_Lab3_Statepopulation.Database1DataSet();
            this.tableTableAdapter = new RZheng_Lab3_Statepopulation.Database1DataSetTableAdapters.TableTableAdapter();
            this.tableAdapterManager = new RZheng_Lab3_Statepopulation.Database1DataSetTableAdapters.TableAdapterManager();
            stateNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // ViewDetailsBtn
            // 
            this.ViewDetailsBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.ViewDetailsBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewDetailsBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ViewDetailsBtn.Location = new System.Drawing.Point(125, 168);
            this.ViewDetailsBtn.Name = "ViewDetailsBtn";
            this.ViewDetailsBtn.Size = new System.Drawing.Size(208, 61);
            this.ViewDetailsBtn.TabIndex = 2;
            this.ViewDetailsBtn.Text = "&View Detail";
            this.ViewDetailsBtn.UseVisualStyleBackColor = false;
            this.ViewDetailsBtn.Click += new System.EventHandler(this.ViewDetailsBtn_Click);
            // 
            // seeDatabaseBtn
            // 
            this.seeDatabaseBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.seeDatabaseBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seeDatabaseBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.seeDatabaseBtn.Location = new System.Drawing.Point(476, 168);
            this.seeDatabaseBtn.Name = "seeDatabaseBtn";
            this.seeDatabaseBtn.Size = new System.Drawing.Size(217, 61);
            this.seeDatabaseBtn.TabIndex = 3;
            this.seeDatabaseBtn.Text = "&See Database";
            this.seeDatabaseBtn.UseVisualStyleBackColor = false;
            this.seeDatabaseBtn.Click += new System.EventHandler(this.seeDatabaseBtn_Click);
            // 
            // stateNameLabel
            // 
            stateNameLabel.AutoSize = true;
            stateNameLabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            stateNameLabel.Location = new System.Drawing.Point(120, 106);
            stateNameLabel.Name = "stateNameLabel";
            stateNameLabel.Size = new System.Drawing.Size(131, 26);
            stateNameLabel.TabIndex = 4;
            stateNameLabel.Text = "Select State";
            // 
            // stateNameComboBox
            // 
            this.stateNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "StateName", true));
            this.stateNameComboBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateNameComboBox.FormattingEnabled = true;
            this.stateNameComboBox.Location = new System.Drawing.Point(257, 106);
            this.stateNameComboBox.Name = "stateNameComboBox";
            this.stateNameComboBox.Size = new System.Drawing.Size(436, 30);
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TableTableAdapter = this.tableTableAdapter;
            this.tableAdapterManager.UpdateOrder = RZheng_Lab3_Statepopulation.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(792, 360);
            this.Controls.Add(stateNameLabel);
            this.Controls.Add(this.stateNameComboBox);
            this.Controls.Add(this.seeDatabaseBtn);
            this.Controls.Add(this.ViewDetailsBtn);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "State Population";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ViewDetailsBtn;
        private System.Windows.Forms.Button seeDatabaseBtn;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private Database1DataSetTableAdapters.TableTableAdapter tableTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox stateNameComboBox;
    }
}

