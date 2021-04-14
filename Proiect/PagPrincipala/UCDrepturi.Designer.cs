namespace Proiect.PagPrincipala
{
    partial class UCDrepturi
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Membru");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Moderator");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Admin");
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.btAdaugaUtilizator = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.databaseDataSet = new Proiect.DatabaseDataSet();
            this.utilizatoriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.utilizatoriTableAdapter = new Proiect.DatabaseDataSetTableAdapters.UtilizatoriTableAdapter();
            this.tableAdapterManager = new Proiect.DatabaseDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilizatoriBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.AllowDrop = true;
            this.treeView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.treeView1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.ForeColor = System.Drawing.Color.White;
            this.treeView1.LineColor = System.Drawing.Color.White;
            this.treeView1.Location = new System.Drawing.Point(603, 34);
            this.treeView1.Name = "treeView1";
            treeNode1.ForeColor = System.Drawing.Color.Lime;
            treeNode1.Name = "Membru";
            treeNode1.Text = "Membru";
            treeNode2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            treeNode2.Name = "Moderator";
            treeNode2.Text = "Moderator";
            treeNode3.ForeColor = System.Drawing.Color.Red;
            treeNode3.Name = "Admin";
            treeNode3.Text = "Admin";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            this.treeView1.Size = new System.Drawing.Size(239, 193);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.DragEnter += new System.Windows.Forms.DragEventHandler(this.treeView1_DragEnter);
            // 
            // btAdaugaUtilizator
            // 
            this.btAdaugaUtilizator.BackColor = System.Drawing.Color.Transparent;
            this.btAdaugaUtilizator.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAdaugaUtilizator.FlatAppearance.BorderSize = 0;
            this.btAdaugaUtilizator.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cornsilk;
            this.btAdaugaUtilizator.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btAdaugaUtilizator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAdaugaUtilizator.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdaugaUtilizator.ForeColor = System.Drawing.Color.White;
            this.btAdaugaUtilizator.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btAdaugaUtilizator.Location = new System.Drawing.Point(602, 233);
            this.btAdaugaUtilizator.Name = "btAdaugaUtilizator";
            this.btAdaugaUtilizator.Size = new System.Drawing.Size(100, 40);
            this.btAdaugaUtilizator.TabIndex = 7;
            this.btAdaugaUtilizator.Text = "Refresh";
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
            this.button1.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(741, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 40);
            this.button1.TabIndex = 8;
            this.button1.Text = "Sterge";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(26, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(548, 58);
            this.label2.TabIndex = 9;
            this.label2.Text = "In lista din dreapta poti vedea si sterge numele \r\nutilizatorilor in functie de d" +
    "reptul de acces al lor";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(466, 299);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(418, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "Pentru a sterge selecteaza numele utilizatorului dorit.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            // UCDrepturi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proiect.Properties.Resources.UserControlSpate;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btAdaugaUtilizator);
            this.Controls.Add(this.treeView1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "UCDrepturi";
            this.Size = new System.Drawing.Size(884, 321);
            this.Load += new System.EventHandler(this.UCDrepturi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilizatoriBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button btAdaugaUtilizator;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource utilizatoriBindingSource;
        private DatabaseDataSetTableAdapters.UtilizatoriTableAdapter utilizatoriTableAdapter;
        private DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}
