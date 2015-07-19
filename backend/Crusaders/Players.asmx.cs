using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.ServiceModel.Web;
using System.Web.Script.Services;

namespace Crusaders
{
	[WebService]
	[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
	[System.ComponentModel.ToolboxItem(false)]
	[ScriptService]
	public class Players : System.Web.Services.WebService
	{
		[WebMethod(Description = "List of players in command")]
		[ScriptMethod(ResponseFormat = ResponseFormat.Json)]
		public string GetAllPlayers()
		{
			DataClassesDataContext db = new DataClassesDataContext();
			IQueryable<players> q = from player in db.players select player;
			return new ListResponse<players>(q.ToList()).json();
		}

		[WebMethod(Description = "Request information about single player")]
		[ScriptMethod(ResponseFormat = ResponseFormat.Json)]
		public string Player(int id)
		{
			DataClassesDataContext db = new DataClassesDataContext();
			IQueryable<players> q = from player in db.players where player.Id == id select player;
			return new ListResponse<players>(q.ToList()).json();
		}
	}
}