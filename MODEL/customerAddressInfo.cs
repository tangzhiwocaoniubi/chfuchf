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
    
    public partial class customerAddressInfo
    {
        public customerAddressInfo()
        {
            this.outWarehourse = new HashSet<outWarehourse>();
        }
    
        public string AddressNum { get; set; }
        public string AddressXinxi { get; set; }
        public string customerNum { get; set; }
        public string contacts { get; set; }
        public string phone { get; set; }
        public int isDel { get; set; }
    
        public virtual customer customer { get; set; }
        public virtual ICollection<outWarehourse> outWarehourse { get; set; }
    }
}
