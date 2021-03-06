﻿using System;
using System.Collections.Generic;

namespace ComputerWeb.Models.EF1
{
    public partial class SystemUser
    {
        public int ObjId { get; set; }
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Pwd { get; set; }
        public int TheRole { get; set; }
        public string Email { get; set; }
        public string MobilePhone { get; set; }
        public string UserState { get; set; }

        public SystemRole TheRoleNavigation { get; set; }
    }
}
