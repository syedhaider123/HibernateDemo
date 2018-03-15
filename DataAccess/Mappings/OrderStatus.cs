using System;
using System.Text;
using System.Collections.Generic;


namespace DataAccess {
    
    public partial class OrderStatus {
        public virtual int os_no { get; set; }
        public virtual string package_code { get; set; }
        public virtual OrderSheet1 order_sheet1 { get; set; }
        //public virtual MPackageCode1 m_package_code1 { get; set; }
        public virtual int record_id { get; set; }
        public virtual double order_quantity { get; set; }
        public virtual double defined_quantity { get; set; }
        public virtual double delivered_quantity { get; set; }
        public virtual double ready_quantity { get; set; }
        public virtual double order_qty_os { get; set; }
        public virtual double defined_qty_os { get; set; }
        public virtual double delivered_qty_os { get; set; }
        public virtual double stitch_quantity { get; set; }
        public virtual string stitch_completed { get; set; }
        public virtual string post { get; set; }
        public virtual string abnormal { get; set; }
        public virtual string complete { get; set; }
        public virtual double weighment_qty { get; set; }
        public virtual double stitch_quantity_bp { get; set; }
        public virtual double delivered_quantity1 { get; set; }
        #region NHibernate Composite Key Requirements
        public override bool Equals(object obj) {
			if (obj == null) return false;
			var t = obj as OrderStatus;
			if (t == null) return false;
			if (os_no == t.os_no
			 && package_code == t.package_code)
				return true;

			return false;
        }
        public override int GetHashCode() {
			int hash = GetType().GetHashCode();
			hash = (hash * 397) ^ os_no.GetHashCode();
			hash = (hash * 397) ^ package_code.GetHashCode();

			return hash;
        }
        #endregion
    }
}
