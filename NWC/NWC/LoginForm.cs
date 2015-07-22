using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NWC
{
	public partial class LoginForm : Form
	{
		private string m_Role = "invalid";

		public LoginForm()
		{
			InitializeComponent();
		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			Users.UsersSoapClient client = new Users.UsersSoapClient();
			m_Role = client.Check(edtLogin.Text, edtPass.Text);
			if (m_Role == "invalid")
				MessageBox.Show("Invalid login or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			else
				Close();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			m_Role = "invalid";
			Close();
		}

		public string role()
		{
			return m_Role;
		}

		private void LoginForm_Load(object sender, EventArgs e)
		{
			edtLogin.Focus();
		}
	}
}
