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
    public partial class Form1 : Form
    {
		enum ControlsTypes
		{
			ctPlayers,
			ctMatches,
			ctUsers,
		};
		
		private ControlsTypes m_ControlsTypes = ControlsTypes.ctPlayers;
		private List<Players.players> m_Players = new List<Players.players>();
		private List<Matches.matches> m_Matches = new List<Matches.matches>();
		private List<Users.users> m_Users = new List<Users.users>();
		private Dictionary<string, Matches.SingleTicket> m_Tickets = new Dictionary<string, Matches.SingleTicket>();
		private List<string> m_BookingReferences = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

		private void Form1_Load(object sender, EventArgs e)
		{
			cbControls.SelectedIndex = 0;
			loadTickets();
		}

		private void loadPlayers()
		{
			Players.PlayersSoapClient client = new Players.PlayersSoapClient();
			m_Players = client.GetAllPlayers_internal();
			tblData.DataSource = null;
			tblData.DataSource = m_Players;
			tblData.Columns["Id"].ReadOnly = true;
			m_ControlsTypes = ControlsTypes.ctPlayers;
		}

		private void loadMatches()
		{
			Matches.MatchesSoapClient client = new Matches.MatchesSoapClient();
			m_Matches = client.GetAllMatches();
			tblData.DataSource = null;
			tblData.DataSource = m_Matches;
			tblData.Columns["Id"].ReadOnly = true;
			m_ControlsTypes = ControlsTypes.ctMatches;
		}

		private void loadUsers()
		{
			Users.UsersSoapClient client = new Users.UsersSoapClient();
			m_Users = client.ListUsers("8rAc1weajVfmpM07SpQAzmb/Jr3fJ1Lu9glo5OCGWN0=");
			tblData.DataSource = null;
			tblData.DataSource = m_Users;
			m_ControlsTypes = ControlsTypes.ctUsers;
		}

		private void loadTickets()
		{
			Matches.MatchesSoapClient client = new Matches.MatchesSoapClient();
			Matches.SingleTicket[] tickets = client.GetAllBookings();
			m_Tickets = new Dictionary<string, Matches.SingleTicket>();

			m_BookingReferences = new List<string>();
			foreach (var t in tickets)
			{
				m_Tickets[t.BookingReference] = t;
				m_BookingReferences.Add(t.BookingReference);
			}
		}

		private void edtSearch_KeyUp(object sender, KeyEventArgs e)
		{
			List<string> to_print = new List<string>();
			string to_search = edtSearch.Text;

			if (to_search.Length == 0)
			{
				lstReferences.Items.Clear();
				lstReferences.Items.AddRange(m_BookingReferences.ToArray());
				return;
			}

			for (var i = 0; i < m_BookingReferences.Count; ++i)
			{
				if (m_BookingReferences[i].StartsWith(to_search, StringComparison.OrdinalIgnoreCase))
					to_print.Add(m_BookingReferences[i]);
			}

			lstReferences.Items.Clear();
			lstReferences.Items.AddRange(to_print.ToArray());
		}

		private void lstReferences_SelectedIndexChanged(object sender, EventArgs e)
		{
			Matches.SingleTicket ticket = m_Tickets[lstReferences.SelectedItem.ToString()];
			if (ticket != null)
			{
				tblTicketInfo.Controls.Clear();
				KeyValuePair<string, string>[] to_show = {
									 new KeyValuePair<string, string>("Booking Reference", ticket.BookingReference),
									 new KeyValuePair<string, string>("Booking date", ticket.BookingDate.ToString()),
									 new KeyValuePair<string, string>("Ticket type", ticket.TicketType),
									 new KeyValuePair<string, string>("Quantity", ticket.Quantity.ToString()),
									 new KeyValuePair<string, string>("Competitor", ticket.match.Competitor),
									 new KeyValuePair<string, string>("Match time", ticket.match.DateTime.ToString()),
								 };
				for (int i = 0; i < to_show.Length; ++i)
				{
					Label l = new Label();
					l.Text = to_show[i].Value;
					tblTicketInfo.Controls.Add(l, 0, i + 1);

					l = new Label();
					l.Text = to_show[i].Key;
					tblTicketInfo.Controls.Add(l, 0, i + 1);
				}
			}
		}

		private void cbControls_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cbControls.SelectedItem.ToString() == "Players")
				loadPlayers();
			else if (cbControls.SelectedItem.ToString() == "Matches")
				loadMatches();
			else if (cbControls.SelectedItem.ToString() == "Users")
				loadUsers();
		}

		private void bntAdd_Click(object sender, EventArgs e)
		{
			if (m_ControlsTypes == ControlsTypes.ctPlayers)
			{
				Players.players p = new Players.players();
				int max = 0;
				foreach (var pp in m_Players)
				{
					if (pp.Id > max)
						max = pp.Id;
				}

				p.Id = max + 1;
				m_Players.Add(p);
				tblData.DataSource = null;
				tblData.DataSource = m_Players;
			}
			else if (m_ControlsTypes == ControlsTypes.ctMatches)
			{
				Matches.matches m = new Matches.matches();
				int max = 0;
				foreach (var mm in m_Matches)
				{
					if (mm.Id > max)
						max = mm.Id;
				}

				m.Id = max + 1;
				m_Matches.Add(m);
				tblData.DataSource = null;
				tblData.DataSource = m_Matches;
			}
			else if (m_ControlsTypes == ControlsTypes.ctUsers)
			{
				m_Users.Add(new Users.users());
				tblData.DataSource = null;
				tblData.DataSource = m_Users;
			}
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (m_ControlsTypes == ControlsTypes.ctPlayers)
			{
				m_Players.RemoveAt(tblData.CurrentRow.Index);
				tblData.DataSource = null;
				tblData.DataSource = m_Players;
			}
			else if (m_ControlsTypes == ControlsTypes.ctMatches)
			{
				m_Matches.RemoveAt(tblData.CurrentRow.Index);
				tblData.DataSource = null;
				tblData.DataSource = m_Matches;
			}
			else if (m_ControlsTypes == ControlsTypes.ctUsers)
			{
				m_Users.RemoveAt(tblData.CurrentRow.Index);
				tblData.DataSource = null;
				tblData.DataSource = m_Users;
			}
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (m_ControlsTypes == ControlsTypes.ctPlayers)
			{
				Players.PlayersSoapClient client = new Players.PlayersSoapClient();
				client.UpdateAllPlayers_internal((Players.ArrayOfPlayers)m_Players);
				MessageBox.Show("Players saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else if (m_ControlsTypes == ControlsTypes.ctMatches)
			{
				Matches.MatchesSoapClient client = new Matches.MatchesSoapClient();
				client.UpdateMatches((Matches.ArrayOfMatches)m_Matches);
				MessageBox.Show("Matches saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else if (m_ControlsTypes == ControlsTypes.ctUsers)
			{
				Users.UsersSoapClient client = new Users.UsersSoapClient();
				client.UpdateUsers((Users.ArrayOfUsers)m_Users);
				MessageBox.Show("Users saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void Form1_Shown(object sender, EventArgs e)
		{
			LoginForm frm = new LoginForm();
			frm.ShowDialog(this);

			if (frm.role() == "invalid")
				Close();
			else if (frm.role() != "admin")
				tabs.TabPages.Remove(tabAdmin);

			lstReferences.Items.Clear();
			lstReferences.Items.AddRange(m_BookingReferences.ToArray());
		}
    }
}
