//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MODEL
{
    using System;
    using System.Collections.Generic;
    
    public partial class supplier
    {
        public supplier()
        {
            this.putWarehourse = new HashSet<putWarehourse>();
        }
    
        public string supplierNum { get; set; }
        public string supplierLeix { get; set; }
        public string supplierName { get; set; }
        public string phone { get; set; }
        public string chuanzhen { get; set; }
        public string email { get; set; }
        public string contacts { get; set; }
        public string address { get; set; }
        public string contents { get; set; }
        public int isDel { get; set; }
    
        public virtual ICollection<putWarehourse> putWarehourse { get; set; }
        public virtual supplierLeix supplierLeix1 { get; set; }
    }
}
