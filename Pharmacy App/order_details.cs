//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Pharmacy_App
{
    using System;
    using System.Collections.Generic;
    
    public partial class order_details
    {
        public int order_id { get; set; }
        public int medicine_id { get; set; }
        public int quantity { get; set; }
    
        public virtual medicine medicine { get; set; }
        public virtual order order { get; set; }
    }
}
