﻿using System;
using System.Collections.Generic;
using System.Text;
using TollSystem.Infrastructure.Models;

namespace TollSystem.Core.Entities
{
    class AdministratorEntity : StaffEntity
    {
        public AdministratorEntity(Staff s) : base(s)
        {

        }
    }
}
