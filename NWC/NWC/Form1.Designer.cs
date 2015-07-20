namespace NWC
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
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.lstReferences = new System.Windows.Forms.ListBox();
			this.edtSearch = new WatermarkTextBox.WatermarkTextBox();
			this.tabs = new System.Windows.Forms.TabControl();
			this.tabAdmin = new System.Windows.Forms.TabPage();
			this.label1 = new System.Windows.Forms.Label();
			this.cbControls = new System.Windows.Forms.ComboBox();
			this.tblData = new System.Windows.Forms.DataGridView();
			this.btnDelete = new System.Windows.Forms.Button();
			this.bntAdd = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.tblTicketInfo = new System.Windows.Forms.TableLayoutPanel();
			this.tabPage1.SuspendLayout();
			this.tabs.SuspendLayout();
			this.tabAdmin.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.tblData)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.pictureBox2);
			this.tabPage1.Controls.Add(this.pictureBox1);
			this.tabPage1.Controls.Add(this.panel1);
			this.tabPage1.Controls.Add(this.lstReferences);
			this.tabPage1.Controls.Add(this.edtSearch);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(962, 437);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Bookings";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// lstReferences
			// 
			this.lstReferences.FormattingEnabled = true;
			this.lstReferences.Location = new System.Drawing.Point(6, 32);
			this.lstReferences.Name = "lstReferences";
			this.lstReferences.Size = new System.Drawing.Size(380, 394);
			this.lstReferences.TabIndex = 3;
			this.lstReferences.SelectedIndexChanged += new System.EventHandler(this.lstReferences_SelectedIndexChanged);
			// 
			// edtSearch
			// 
			this.edtSearch.Location = new System.Drawing.Point(6, 6);
			this.edtSearch.Name = "edtSearch";
			this.edtSearch.Size = new System.Drawing.Size(380, 20);
			this.edtSearch.TabIndex = 2;
			this.edtSearch.Watermark = "Booking reference";
			this.edtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.edtSearch_KeyUp);
			// 
			// tabs
			// 
			this.tabs.Controls.Add(this.tabPage1);
			this.tabs.Controls.Add(this.tabAdmin);
			this.tabs.Location = new System.Drawing.Point(12, 12);
			this.tabs.Name = "tabs";
			this.tabs.SelectedIndex = 0;
			this.tabs.Size = new System.Drawing.Size(970, 463);
			this.tabs.TabIndex = 7;
			// 
			// tabAdmin
			// 
			this.tabAdmin.Controls.Add(this.label1);
			this.tabAdmin.Controls.Add(this.cbControls);
			this.tabAdmin.Controls.Add(this.tblData);
			this.tabAdmin.Controls.Add(this.btnDelete);
			this.tabAdmin.Controls.Add(this.bntAdd);
			this.tabAdmin.Controls.Add(this.btnSave);
			this.tabAdmin.Location = new System.Drawing.Point(4, 22);
			this.tabAdmin.Name = "tabAdmin";
			this.tabAdmin.Padding = new System.Windows.Forms.Padding(3);
			this.tabAdmin.Size = new System.Drawing.Size(962, 437);
			this.tabAdmin.TabIndex = 1;
			this.tabAdmin.Text = "Admin panel";
			this.tabAdmin.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(746, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(45, 13);
			this.label1.TabIndex = 14;
			this.label1.Text = "Controls";
			// 
			// cbControls
			// 
			this.cbControls.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbControls.FormattingEnabled = true;
			this.cbControls.Items.AddRange(new object[] {
            "Matches",
            "Players",
            "Users"});
			this.cbControls.Location = new System.Drawing.Point(797, 10);
			this.cbControls.Name = "cbControls";
			this.cbControls.Size = new System.Drawing.Size(158, 21);
			this.cbControls.TabIndex = 13;
			this.cbControls.SelectedIndexChanged += new System.EventHandler(this.cbControls_SelectedIndexChanged);
			// 
			// tblData
			// 
			this.tblData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.tblData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.tblData.Location = new System.Drawing.Point(6, 41);
			this.tblData.MultiSelect = false;
			this.tblData.Name = "tblData";
			this.tblData.Size = new System.Drawing.Size(950, 344);
			this.tblData.TabIndex = 9;
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(123, 391);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(108, 40);
			this.btnDelete.TabIndex = 12;
			this.btnDelete.Text = "Delete Row";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// bntAdd
			// 
			this.bntAdd.Location = new System.Drawing.Point(9, 391);
			this.bntAdd.Name = "bntAdd";
			this.bntAdd.Size = new System.Drawing.Size(108, 40);
			this.bntAdd.TabIndex = 10;
			this.bntAdd.Text = "Add Row";
			this.bntAdd.UseVisualStyleBackColor = true;
			this.bntAdd.Click += new System.EventHandler(this.bntAdd_Click);
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(848, 391);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(108, 40);
			this.btnSave.TabIndex = 11;
			this.btnSave.Text = "Save Changes";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.tblTicketInfo);
			this.panel1.Location = new System.Drawing.Point(392, 32);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(360, 394);
			this.panel1.TabIndex = 4;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(758, 6);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(198, 205);
			this.pictureBox1.TabIndex = 5;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Location = new System.Drawing.Point(758, 217);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(198, 209);
			this.pictureBox2.TabIndex = 6;
			this.pictureBox2.TabStop = false;
			// 
			// tblTicketInfo
			// 
			this.tblTicketInfo.ColumnCount = 2;
			this.tblTicketInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tblTicketInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tblTicketInfo.Location = new System.Drawing.Point(3, -26);
			this.tblTicketInfo.Name = "tblTicketInfo";
			this.tblTicketInfo.RowCount = 6;
			this.tblTicketInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tblTicketInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tblTicketInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tblTicketInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tblTicketInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tblTicketInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tblTicketInfo.Size = new System.Drawing.Size(354, 417);
			this.tblTicketInfo.TabIndex = 0;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(994, 487);
			this.Controls.Add(this.tabs);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(1010, 525);
			this.MinimumSize = new System.Drawing.Size(1010, 525);
			this.Name = "Form1";
			this.Text = "Admin - NWC";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.Shown += new System.EventHandler(this.Form1_Shown);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabs.ResumeLayout(false);
			this.tabAdmin.ResumeLayout(false);
			this.tabAdmin.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.tblData)).EndInit();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabControl tabs;
		private System.Windows.Forms.TabPage tabAdmin;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cbControls;
		private System.Windows.Forms.DataGridView tblData;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button bntAdd;
		private System.Windows.Forms.Button btnSave;
		private WatermarkTextBox.WatermarkTextBox edtSearch;
		private System.Windows.Forms.ListBox lstReferences;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TableLayoutPanel tblTicketInfo;

	}
}

