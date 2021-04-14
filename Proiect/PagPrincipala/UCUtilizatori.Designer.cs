namespace Proiect.PagPrincipala
{
    partial class UCUtilizatori
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCUtilizatori));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbGrup = new System.Windows.Forms.ComboBox();
            this.cbDrept = new System.Windows.Forms.ComboBox();
            this.tbCnp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbVarsta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNume = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btAdaugaUtilizator = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Nume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Varsta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cnp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.btPrint = new System.Windows.Forms.Button();
            this.btPrintPreview = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.button3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cbGrup);
            this.panel1.Controls.Add(this.cbDrept);
            this.panel1.Controls.Add(this.tbCnp);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tbVarsta);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbNume);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btAdaugaUtilizator);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(295, 321);
            this.panel1.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(21, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 24);
            this.label5.TabIndex = 17;
            this.label5.Text = "Grup:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(14, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 24);
            this.label4.TabIndex = 16;
            this.label4.Text = "Drept:";
            // 
            // cbGrup
            // 
            this.cbGrup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cbGrup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGrup.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGrup.ForeColor = System.Drawing.Color.White;
            this.cbGrup.FormattingEnabled = true;
            this.cbGrup.Items.AddRange(new object[] {
            "Membri",
            "STAFF"});
            this.cbGrup.Location = new System.Drawing.Point(87, 207);
            this.cbGrup.Name = "cbGrup";
            this.cbGrup.Size = new System.Drawing.Size(146, 26);
            this.cbGrup.TabIndex = 15;
            this.cbGrup.SelectedIndexChanged += new System.EventHandler(this.cbGrup_SelectedIndexChanged);
            // 
            // cbDrept
            // 
            this.cbDrept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cbDrept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDrept.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDrept.ForeColor = System.Drawing.Color.White;
            this.cbDrept.FormattingEnabled = true;
            this.cbDrept.Items.AddRange(new object[] {
            "Membru",
            "Moderator",
            "Admin"});
            this.cbDrept.Location = new System.Drawing.Point(87, 161);
            this.cbDrept.Name = "cbDrept";
            this.cbDrept.Size = new System.Drawing.Size(146, 26);
            this.cbDrept.TabIndex = 14;
            this.cbDrept.SelectedIndexChanged += new System.EventHandler(this.cbDrept_SelectedIndexChanged);
            // 
            // tbCnp
            // 
            this.tbCnp.BackColor = System.Drawing.Color.MidnightBlue;
            this.tbCnp.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCnp.ForeColor = System.Drawing.Color.White;
            this.tbCnp.Location = new System.Drawing.Point(87, 116);
            this.tbCnp.Name = "tbCnp";
            this.tbCnp.Size = new System.Drawing.Size(146, 26);
            this.tbCnp.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(28, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "CNP:";
            // 
            // tbVarsta
            // 
            this.tbVarsta.BackColor = System.Drawing.Color.MidnightBlue;
            this.tbVarsta.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVarsta.ForeColor = System.Drawing.Color.White;
            this.tbVarsta.Location = new System.Drawing.Point(87, 72);
            this.tbVarsta.Name = "tbVarsta";
            this.tbVarsta.Size = new System.Drawing.Size(146, 26);
            this.tbVarsta.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Varsta:";
            // 
            // tbNume
            // 
            this.tbNume.BackColor = System.Drawing.Color.MidnightBlue;
            this.tbNume.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNume.ForeColor = System.Drawing.Color.White;
            this.tbNume.Location = new System.Drawing.Point(87, 30);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(146, 26);
            this.tbNume.TabIndex = 9;
            this.tbNume.TextChanged += new System.EventHandler(this.tbNume_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nume:";
            // 
            // btAdaugaUtilizator
            // 
            this.btAdaugaUtilizator.BackColor = System.Drawing.Color.Transparent;
            this.btAdaugaUtilizator.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAdaugaUtilizator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btAdaugaUtilizator.FlatAppearance.BorderSize = 0;
            this.btAdaugaUtilizator.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cornsilk;
            this.btAdaugaUtilizator.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btAdaugaUtilizator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAdaugaUtilizator.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdaugaUtilizator.ForeColor = System.Drawing.Color.White;
            this.btAdaugaUtilizator.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btAdaugaUtilizator.Location = new System.Drawing.Point(0, 277);
            this.btAdaugaUtilizator.Name = "btAdaugaUtilizator";
            this.btAdaugaUtilizator.Size = new System.Drawing.Size(295, 44);
            this.btAdaugaUtilizator.TabIndex = 6;
            this.btAdaugaUtilizator.Text = "Adauga Utilizator";
            this.btAdaugaUtilizator.UseVisualStyleBackColor = false;
            this.btAdaugaUtilizator.Click += new System.EventHandler(this.btAdaugaUtilizator_Click);
            this.btAdaugaUtilizator.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btAdaugaUtilizator_KeyDown);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.MidnightBlue;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nume,
            this.Varsta,
            this.Cnp});
            this.listView1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.ForeColor = System.Drawing.Color.White;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(540, 30);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(341, 194);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Nume
            // 
            this.Nume.Text = "Nume";
            this.Nume.Width = 116;
            // 
            // Varsta
            // 
            this.Varsta.Text = "Varsta";
            this.Varsta.Width = 88;
            // 
            // Cnp
            // 
            this.Cnp.Text = "CNP";
            this.Cnp.Width = 209;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cornsilk;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(751, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 29);
            this.button1.TabIndex = 7;
            this.button1.Text = "Arata Lista";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // btPrint
            // 
            this.btPrint.BackColor = System.Drawing.Color.Transparent;
            this.btPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btPrint.FlatAppearance.BorderSize = 0;
            this.btPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cornsilk;
            this.btPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPrint.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPrint.ForeColor = System.Drawing.Color.White;
            this.btPrint.Image = global::Proiect.Properties.Resources.PrintButton1;
            this.btPrint.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btPrint.Location = new System.Drawing.Point(540, 230);
            this.btPrint.Name = "btPrint";
            this.btPrint.Size = new System.Drawing.Size(106, 54);
            this.btPrint.TabIndex = 8;
            this.btPrint.Text = "Print";
            this.btPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btPrint.UseVisualStyleBackColor = false;
            this.btPrint.Click += new System.EventHandler(this.btPrint_Click);
            // 
            // btPrintPreview
            // 
            this.btPrintPreview.BackColor = System.Drawing.Color.Transparent;
            this.btPrintPreview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btPrintPreview.FlatAppearance.BorderSize = 0;
            this.btPrintPreview.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cornsilk;
            this.btPrintPreview.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btPrintPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPrintPreview.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPrintPreview.ForeColor = System.Drawing.Color.White;
            this.btPrintPreview.Image = global::Proiect.Properties.Resources.PrintPreview11;
            this.btPrintPreview.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btPrintPreview.Location = new System.Drawing.Point(652, 230);
            this.btPrintPreview.Name = "btPrintPreview";
            this.btPrintPreview.Size = new System.Drawing.Size(101, 54);
            this.btPrintPreview.TabIndex = 9;
            this.btPrintPreview.Text = "Print Preview";
            this.btPrintPreview.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btPrintPreview.UseVisualStyleBackColor = false;
            this.btPrintPreview.Click += new System.EventHandler(this.btPrintPreview_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cornsilk;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.Location = new System.Drawing.Point(350, 136);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 40);
            this.button3.TabIndex = 29;
            this.button3.Text = "Adauga Grup";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(317, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(212, 27);
            this.label7.TabIndex = 28;
            this.label7.Text = "Adauga un grup nou:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.MidnightBlue;
            this.textBox1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(410, 84);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(119, 30);
            this.textBox1.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(301, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 24);
            this.label8.TabIndex = 26;
            this.label8.Text = "Denumire:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // UCUtilizatori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::Proiect.Properties.Resources.UserControlSpate;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btPrintPreview);
            this.Controls.Add(this.btPrint);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panel1);
            this.Name = "UCUtilizatori";
            this.Size = new System.Drawing.Size(884, 321);
            this.Load += new System.EventHandler(this.UCUtilizatori_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UCUtilizatori_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btAdaugaUtilizator;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.TextBox tbVarsta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Nume;
        private System.Windows.Forms.ColumnHeader Varsta;
        private System.Windows.Forms.TextBox tbCnp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader Cnp;
        private System.Windows.Forms.ComboBox cbDrept;
        private System.Windows.Forms.ComboBox cbGrup;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button btPrint;
        private System.Windows.Forms.Button btPrintPreview;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
