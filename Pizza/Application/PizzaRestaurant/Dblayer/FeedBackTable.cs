//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dblayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class FeedBackTable
    {
        public int FeedBackID { get; set; }
        public int UserID { get; set; }
        public string EmailAddress { get; set; }
        public string UserName { get; set; }
        public string FeedBack { get; set; }
    
        public virtual UserTable UserTable { get; set; }
    }
}
