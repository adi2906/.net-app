namespace Proiect.PagPrincipala
{
    partial class UCDataBase
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label numeLabel;
            System.Windows.Forms.Label varstaLabel;
            System.Windows.Forms.Label cNPLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCDataBase));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.databaseDataSet = new Proiect.DatabaseDataSet();
            this.utilizatoriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.utilizatoriTableAdapter = new Proiect.DatabaseDataSetTableAdapters.UtilizatoriTableAdapter();
            this.tableAdapterManager = new Proiect.DatabaseDataSetTableAdapters.TableAdapterManager();
            this.utilizatoriBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.utilizatoriBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.numeTextBox = new System.Windows.Forms.TextBox();
            this.varstaTextBox = new System.Windows.Forms.TextBox();
            this.cNPTextBox = new System.Windows.Forms.TextBox();
            this.utilizatoriDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btAdaugaUtilizator = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            numeLabel = new System.Windows.Forms.Label();
            varstaLabel = new System.Windows.Forms.Label();
            cNPLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilizatoriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilizatoriBindingNavigator)).BeginInit();
            this.utilizatoriBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.utilizatoriDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // numeLabel
            // 
            numeLabel.AutoSize = true;
            numeLabel.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            numeLabel.ForeColor = System.Drawing.Color.White;
            numeLabel.Location = new System.Drawing.Point(26, 102);
            numeLabel.Name = "numeLabel";
            numeLabel.Size = new System.Drawing.Size(76, 27);
            numeLabel.TabIndex = 3;
            numeLabel.Text = "Nume:";
            // 
            // varstaLabel
            // 
            varstaLabel.AutoSize = true;
            varstaLabel.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            varstaLabel.ForeColor = System.Drawing.Color.White;
            varstaLabel.Location = new System.Drawing.Point(26, 151);
            varstaLabel.Name = "varstaLabel";
            varstaLabel.Size = new System.Drawing.Size(80, 27);
            varstaLabel.TabIndex = 5;
            varstaLabel.Text = "Varsta:";
            // 
            // cNPLabel
            // 
            cNPLabel.AutoSize = true;
            cNPLabel.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cNPLabel.ForeColor = System.Drawing.Color.White;
            cNPLabel.Location = new System.Drawing.Point(26, 199);
            cNPLabel.Name = "cNPLabel";
            cNPLabel.Size = new System.Drawing.Size(59, 27);
            cNPLabel.TabIndex = 7;
            cNPLabel.Text = "CNP:";
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // utilizatoriBindingSource
            // 
            this.utilizatoriBindingSource.DataMember = "Utilizatori";
            this.utilizatoriBindingSource.DataSource = this.databaseDataSet;
            // 
            // utilizatoriTableAdapter
            // 
            this.utilizatoriTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Proiect.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UtilizatoriTableAdapter = this.utilizatoriTableAdapter;
            // 
            // utilizatoriBindingNavigator
            // 
            this.utilizatoriBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.utilizatoriBindingNavigator.BindingSource = this.utilizatoriBindingSource;
            this.utilizatoriBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.utilizatoriBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.utilizatoriBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.utilizatoriBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.utilizatoriBindingNavigatorSaveItem});
            this.utilizatoriBindingNavigator.Location = new System.Drawing.Point(423, 42);
            this.utilizatoriBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.utilizatoriBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.utilizatoriBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.utilizatoriBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.utilizatoriBindingNavigator.Name = "utilizatoriBindingNavigator";
            this.utilizatoriBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.utilizatoriBindingNavigator.Size = new System.Drawing.Size(278, 25);
            this.utilizatoriBindingNavigator.TabIndex = 0;
            this.utilizatoriBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
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
            // utilizatoriBindingNavigatorSaveItem
            // 
            this.utilizatoriBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.utilizatoriBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("utilizatoriBindingNavigatorSaveItem.Image")));
            this.utilizatoriBindingNavigatorSaveItem.Name = "utilizatoriBindingNavigatorSaveItem";
            this.utilizatoriBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.utilizatoriBindingNavigatorSaveItem.Text = "Save Data";
            this.utilizatoriBindingNavigatorSaveItem.Click += new System.EventHandler(this.utilizatoriBindingNavigatorSaveItem_Click);
            // 
            // numeTextBox
            // 
            this.numeTextBox.BackColor = System.Drawing.Color.MidnightBlue;
            this.numeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.utilizatoriBindingSource, "Nume", true));
            this.numeTextBox.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeTextBox.ForeColor = System.Drawing.Color.White;
            this.numeTextBox.Location = new System.Drawing.Point(143, 102);
            this.numeTextBox.Name = "numeTextBox";
            this.numeTextBox.Size = new System.Drawing.Size(100, 23);
            this.numeTextBox.TabIndex = 4;
            // 
            // varstaTextBox
            // 
            this.varstaTextBox.BackColor = System.Drawing.Color.MidnightBlue;
            this.varstaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.utilizatoriBindingSource, "Varsta", true));
            this.varstaTextBox.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.varstaTextBox.ForeColor = System.Drawing.Color.White;
            this.varstaTextBox.Location = new System.Drawing.Point(143, 151);
            this.varstaTextBox.Name = "varstaTextBox";
            this.varstaTextBox.Size = new System.Drawing.Size(100, 23);
            this.varstaTextBox.TabIndex = 6;
            // 
            // cNPTextBox
            // 
            this.cNPTextBox.BackColor = System.Drawing.Color.MidnightBlue;
            this.cNPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.utilizatoriBindingSource, "CNP", true));
            this.cNPTextBox.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cNPTextBox.ForeColor = System.Drawing.Color.White;
            this.cNPTextBox.Location = new System.Drawing.Point(143, 199);
            this.cNPTextBox.Name = "cNPTextBox";
            this.cNPTextBox.Size = new System.Drawing.Size(100, 23);
            this.cNPTextBox.TabIndex = 8;
            // 
            // utilizatoriDataGridView
            // 
            this.utilizatoriDataGridView.AutoGenerateColumns = false;
            this.utilizatoriDataGridView.BackgroundColor = System.Drawing.Color.MidnightBlue;
            this.utilizatoriDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.utilizatoriDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.utilizatoriDataGridView.DataSource = this.utilizatoriBindingSource;
            this.utilizatoriDataGridView.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.utilizatoriDataGridView.Location = new System.Drawing.Point(423, 70);
            this.utilizatoriDataGridView.Name = "utilizatoriDataGridView";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.utilizatoriDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.utilizatoriDataGridView.Size = new System.Drawing.Size(446, 189);
            this.utilizatoriDataGridView.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nume";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nume";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Varsta";
            this.dataGridViewTextBoxColumn3.HeaderText = "Varsta";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CNP";
            this.dataGridViewTextBoxColumn4.HeaderText = "CNP";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // btAdaugaUtilizator
            // 
            this.btAdaugaUtilizator.BackColor = System.Drawing.Color.Transparent;
            this.btAdaugaUtilizator.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAdaugaUtilizator.FlatAppearance.BorderSize = 0;
            this.btAdaugaUtilizator.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cornsilk;
            this.btAdaugaUtilizator.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btAdaugaUtilizator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAdaugaUtilizator.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdaugaUtilizator.ForeColor = System.Drawing.Color.White;
            this.btAdaugaUtilizator.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btAdaugaUtilizator.Location = new System.Drawing.Point(5, 265);
            this.btAdaugaUtilizator.Name = "btAdaugaUtilizator";
            this.btAdaugaUtilizator.Size = new System.Drawing.Size(195, 33);
            this.btAdaugaUtilizator.TabIndex = 10;
            this.btAdaugaUtilizator.Text = "Adauga Utilizator";
            this.btAdaugaUtilizator.UseVisualStyleBackColor = false;
            this.btAdaugaUtilizator.Click += new System.EventHandler(this.btAdaugaUtilizator_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cornsilk;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(206, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 33);
            this.button1.TabIndex = 11;
            this.button1.Text = "Sterge Utilizator";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cornsilk;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Aquamarine;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(423, 265);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(446, 33);
            this.button2.TabIndex = 12;
            this.button2.Text = "Click pentru a adauga date deja existente din fisier";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(408, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(460, 18);
            this.label6.TabIndex = 20;
            this.label6.Text = "(preia informatii din fisierul DateUtilizatori.txt si le incarca in baza de date)" +
    "";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 24);
            this.label1.TabIndex = 21;
            this.label1.Text = "Adauga un utilizator nou in baza de date:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // UCDataBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::Proiect.Properties.Resources.UserControlSpate;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btAdaugaUtilizator);
            this.Controls.Add(this.utilizatoriDataGridView);
            this.Controls.Add(numeLabel);
            this.Controls.Add(this.numeTextBox);
            this.Controls.Add(varstaLabel);
            this.Controls.Add(this.varstaTextBox);
            this.Controls.Add(cNPLabel);
            this.Controls.Add(this.cNPTextBox);
            this.Controls.Add(this.utilizatoriBindingNavigator);
            this.Name = "UCDataBase";
            this.Size = new System.Drawing.Size(884, 359);
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilizatoriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilizatoriBindingNavigator)).EndInit();
            this.utilizatoriBindingNavigator.ResumeLayout(false);
            this.utilizatoriBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.utilizatoriDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource utilizatoriBindingSource;
        private DatabaseDataSetTableAdapters.UtilizatoriTableAdapter utilizatoriTableAdapter;
        private DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator utilizatoriBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton utilizatoriBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox numeTextBox;
        private System.Windows.Forms.TextBox varstaTextBox;
        private System.Windows.Forms.TextBox cNPTextBox;
        private System.Windows.Forms.DataGridView utilizatoriDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button btAdaugaUtilizator;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
    }
}
