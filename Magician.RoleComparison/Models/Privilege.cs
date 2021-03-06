﻿using System;

namespace Magician.RoleCompare.Models
{
    public class Privilege
    {
        public Guid PrivilegeId { get; set; }

        public string Name { get; set; }

        public string AccessRight { get; set; }

        public string LogicalName { get; set; }

        public string Depth { get; set; }
    }
}
