using System;
using System.Collections.Generic;
using System.Web.Script.Serialization;

namespace Crusaders
{
	public class LocalJavaScriptSerializer : JavaScriptSerializer
	{
		public LocalJavaScriptSerializer()
			: base()
		{
			this.RegisterConverters(new JavaScriptConverter[] { new DateStringJSONConverter() });
		}
	}

	public class DateStringJSONConverter : JavaScriptConverter
	{
		private List<System.Type> supportedTypes;

		public DateStringJSONConverter()
		{
			supportedTypes = new List<System.Type>(1);
			supportedTypes.Add(typeof(DateTime));
		}

		public override object Deserialize(IDictionary<string, object> dictionary, Type type, JavaScriptSerializer serializer)
		{
			DateTime dt = DateTime.ParseExact(dictionary["DateString"].ToString(), "MM/dd/yyyy", null);

			return dt;
		}

		public override IDictionary<string, object> Serialize(object obj, JavaScriptSerializer serializer)
		{
			DateTime dt = Convert.ToDateTime(obj);

			Dictionary<string, object> dicDateTime = new Dictionary<string, object>(1);
			dicDateTime.Add("DateString", dt.ToString("dddd d MMMM"));

			return dicDateTime;
		}

		public override IEnumerable<System.Type> SupportedTypes
		{
			get { return this.supportedTypes; }
		}
	}

    public class CommonError
    {
        protected virtual int ErrCode()
        {
            throw new System.NotImplementedException();
        }

        protected virtual string ErrStr()
        {
            throw new System.NotImplementedException();
        }

        public int status
        {
            get { return ErrCode(); }
        }

        public string error
        {
            get { return ErrStr(); }
        }
    }

    public class NoError : CommonError
    {
        protected override int ErrCode() { return 200; }
        protected override string ErrStr() { return "Success"; }
    }

	public class SendMsgError : CommonError
	{
		protected override int ErrCode() { return 407; }
		protected override string ErrStr() { return "Can't send email message"; }
	}

    public class SomeError : CommonError
    {
        private string _error;
        public SomeError(string err)
        {
            _error = err;
        }

        protected override string ErrStr() { return _error; }
    }

    public class InternalError : SomeError
    {
        public InternalError(string err) : base(err) {}
        protected override int ErrCode() { return 500; }
    }

    public class BadRequestError : SomeError
    {
        public BadRequestError(string err) : base(err) {}
        protected override int ErrCode() { return 400; }
    }

    public class NotImplementedError : SomeError
    {
        public NotImplementedError() : base("Method not implemented") { }
        protected override int ErrCode() { return 501; }
    }

    public class CommonResponse
    {
        protected CommonError _error { get; set; }

        public CommonResponse()
        {
            _error = new NoError();
        }

        public CommonResponse(CommonError err)
        {
            _error = err;
        }

        protected virtual object prepare()
        {
            return _error;
        }

        public string json()
        {
			LocalJavaScriptSerializer js = new LocalJavaScriptSerializer();
            return js.Serialize(prepare());
        }
    }

    public class NotImplementedResponse : CommonResponse
    {
        public NotImplementedResponse()
        {
            _error = new NotImplementedError();
        }
    }

    public class ListResponse<T> : CommonResponse
    {
        private List<T> _list;

		public ListResponse(params T[] objs)
        {
            _list = new List<T>(objs);
        }

		public ListResponse(List<T> objs)
		{
			_list = new List<T>(objs);
		}

		public ListResponse()
		{
			_list = new List<T>();
		}

        protected override object prepare()
        {
            return new
            {
                status = _error.status,
                error = _error.error,
                count = _list.Count,
                data = _list,
            };
        }

        public void add(T obj)
        {
            _list.Add(obj);
        }

        public void add(params T[] objs)
        {
            foreach (T i in objs)
                _list.Add(i);
        }
    }
}
