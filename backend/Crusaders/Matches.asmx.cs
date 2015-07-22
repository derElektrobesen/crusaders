using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Script.Services;
using System.Net.Mail;
using System.IO;

namespace Crusaders
{
	[WebService]
	[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
	[System.ComponentModel.ToolboxItem(false)]
	[ScriptService]
	public class Matches : System.Web.Services.WebService
	{
		public class SingleTicket : tickets
		{
			public matches match { get; set; }
			public SingleTicket(tickets t, matches m)
				: base()
			{
				base.BookingReference = t.BookingReference;
				base.BookingDate = t.BookingDate;
				base.Quantity = t.Quantity;
				base.TicketType = t.TicketType;
				base.MatchId = t.MatchId;

				match = m;
			}

			public SingleTicket()
				: base()
			{
				match = new matches();
			}
		}

		[WebMethod(Description = "Request list of matches")]
		public List<matches> GetAllMatches()
		{
			DataClassesDataContext db = new DataClassesDataContext();
			IQueryable<matches> q = from match in db.matches where match.DateTime > DateTime.Now orderby match.DateTime select match;
			return q.ToList();
		}

		[WebMethod(Description = "Request list of matches")]
		[ScriptMethod(ResponseFormat = ResponseFormat.Json)]
		public string ListMatches()
		{
			return new ListResponse<matches>(GetAllMatches()).json();
		}

		[WebMethod(Description = "Request specific match info")]
		[ScriptMethod(ResponseFormat = ResponseFormat.Json)]
		public string MatchInfo(int id)
		{
			DataClassesDataContext db = new DataClassesDataContext();
			IQueryable<matches> q = from match in db.matches where match.Id == id select match;
			return new ListResponse<matches>(q.ToList()).json();
		}

		class NoException : Exception
		{
			public NoException()
				: base()
			{ }
		}

		[WebMethod(Description = "Make a booking")]
		[ScriptMethod(ResponseFormat = ResponseFormat.Json)]
		public string BookTicket(int matchid, string tickettype, int quantity, string email)
		{
			DataClassesDataContext db = new DataClassesDataContext();
			matches match = db.matches.First(i => i.Id == matchid);
			if (match == null)
				return new CommonResponse(new BadRequestError("Invalid match id")).json();

			Random rnd = new Random();
			tickets ticket = new tickets();
			ticket.BookingDate = DateTime.Now;
			ticket.BookingReference = (
					(match.Competitor.Replace(" ", string.Empty) + "XXXX").Substring(0, 4)
					+ rnd.Next(0, 99999).ToString("D5")
					+ ticket.BookingDate.ToString("ddMMyy")
				).ToUpper();
			ticket.MatchId = matchid;
			ticket.TicketType = tickettype;
			ticket.Quantity = quantity;
			ticket.Email = email;

			if (email != null && email.Length > 0)
			{

				try
				{
					string my_email, my_pass;
					try
					{
						using (StreamReader file = new StreamReader(@"C:/crusaders.conf"))
						{
							string line = file.ReadLine();
							if (line == null)
								throw new NoException();

							string[] words = line.Split(' ');
							if (words.Length != 2)
								throw new NoException();

							my_email = words[0];
							my_pass = words[1];
						}
					}
					catch (FileNotFoundException e)
					{
						return new CommonResponse(new InternalError(e.ToString())).json();
					}

					SmtpClient client = new SmtpClient();
					client.UseDefaultCredentials = false;
					client.Credentials = new System.Net.NetworkCredential(my_email, my_pass);
					client.Port = 587;
					client.Host = "smtp.office365.com";
					client.DeliveryMethod = SmtpDeliveryMethod.Network;
					client.EnableSsl = true;

					MailMessage mail = new MailMessage();
					mail.To.Add(new MailAddress(email));
					mail.From = new MailAddress(my_email, "Crusaders booking system");
					mail.Subject = "Crusaders match booking reference";
					mail.Body = "Match date: " + match.DateTime.ToString() + ";\nBooking reference: " + ticket.BookingReference;

					System.Threading.ThreadPool.QueueUserWorkItem(delegate
						{
							try
							{
								client.Send(mail);
							}
							catch (Exception)
							{
								// TODO: process exception
							}
						}, null);
				}
				catch (NoException)
				{
				}
				catch (Exception e)
				{
					return new CommonResponse(new BadRequestError("Can't send an email: " + e.ToString())).json();
				}
			}

			db.tickets.InsertOnSubmit(ticket);
			db.SubmitChanges();

			return new ListResponse<tickets>(ticket).json();
		}

		[WebMethod(Description = "Update list of matches")]
		public void UpdateMatches(List<matches> list)
		{
			DataClassesDataContext db = new DataClassesDataContext();
			db.matches.DeleteAllOnSubmit(db.matches);
			db.matches.InsertAllOnSubmit(list);
			db.SubmitChanges();
		}

		[WebMethod(Description = "Request list of bookings")]
		public List<SingleTicket> GetAllBookings()
		{
			DataClassesDataContext db = new DataClassesDataContext();
			IQueryable<SingleTicket> q = from ticket in db.tickets
									join match in db.matches on ticket.MatchId equals match.Id
									orderby ticket.BookingReference
									select new SingleTicket(ticket, match);
			return q.ToList();
		}
	}
}
