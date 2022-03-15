using System;
using System.Collections.Generic;

namespace RestApi22.Models
{
    public partial class Login
    {
        public int LoginId { get; set; }
        public string UserName { get; set; } = null!;
        public string PassWord { get; set; } = null!;
    }
}
