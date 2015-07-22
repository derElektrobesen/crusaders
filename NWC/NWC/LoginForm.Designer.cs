namespace NWC
{
	partial class LoginForm
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
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnOk = new System.Windows.Forms.Button();
			this.edtLogin = new WatermarkTextBox.WatermarkTextBox();
			this.edtPass = new WatermarkTextBox.WatermarkTextBox();
			this.SuspendLayout();
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(141, 86);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 3;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnOk
			// 
			this.btnOk.Location = new System.Drawing.Point(60, 86);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(75, 23);
			this.btnOk.TabIndex = 2;
			this.btnOk.Text = "Ok";
			this.btnOk.UseVisualStyleBackColor = true;
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			// 
			// edtLogin
			// 
			this.edtLogin.Location = new System.Drawing.Point(22, 12);
			this.edtLogin.Name = "edtLogin";
			this.edtLogin.Size = new System.Drawing.Size(194, 20);
			this.edtLogin.TabIndex = 0;
			this.edtLogin.Watermark = "Login";
			// 
			// edtPass
			// 
			this.edtPass.Location = new System.Drawing.Point(22, 49);
			this.edtPass.Name = "edtPass";
			this.edtPass.PasswordChar = '*';
			this.edtPass.Size = new System.Drawing.Size(194, 20);
			this.edtPass.TabIndex = 1;
			this.edtPass.Watermark = "Password";
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(241, 120);
			this.Controls.Add(this.edtPass);
			this.Controls.Add(this.edtLogin);
			this.Controls.Add(this.btnOk);
			this.Controls.Add(this.btnCancel);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "LoginForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Authentification";
			this.Load += new System.EventHandler(this.LoginForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnOk;
		private WatermarkTextBox.WatermarkTextBox edtLogin;
		private WatermarkTextBox.WatermarkTextBox edtPass;
	}
}