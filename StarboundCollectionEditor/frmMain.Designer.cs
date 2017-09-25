namespace StarboundCollectionEditor
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tvCollection = new System.Windows.Forms.TreeView();
            this.btnExport = new MetroFramework.Controls.MetroButton();
            this.ofdCollection = new System.Windows.Forms.OpenFileDialog();
            this.btnBrowse = new MetroFramework.Controls.MetroButton();
            this.lblSelect = new MetroFramework.Controls.MetroLabel();
            this.txtCollectable = new MetroFramework.Controls.MetroTextBox();
            this.btnAddCollectable = new MetroFramework.Controls.MetroButton();
            this.label2 = new MetroFramework.Controls.MetroLabel();
            this.label3 = new MetroFramework.Controls.MetroLabel();
            this.label4 = new MetroFramework.Controls.MetroLabel();
            this.txtName = new MetroFramework.Controls.MetroTextBox();
            this.txtTitle = new MetroFramework.Controls.MetroTextBox();
            this.txtType = new MetroFramework.Controls.MetroTextBox();
            this.label5 = new MetroFramework.Controls.MetroLabel();
            this.btnPatches = new MetroFramework.Controls.MetroButton();
            this.ofdBaseCollection = new System.Windows.Forms.OpenFileDialog();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // tvCollection
            // 
            this.tvCollection.Location = new System.Drawing.Point(23, 138);
            this.tvCollection.Name = "tvCollection";
            this.tvCollection.Size = new System.Drawing.Size(676, 395);
            this.tvCollection.TabIndex = 0;
            this.tvCollection.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tvCollection_KeyPress);
            // 
            // btnExport
            // 
            this.btnExport.Enabled = false;
            this.btnExport.Location = new System.Drawing.Point(599, 542);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(100, 23);
            this.btnExport.TabIndex = 1;
            this.btnExport.Text = "Export Collection";
            this.btnExport.UseSelectable = true;
            this.btnExport.UseStyleColors = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(599, 63);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(100, 23);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseSelectable = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Location = new System.Drawing.Point(23, 60);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(187, 19);
            this.lblSelect.TabIndex = 3;
            this.lblSelect.Text = "Select a collection file to begin";
            this.lblSelect.UseStyleColors = true;
            // 
            // txtCollectable
            // 
            // 
            // 
            // 
            this.txtCollectable.CustomButton.Image = null;
            this.txtCollectable.CustomButton.Location = new System.Drawing.Point(64, 2);
            this.txtCollectable.CustomButton.Name = "";
            this.txtCollectable.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txtCollectable.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCollectable.CustomButton.TabIndex = 1;
            this.txtCollectable.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCollectable.CustomButton.UseSelectable = true;
            this.txtCollectable.CustomButton.Visible = false;
            this.txtCollectable.Lines = new string[0];
            this.txtCollectable.Location = new System.Drawing.Point(78, 542);
            this.txtCollectable.MaxLength = 32767;
            this.txtCollectable.Name = "txtCollectable";
            this.txtCollectable.PasswordChar = '\0';
            this.txtCollectable.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCollectable.SelectedText = "";
            this.txtCollectable.SelectionLength = 0;
            this.txtCollectable.SelectionStart = 0;
            this.txtCollectable.ShortcutsEnabled = true;
            this.txtCollectable.Size = new System.Drawing.Size(82, 20);
            this.txtCollectable.TabIndex = 4;
            this.txtCollectable.UseSelectable = true;
            this.txtCollectable.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCollectable.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnAddCollectable
            // 
            this.btnAddCollectable.Enabled = false;
            this.btnAddCollectable.Location = new System.Drawing.Point(432, 542);
            this.btnAddCollectable.Name = "btnAddCollectable";
            this.btnAddCollectable.Size = new System.Drawing.Size(43, 23);
            this.btnAddCollectable.TabIndex = 5;
            this.btnAddCollectable.Text = "Add";
            this.btnAddCollectable.UseSelectable = true;
            this.btnAddCollectable.Click += new System.EventHandler(this.btnAddCollectable_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(292, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Title";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(522, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Type";
            // 
            // txtName
            // 
            // 
            // 
            // 
            this.txtName.CustomButton.Image = null;
            this.txtName.CustomButton.Location = new System.Drawing.Point(113, 2);
            this.txtName.CustomButton.Name = "";
            this.txtName.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txtName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtName.CustomButton.TabIndex = 1;
            this.txtName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtName.CustomButton.UseSelectable = true;
            this.txtName.CustomButton.Visible = false;
            this.txtName.Lines = new string[0];
            this.txtName.Location = new System.Drawing.Point(78, 102);
            this.txtName.MaxLength = 32767;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.ShortcutsEnabled = true;
            this.txtName.Size = new System.Drawing.Size(131, 20);
            this.txtName.TabIndex = 9;
            this.txtName.UseSelectable = true;
            this.txtName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtTitle
            // 
            // 
            // 
            // 
            this.txtTitle.CustomButton.Image = null;
            this.txtTitle.CustomButton.Location = new System.Drawing.Point(100, 2);
            this.txtTitle.CustomButton.Name = "";
            this.txtTitle.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txtTitle.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTitle.CustomButton.TabIndex = 1;
            this.txtTitle.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTitle.CustomButton.UseSelectable = true;
            this.txtTitle.CustomButton.Visible = false;
            this.txtTitle.Lines = new string[0];
            this.txtTitle.Location = new System.Drawing.Point(331, 101);
            this.txtTitle.MaxLength = 32767;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.PasswordChar = '\0';
            this.txtTitle.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTitle.SelectedText = "";
            this.txtTitle.SelectionLength = 0;
            this.txtTitle.SelectionStart = 0;
            this.txtTitle.ShortcutsEnabled = true;
            this.txtTitle.Size = new System.Drawing.Size(118, 20);
            this.txtTitle.TabIndex = 10;
            this.txtTitle.UseSelectable = true;
            this.txtTitle.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTitle.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtType
            // 
            // 
            // 
            // 
            this.txtType.CustomButton.Image = null;
            this.txtType.CustomButton.Location = new System.Drawing.Point(119, 2);
            this.txtType.CustomButton.Name = "";
            this.txtType.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txtType.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtType.CustomButton.TabIndex = 1;
            this.txtType.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtType.CustomButton.UseSelectable = true;
            this.txtType.CustomButton.Visible = false;
            this.txtType.Lines = new string[0];
            this.txtType.Location = new System.Drawing.Point(562, 102);
            this.txtType.MaxLength = 32767;
            this.txtType.Name = "txtType";
            this.txtType.PasswordChar = '\0';
            this.txtType.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtType.SelectedText = "";
            this.txtType.SelectionLength = 0;
            this.txtType.SelectionStart = 0;
            this.txtType.ShortcutsEnabled = true;
            this.txtType.Size = new System.Drawing.Size(137, 20);
            this.txtType.TabIndex = 11;
            this.txtType.UseSelectable = true;
            this.txtType.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtType.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 543);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "ItemID";
            // 
            // btnPatches
            // 
            this.btnPatches.Enabled = false;
            this.btnPatches.Location = new System.Drawing.Point(493, 542);
            this.btnPatches.Name = "btnPatches";
            this.btnPatches.Size = new System.Drawing.Size(100, 23);
            this.btnPatches.TabIndex = 13;
            this.btnPatches.Text = "Make Patches";
            this.btnPatches.UseSelectable = true;
            this.btnPatches.Click += new System.EventHandler(this.btnPatches_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(175, 543);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(34, 19);
            this.metroLabel1.TabIndex = 15;
            this.metroLabel1.Text = "Path";
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(182, 2);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(226, 542);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(200, 20);
            this.metroTextBox1.TabIndex = 14;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackImage = ((System.Drawing.Image)(resources.GetObject("$this.BackImage")));
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(722, 579);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.btnPatches);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddCollectable);
            this.Controls.Add(this.txtCollectable);
            this.Controls.Add(this.lblSelect);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.tvCollection);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "Starbound Collections Editor";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tvCollection;
        private MetroFramework.Controls.MetroButton btnExport;
        private System.Windows.Forms.OpenFileDialog ofdCollection;
        private MetroFramework.Controls.MetroButton btnBrowse;
        private MetroFramework.Controls.MetroLabel lblSelect;
        private MetroFramework.Controls.MetroTextBox txtCollectable;
        private MetroFramework.Controls.MetroButton btnAddCollectable;
        private MetroFramework.Controls.MetroLabel label2;
        private MetroFramework.Controls.MetroLabel label3;
        private MetroFramework.Controls.MetroLabel label4;
        private MetroFramework.Controls.MetroTextBox txtName;
        private MetroFramework.Controls.MetroTextBox txtTitle;
        private MetroFramework.Controls.MetroTextBox txtType;
        private MetroFramework.Controls.MetroLabel label5;
        private MetroFramework.Controls.MetroButton btnPatches;
        private System.Windows.Forms.OpenFileDialog ofdBaseCollection;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
    }
}

