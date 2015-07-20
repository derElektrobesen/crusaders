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
		[WebMethod(Description = "Request players in command")]
		[ScriptMethod(ResponseFormat = ResponseFormat.Json)]
		public string GetAllPlayers()
		{
			return new ListResponse<players>(GetAllPlayers_internal()).json();
		}

		[WebMethod(Description = "Request players in command (internal api)")]
		public List<players> GetAllPlayers_internal()
		{
			DataClassesDataContext db = new DataClassesDataContext();
			IQueryable<players> q = from player in db.players orderby player.Team, player.Name select player;
			return q.ToList();
		}

		[WebMethod(Description = "Update players in db (internal api)")]
		public void UpdateAllPlayers_internal(List<players> players)
		{
			DataClassesDataContext db = new DataClassesDataContext();
			db.players.DeleteAllOnSubmit(db.players);
			db.players.InsertAllOnSubmit(players);
			db.SubmitChanges();
		}

		[WebMethod(Description = "Request players in specified team")]
		[ScriptMethod(ResponseFormat = ResponseFormat.Json)]
		public string GetAllPlayersFromTeam(string team)
		{
			DataClassesDataContext db = new DataClassesDataContext();
			IQueryable<players> q = from player in db.players where player.Team == team orderby player.Name select player;
			return new ListResponse<players>(q.ToList()).json();
		}

		[WebMethod(Description = "Request information about single player")]
		[ScriptMethod(ResponseFormat = ResponseFormat.Json)]
		public string Player(int id)
		{
			DataClassesDataContext db = new DataClassesDataContext();
			IQueryable<players> q = from player in db.players where player.Id == id orderby player.Name select player;
			return new ListResponse<players>(q.ToList()).json();
		}
	}
}