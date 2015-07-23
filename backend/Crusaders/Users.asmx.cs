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
	public class Users : System.Web.Services.WebService
	{
		public const string remoteappkey = "8rAc1weajVfmpM07SpQAzmb/Jr3fJ1Lu9glo5OCGWN0=";

		[WebMethod(Description = "Check authorization")]
		public string Check(string login, string pass)
		{
			DataClassesDataContext db = new DataClassesDataContext();
			IQueryable<users> q = from user in db.users where user.name == login && user.pass == pass select user;
			if (q == null || q.ToList().Count == 0)
				return "invalid";
			else
				return q.ToList()[0].role;
		}

		[WebMethod(Description = "Update users table (internal api)")]
		public void UpdateUsers(string key, List<users> users)
		{
			if (key == remoteappkey)
			{
				DataClassesDataContext db = new DataClassesDataContext();
				db.users.DeleteAllOnSubmit(db.users);
				db.users.InsertAllOnSubmit(users);
				db.SubmitChanges();
			}
		}

		[WebMethod(Description = "List all users")]
		public List<users> ListUsers(string key)
		{
			if (key != remoteappkey)
				return new List<users>();

			DataClassesDataContext db = new DataClassesDataContext();
			IQueryable<users> q = from user in db.users orderby user.name select user;
			return q.ToList();
		}
	}
}
