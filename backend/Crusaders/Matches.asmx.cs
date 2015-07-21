using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Script.Services;

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
			IQueryable<matches> q = from match in db.matches orderby match.DateTime select match;
			return q.ToList();
		}

		[WebMethod(Description = "Request list of matches")]
		[ScriptMethod(ResponseFormat = ResponseFormat.Json)]
		public string ListMatches()
		{
			return new ListResponse<matches>(GetAllMatches()).json();
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
