﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.225
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NWC.Matches {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="ArrayOfMatches", Namespace="http://tempuri.org/", ItemName="matches")]
    [System.SerializableAttribute()]
    public class ArrayOfMatches : System.Collections.Generic.List<NWC.Matches.matches> {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="matches", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class matches : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CompetitorField;
        
        private System.Nullable<System.DateTime> DateTimeField;
        
        private System.Nullable<double> ChildPriceField;
        
        private System.Nullable<double> AdultPriceField;
        
        private System.Nullable<double> ConsessionPriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CompetitorImageField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string Competitor {
            get {
                return this.CompetitorField;
            }
            set {
                if ((object.ReferenceEquals(this.CompetitorField, value) != true)) {
                    this.CompetitorField = value;
                    this.RaisePropertyChanged("Competitor");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=2)]
        public System.Nullable<System.DateTime> DateTime {
            get {
                return this.DateTimeField;
            }
            set {
                if ((this.DateTimeField.Equals(value) != true)) {
                    this.DateTimeField = value;
                    this.RaisePropertyChanged("DateTime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=3)]
        public System.Nullable<double> ChildPrice {
            get {
                return this.ChildPriceField;
            }
            set {
                if ((this.ChildPriceField.Equals(value) != true)) {
                    this.ChildPriceField = value;
                    this.RaisePropertyChanged("ChildPrice");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=4)]
        public System.Nullable<double> AdultPrice {
            get {
                return this.AdultPriceField;
            }
            set {
                if ((this.AdultPriceField.Equals(value) != true)) {
                    this.AdultPriceField = value;
                    this.RaisePropertyChanged("AdultPrice");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=5)]
        public System.Nullable<double> ConsessionPrice {
            get {
                return this.ConsessionPriceField;
            }
            set {
                if ((this.ConsessionPriceField.Equals(value) != true)) {
                    this.ConsessionPriceField = value;
                    this.RaisePropertyChanged("ConsessionPrice");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=6)]
        public string CompetitorImage {
            get {
                return this.CompetitorImageField;
            }
            set {
                if ((object.ReferenceEquals(this.CompetitorImageField, value) != true)) {
                    this.CompetitorImageField = value;
                    this.RaisePropertyChanged("CompetitorImage");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SingleTicket", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class SingleTicket : NWC.Matches.tickets {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private NWC.Matches.matches matchField;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public NWC.Matches.matches match {
            get {
                return this.matchField;
            }
            set {
                if ((object.ReferenceEquals(this.matchField, value) != true)) {
                    this.matchField = value;
                    this.RaisePropertyChanged("match");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="tickets", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(NWC.Matches.SingleTicket))]
    public partial class tickets : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string BookingReferenceField;
        
        private System.DateTime BookingDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TicketTypeField;
        
        private int QuantityField;
        
        private int MatchIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string BookingReference {
            get {
                return this.BookingReferenceField;
            }
            set {
                if ((object.ReferenceEquals(this.BookingReferenceField, value) != true)) {
                    this.BookingReferenceField = value;
                    this.RaisePropertyChanged("BookingReference");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=1)]
        public System.DateTime BookingDate {
            get {
                return this.BookingDateField;
            }
            set {
                if ((this.BookingDateField.Equals(value) != true)) {
                    this.BookingDateField = value;
                    this.RaisePropertyChanged("BookingDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string TicketType {
            get {
                return this.TicketTypeField;
            }
            set {
                if ((object.ReferenceEquals(this.TicketTypeField, value) != true)) {
                    this.TicketTypeField = value;
                    this.RaisePropertyChanged("TicketType");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=3)]
        public int Quantity {
            get {
                return this.QuantityField;
            }
            set {
                if ((this.QuantityField.Equals(value) != true)) {
                    this.QuantityField = value;
                    this.RaisePropertyChanged("Quantity");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=4)]
        public int MatchId {
            get {
                return this.MatchIdField;
            }
            set {
                if ((this.MatchIdField.Equals(value) != true)) {
                    this.MatchIdField = value;
                    this.RaisePropertyChanged("MatchId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Matches.MatchesSoap")]
    public interface MatchesSoap {
        
        // CODEGEN: Контракт генерации сообщений с именем GetAllMatchesResult из пространства имен http://tempuri.org/ не отмечен как обнуляемый
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetAllMatches", ReplyAction="*")]
        NWC.Matches.GetAllMatchesResponse GetAllMatches(NWC.Matches.GetAllMatchesRequest request);
        
        // CODEGEN: Контракт генерации сообщений с именем ListMatchesResult из пространства имен http://tempuri.org/ не отмечен как обнуляемый
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ListMatches", ReplyAction="*")]
        NWC.Matches.ListMatchesResponse ListMatches(NWC.Matches.ListMatchesRequest request);
        
        // CODEGEN: Контракт генерации сообщений с именем MatchInfoResult из пространства имен http://tempuri.org/ не отмечен как обнуляемый
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/MatchInfo", ReplyAction="*")]
        NWC.Matches.MatchInfoResponse MatchInfo(NWC.Matches.MatchInfoRequest request);
        
        // CODEGEN: Контракт генерации сообщений с именем tickettype из пространства имен http://tempuri.org/ не отмечен как обнуляемый
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/BookTicket", ReplyAction="*")]
        NWC.Matches.BookTicketResponse BookTicket(NWC.Matches.BookTicketRequest request);
        
        // CODEGEN: Контракт генерации сообщений с именем appkey из пространства имен http://tempuri.org/ не отмечен как обнуляемый
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UpdateMatches", ReplyAction="*")]
        NWC.Matches.UpdateMatchesResponse UpdateMatches(NWC.Matches.UpdateMatchesRequest request);
        
        // CODEGEN: Контракт генерации сообщений с именем appkey из пространства имен http://tempuri.org/ не отмечен как обнуляемый
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetAllBookings", ReplyAction="*")]
        NWC.Matches.GetAllBookingsResponse GetAllBookings(NWC.Matches.GetAllBookingsRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetAllMatchesRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetAllMatches", Namespace="http://tempuri.org/", Order=0)]
        public NWC.Matches.GetAllMatchesRequestBody Body;
        
        public GetAllMatchesRequest() {
        }
        
        public GetAllMatchesRequest(NWC.Matches.GetAllMatchesRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GetAllMatchesRequestBody {
        
        public GetAllMatchesRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetAllMatchesResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetAllMatchesResponse", Namespace="http://tempuri.org/", Order=0)]
        public NWC.Matches.GetAllMatchesResponseBody Body;
        
        public GetAllMatchesResponse() {
        }
        
        public GetAllMatchesResponse(NWC.Matches.GetAllMatchesResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetAllMatchesResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public NWC.Matches.ArrayOfMatches GetAllMatchesResult;
        
        public GetAllMatchesResponseBody() {
        }
        
        public GetAllMatchesResponseBody(NWC.Matches.ArrayOfMatches GetAllMatchesResult) {
            this.GetAllMatchesResult = GetAllMatchesResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ListMatchesRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ListMatches", Namespace="http://tempuri.org/", Order=0)]
        public NWC.Matches.ListMatchesRequestBody Body;
        
        public ListMatchesRequest() {
        }
        
        public ListMatchesRequest(NWC.Matches.ListMatchesRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class ListMatchesRequestBody {
        
        public ListMatchesRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ListMatchesResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ListMatchesResponse", Namespace="http://tempuri.org/", Order=0)]
        public NWC.Matches.ListMatchesResponseBody Body;
        
        public ListMatchesResponse() {
        }
        
        public ListMatchesResponse(NWC.Matches.ListMatchesResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ListMatchesResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string ListMatchesResult;
        
        public ListMatchesResponseBody() {
        }
        
        public ListMatchesResponseBody(string ListMatchesResult) {
            this.ListMatchesResult = ListMatchesResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class MatchInfoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="MatchInfo", Namespace="http://tempuri.org/", Order=0)]
        public NWC.Matches.MatchInfoRequestBody Body;
        
        public MatchInfoRequest() {
        }
        
        public MatchInfoRequest(NWC.Matches.MatchInfoRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class MatchInfoRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int id;
        
        public MatchInfoRequestBody() {
        }
        
        public MatchInfoRequestBody(int id) {
            this.id = id;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class MatchInfoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="MatchInfoResponse", Namespace="http://tempuri.org/", Order=0)]
        public NWC.Matches.MatchInfoResponseBody Body;
        
        public MatchInfoResponse() {
        }
        
        public MatchInfoResponse(NWC.Matches.MatchInfoResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class MatchInfoResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string MatchInfoResult;
        
        public MatchInfoResponseBody() {
        }
        
        public MatchInfoResponseBody(string MatchInfoResult) {
            this.MatchInfoResult = MatchInfoResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class BookTicketRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="BookTicket", Namespace="http://tempuri.org/", Order=0)]
        public NWC.Matches.BookTicketRequestBody Body;
        
        public BookTicketRequest() {
        }
        
        public BookTicketRequest(NWC.Matches.BookTicketRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class BookTicketRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int matchid;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string tickettype;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=2)]
        public int quantity;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string email;
        
        public BookTicketRequestBody() {
        }
        
        public BookTicketRequestBody(int matchid, string tickettype, int quantity, string email) {
            this.matchid = matchid;
            this.tickettype = tickettype;
            this.quantity = quantity;
            this.email = email;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class BookTicketResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="BookTicketResponse", Namespace="http://tempuri.org/", Order=0)]
        public NWC.Matches.BookTicketResponseBody Body;
        
        public BookTicketResponse() {
        }
        
        public BookTicketResponse(NWC.Matches.BookTicketResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class BookTicketResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string BookTicketResult;
        
        public BookTicketResponseBody() {
        }
        
        public BookTicketResponseBody(string BookTicketResult) {
            this.BookTicketResult = BookTicketResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class UpdateMatchesRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="UpdateMatches", Namespace="http://tempuri.org/", Order=0)]
        public NWC.Matches.UpdateMatchesRequestBody Body;
        
        public UpdateMatchesRequest() {
        }
        
        public UpdateMatchesRequest(NWC.Matches.UpdateMatchesRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class UpdateMatchesRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string appkey;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public NWC.Matches.ArrayOfMatches list;
        
        public UpdateMatchesRequestBody() {
        }
        
        public UpdateMatchesRequestBody(string appkey, NWC.Matches.ArrayOfMatches list) {
            this.appkey = appkey;
            this.list = list;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class UpdateMatchesResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="UpdateMatchesResponse", Namespace="http://tempuri.org/", Order=0)]
        public NWC.Matches.UpdateMatchesResponseBody Body;
        
        public UpdateMatchesResponse() {
        }
        
        public UpdateMatchesResponse(NWC.Matches.UpdateMatchesResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class UpdateMatchesResponseBody {
        
        public UpdateMatchesResponseBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetAllBookingsRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetAllBookings", Namespace="http://tempuri.org/", Order=0)]
        public NWC.Matches.GetAllBookingsRequestBody Body;
        
        public GetAllBookingsRequest() {
        }
        
        public GetAllBookingsRequest(NWC.Matches.GetAllBookingsRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetAllBookingsRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string appkey;
        
        public GetAllBookingsRequestBody() {
        }
        
        public GetAllBookingsRequestBody(string appkey) {
            this.appkey = appkey;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetAllBookingsResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetAllBookingsResponse", Namespace="http://tempuri.org/", Order=0)]
        public NWC.Matches.GetAllBookingsResponseBody Body;
        
        public GetAllBookingsResponse() {
        }
        
        public GetAllBookingsResponse(NWC.Matches.GetAllBookingsResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetAllBookingsResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public NWC.Matches.SingleTicket[] GetAllBookingsResult;
        
        public GetAllBookingsResponseBody() {
        }
        
        public GetAllBookingsResponseBody(NWC.Matches.SingleTicket[] GetAllBookingsResult) {
            this.GetAllBookingsResult = GetAllBookingsResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface MatchesSoapChannel : NWC.Matches.MatchesSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MatchesSoapClient : System.ServiceModel.ClientBase<NWC.Matches.MatchesSoap>, NWC.Matches.MatchesSoap {
        
        public MatchesSoapClient() {
        }
        
        public MatchesSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MatchesSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MatchesSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MatchesSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        NWC.Matches.GetAllMatchesResponse NWC.Matches.MatchesSoap.GetAllMatches(NWC.Matches.GetAllMatchesRequest request) {
            return base.Channel.GetAllMatches(request);
        }
        
        public NWC.Matches.ArrayOfMatches GetAllMatches() {
            NWC.Matches.GetAllMatchesRequest inValue = new NWC.Matches.GetAllMatchesRequest();
            inValue.Body = new NWC.Matches.GetAllMatchesRequestBody();
            NWC.Matches.GetAllMatchesResponse retVal = ((NWC.Matches.MatchesSoap)(this)).GetAllMatches(inValue);
            return retVal.Body.GetAllMatchesResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        NWC.Matches.ListMatchesResponse NWC.Matches.MatchesSoap.ListMatches(NWC.Matches.ListMatchesRequest request) {
            return base.Channel.ListMatches(request);
        }
        
        public string ListMatches() {
            NWC.Matches.ListMatchesRequest inValue = new NWC.Matches.ListMatchesRequest();
            inValue.Body = new NWC.Matches.ListMatchesRequestBody();
            NWC.Matches.ListMatchesResponse retVal = ((NWC.Matches.MatchesSoap)(this)).ListMatches(inValue);
            return retVal.Body.ListMatchesResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        NWC.Matches.MatchInfoResponse NWC.Matches.MatchesSoap.MatchInfo(NWC.Matches.MatchInfoRequest request) {
            return base.Channel.MatchInfo(request);
        }
        
        public string MatchInfo(int id) {
            NWC.Matches.MatchInfoRequest inValue = new NWC.Matches.MatchInfoRequest();
            inValue.Body = new NWC.Matches.MatchInfoRequestBody();
            inValue.Body.id = id;
            NWC.Matches.MatchInfoResponse retVal = ((NWC.Matches.MatchesSoap)(this)).MatchInfo(inValue);
            return retVal.Body.MatchInfoResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        NWC.Matches.BookTicketResponse NWC.Matches.MatchesSoap.BookTicket(NWC.Matches.BookTicketRequest request) {
            return base.Channel.BookTicket(request);
        }
        
        public string BookTicket(int matchid, string tickettype, int quantity, string email) {
            NWC.Matches.BookTicketRequest inValue = new NWC.Matches.BookTicketRequest();
            inValue.Body = new NWC.Matches.BookTicketRequestBody();
            inValue.Body.matchid = matchid;
            inValue.Body.tickettype = tickettype;
            inValue.Body.quantity = quantity;
            inValue.Body.email = email;
            NWC.Matches.BookTicketResponse retVal = ((NWC.Matches.MatchesSoap)(this)).BookTicket(inValue);
            return retVal.Body.BookTicketResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        NWC.Matches.UpdateMatchesResponse NWC.Matches.MatchesSoap.UpdateMatches(NWC.Matches.UpdateMatchesRequest request) {
            return base.Channel.UpdateMatches(request);
        }
        
        public void UpdateMatches(string appkey, NWC.Matches.ArrayOfMatches list) {
            NWC.Matches.UpdateMatchesRequest inValue = new NWC.Matches.UpdateMatchesRequest();
            inValue.Body = new NWC.Matches.UpdateMatchesRequestBody();
            inValue.Body.appkey = appkey;
            inValue.Body.list = list;
            NWC.Matches.UpdateMatchesResponse retVal = ((NWC.Matches.MatchesSoap)(this)).UpdateMatches(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        NWC.Matches.GetAllBookingsResponse NWC.Matches.MatchesSoap.GetAllBookings(NWC.Matches.GetAllBookingsRequest request) {
            return base.Channel.GetAllBookings(request);
        }
        
        public NWC.Matches.SingleTicket[] GetAllBookings(string appkey) {
            NWC.Matches.GetAllBookingsRequest inValue = new NWC.Matches.GetAllBookingsRequest();
            inValue.Body = new NWC.Matches.GetAllBookingsRequestBody();
            inValue.Body.appkey = appkey;
            NWC.Matches.GetAllBookingsResponse retVal = ((NWC.Matches.MatchesSoap)(this)).GetAllBookings(inValue);
            return retVal.Body.GetAllBookingsResult;
        }
    }
}
