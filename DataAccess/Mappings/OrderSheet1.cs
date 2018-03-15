using System; 
using System.Collections.Generic; 
using System.Text; 
using System; 


namespace DataAccess {
    
    public class OrderSheet1 {
        public OrderSheet1() { }
        public virtual int OsNo { get; set; }
        public virtual MBuyer1 MBuyer1 { get; set; }
        //public virtual MShippingMark MShippingMark { get; set; }
        public virtual IList<OrderFollowup> OrderFollowups { get; set; }
        public virtual IList<OrderStatus> OrderStatuses { get; set; }
        public virtual IList<OsScheduling> OsSchedulings { get; set; }
        public virtual IList<ShipmentDetailOs> ShipmentDetailOs { get; set; }
        public virtual IList<ShipmentDetailOsHist> ShipmentDetailOsHists { get; set; }
        public virtual System.Nullable<System.DateTime> OsDate { get; set; }
        public virtual byte RevisionNo { get; set; }
        public virtual System.Nullable<System.DateTime> RevisionDate { get; set; }
        public virtual string PoNo { get; set; }
        public virtual System.Nullable<System.DateTime> PoDate { get; set; }
        public virtual string PoNoBuyer { get; set; }
        public virtual System.Nullable<System.DateTime> PoDateBuyer { get; set; }
        public virtual string QuotaCode { get; set; }
        public virtual short CustCode { get; set; }
        public virtual string FactoryInquiry { get; set; }
        public virtual string GyNo { get; set; }
        public virtual string Remarks { get; set; }
        public virtual string SpecSheet { get; set; }
        public virtual string OtherDocument { get; set; }
        public virtual string Cancelled { get; set; }
        public virtual string Printed { get; set; }
        public virtual string Post { get; set; }
        public virtual string Closed { get; set; }
        public virtual string PartialShipment { get; set; }
        public virtual string Completed { get; set; }
        public virtual string PoAssigned { get; set; }
        public virtual short UserNo { get; set; }
        public virtual System.Nullable<System.DateTime> PostDate { get; set; }
        public virtual System.Nullable<short> PostedBy { get; set; }
        public virtual System.DateTime EntryDate { get; set; }
        public virtual int LotNo { get; set; }
        public virtual string YarnPRequest { get; set; }
        public virtual System.Nullable<short> ClosedBy { get; set; }
        public virtual System.Nullable<System.DateTime> ClosedOn { get; set; }
        public virtual string TransferCheck { get; set; }
        public virtual string PoNoOld { get; set; }
        public virtual System.Nullable<System.DateTime> PoDateOld { get; set; }
        public virtual System.Nullable<short> EditedBy { get; set; }
        public virtual System.Nullable<System.DateTime> EditedDate { get; set; }
        public virtual int SoNo { get; set; }
        public virtual System.Nullable<int> ScNo { get; set; }
        public virtual System.Nullable<int> ScRev { get; set; }
        public virtual System.Nullable<short> CancelledBy { get; set; }
        public virtual System.Nullable<System.DateTime> CancelledOn { get; set; }
        public virtual string AutoUpdate { get; set; }
        public virtual string OracleUpdate { get; set; }
        public virtual string SalesOrder { get; set; }
        public virtual string OpenOrder { get; set; }
        public virtual System.Nullable<byte> LocationCode { get; set; }
        public virtual System.Nullable<int> EdiRef { get; set; }
        public virtual System.Nullable<long> LabelPrint { get; set; }
    }
}
