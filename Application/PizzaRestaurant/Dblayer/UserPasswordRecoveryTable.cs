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
    
    public partial class UserPasswordRecoveryTable
    {
        public int UserPasswordRecoveryID { get; set; }
        public int UserID { get; set; }
        public string RecoveryCode { get; set; }
        public System.DateTime RecoveryCodeExpiryDateTime { get; set; }
        public bool RecoveryStatus { get; set; }
        public string OldPassword { get; set; }
    
        public virtual UserTable UserTable { get; set; }
    }
}