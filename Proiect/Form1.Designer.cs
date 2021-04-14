namespace Proiect
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel3 = new System.Windows.Forms.Panel();
            this.databaseDataSet = new Proiect.DatabaseDataSet();
            this.utilizatoriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.utilizatoriTableAdapter = new Proiect.DatabaseDataSetTableAdapters.UtilizatoriTableAdapter();
            this.tableAdapterManager = new Proiect.DatabaseDataSetTableAdapters.TableAdapterManager();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btGrupuri = new System.Windows.Forms.Button();
            this.btDrepturi = new System.Windows.Forms.Button();
            this.btUtilizatori = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ucDataBase1 = new Proiect.PagPrincipala.UCDataBase();
            this.ucDesen1 = new Proiect.PagPrincipala.UCDesen();
            this.ucInceput = new Proiect.PagPrincipala.UCInceput();
            this.ucGrupuri = new Proiect.PagPrincipala.UCGrupuri();
            this.ucDrepturi1 = new Proiect.PagPrincipala.UCDrepturi();
            this.ucUtilizatori = new Proiect.PagPrincipala.UCUtilizatori();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilizatoriBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ucDataBase1);
            this.panel3.Controls.Add(this.ucDesen1);
            this.panel3.Controls.Add(this.ucInceput);
            this.panel3.Controls.Add(this.ucGrupuri);
            this.panel3.Controls.Add(this.ucDrepturi1);
            this.panel3.Controls.Add(this.ucUtilizatori);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 60);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(884, 321);
            this.panel3.TabIndex = 2;
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btGrupuri);
            this.panel2.Controls.Add(this.btDrepturi);
            this.panel2.Controls.Add(this.btUtilizatori);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 381);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(884, 100);
            this.panel2.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cornsilk;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::Proiect.Properties.Resources.database;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(629, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 100);
            this.button2.TabIndex = 4;
            this.button2.Text = "Database";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            this.button1.Image = global::Proiect.Properties.Resources.grafic;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(493, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 100);
            this.button1.TabIndex = 3;
            this.button1.Text = "Grafic";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btGrupuri
            // 
            this.btGrupuri.BackColor = System.Drawing.Color.Transparent;
            this.btGrupuri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btGrupuri.FlatAppearance.BorderSize = 0;
            this.btGrupuri.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cornsilk;
            this.btGrupuri.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btGrupuri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btGrupuri.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGrupuri.ForeColor = System.Drawing.Color.White;
            this.btGrupuri.Image = ((System.Drawing.Image)(resources.GetObject("btGrupuri.Image")));
            this.btGrupuri.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btGrupuri.Location = new System.Drawing.Point(357, 0);
            this.btGrupuri.Name = "btGrupuri";
            this.btGrupuri.Size = new System.Drawing.Size(130, 100);
            this.btGrupuri.TabIndex = 2;
            this.btGrupuri.Text = "Grupuri";
            this.btGrupuri.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btGrupuri.UseVisualStyleBackColor = false;
            this.btGrupuri.Click += new System.EventHandler(this.btGrupuri_Click);
            // 
            // btDrepturi
            // 
            this.btDrepturi.BackColor = System.Drawing.Color.Transparent;
            this.btDrepturi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btDrepturi.FlatAppearance.BorderSize = 0;
            this.btDrepturi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cornsilk;
            this.btDrepturi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btDrepturi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDrepturi.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDrepturi.ForeColor = System.Drawing.Color.White;
            this.btDrepturi.Image = ((System.Drawing.Image)(resources.GetObject("btDrepturi.Image")));
            this.btDrepturi.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btDrepturi.Location = new System.Drawing.Point(234, 0);
            this.btDrepturi.Name = "btDrepturi";
            this.btDrepturi.Size = new System.Drawing.Size(130, 100);
            this.btDrepturi.TabIndex = 1;
            this.btDrepturi.Text = "Drepturi";
            this.btDrepturi.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btDrepturi.UseVisualStyleBackColor = false;
            this.btDrepturi.Click += new System.EventHandler(this.btDrepturi_Click);
            // 
            // btUtilizatori
            // 
            this.btUtilizatori.BackColor = System.Drawing.Color.Transparent;
            this.btUtilizatori.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btUtilizatori.FlatAppearance.BorderSize = 0;
            this.btUtilizatori.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cornsilk;
            this.btUtilizatori.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btUtilizatori.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btUtilizatori.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUtilizatori.ForeColor = System.Drawing.Color.White;
            this.btUtilizatori.Image = ((System.Drawing.Image)(resources.GetObject("btUtilizatori.Image")));
            this.btUtilizatori.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btUtilizatori.Location = new System.Drawing.Point(111, 0);
            this.btUtilizatori.Name = "btUtilizatori";
            this.btUtilizatori.Size = new System.Drawing.Size(130, 100);
            this.btUtilizatori.TabIndex = 0;
            this.btUtilizatori.Text = "Utilizatori";
            this.btUtilizatori.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btUtilizatori.UseVisualStyleBackColor = false;
            this.btUtilizatori.Click += new System.EventHandler(this.btUtilizatori_Click);
            this.btUtilizatori.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btUtilizatori_KeyDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 60);
            this.panel1.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Simplifica", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(856, 7);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(25, 25);
            this.button4.TabIndex = 2;
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Azure;
            this.label1.Location = new System.Drawing.Point(68, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Retea Calculatoare";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Location = new System.Drawing.Point(12, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ucDataBase1
            // 
            this.ucDataBase1.BackColor = System.Drawing.Color.Transparent;
            this.ucDataBase1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucDataBase1.BackgroundImage")));
            this.ucDataBase1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucDataBase1.Location = new System.Drawing.Point(0, 0);
            this.ucDataBase1.Name = "ucDataBase1";
            this.ucDataBase1.Size = new System.Drawing.Size(884, 321);
            this.ucDataBase1.TabIndex = 5;
            this.ucDataBase1.Visible = false;
            // 
            // ucDesen1
            // 
            this.ucDesen1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucDesen1.BackgroundImage")));
            this.ucDesen1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucDesen1.Location = new System.Drawing.Point(0, 0);
            this.ucDesen1.Name = "ucDesen1";
            this.ucDesen1.Size = new System.Drawing.Size(884, 321);
            this.ucDesen1.TabIndex = 4;
            this.ucDesen1.Visible = false;
            // 
            // ucInceput
            // 
            this.ucInceput.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucInceput.BackgroundImage")));
            this.ucInceput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucInceput.Location = new System.Drawing.Point(0, 0);
            this.ucInceput.Name = "ucInceput";
            this.ucInceput.Size = new System.Drawing.Size(884, 321);
            this.ucInceput.TabIndex = 3;
            // 
            // ucGrupuri
            // 
            this.ucGrupuri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucGrupuri.BackgroundImage")));
            this.ucGrupuri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucGrupuri.Location = new System.Drawing.Point(0, 0);
            this.ucGrupuri.Name = "ucGrupuri";
            this.ucGrupuri.Size = new System.Drawing.Size(884, 321);
            this.ucGrupuri.TabIndex = 2;
            this.ucGrupuri.Visible = false;
            this.ucGrupuri.Load += new System.EventHandler(this.ucGrupuri_Load);
            // 
            // ucDrepturi1
            // 
            this.ucDrepturi1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucDrepturi1.BackgroundImage")));
            this.ucDrepturi1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucDrepturi1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ucDrepturi1.Location = new System.Drawing.Point(0, 0);
            this.ucDrepturi1.Name = "ucDrepturi1";
            this.ucDrepturi1.Size = new System.Drawing.Size(884, 321);
            this.ucDrepturi1.TabIndex = 1;
            this.ucDrepturi1.Visible = false;
            // 
            // ucUtilizatori
            // 
            this.ucUtilizatori.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ucUtilizatori.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucUtilizatori.BackgroundImage")));
            this.ucUtilizatori.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucUtilizatori.Location = new System.Drawing.Point(0, 0);
            this.ucUtilizatori.Name = "ucUtilizatori";
            this.ucUtilizatori.Size = new System.Drawing.Size(884, 321);
            this.ucUtilizatori.TabIndex = 0;
            this.ucUtilizatori.Visible = false;
            this.ucUtilizatori.Load += new System.EventHandler(this.ucUtilizatori_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 481);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilizatoriBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btUtilizatori;
        private System.Windows.Forms.Button btDrepturi;
        private System.Windows.Forms.Button btGrupuri;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel3;
        private PagPrincipala.UCUtilizatori ucUtilizatori;
        private PagPrincipala.UCDrepturi ucDrepturi1;
        private PagPrincipala.UCGrupuri ucGrupuri;
        private PagPrincipala.UCInceput ucInceput;
        private System.Windows.Forms.Button button1;
        private PagPrincipala.UCDesen ucDesen1;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource utilizatoriBindingSource;
        private DatabaseDataSetTableAdapters.UtilizatoriTableAdapter utilizatoriTableAdapter;
        private DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private PagPrincipala.UCDataBase ucDataBase1;
        private System.Windows.Forms.Button button2;
    }
}

