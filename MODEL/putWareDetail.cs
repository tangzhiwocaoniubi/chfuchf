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
    
    public partial class putWareDetail
    {
        public string receiptNum { get; set; }
        public string productNum { get; set; }
        public long productCount { get; set; }
        public double totalMoney { get; set; }
        public string LocationNum { get; set; }
    
        public virtual Location Location { get; set; }
        public virtual product product { get; set; }
    }
}
