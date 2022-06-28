﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TollSystem.Core.Entities
{
    class Contract
    {
        public Staff Staff { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }


        public Contract()
        {

        }

        public Contract(Staff staff, DateTime validFrom, DateTime validTo)
        {
            Staff = staff;
            ValidFrom = validFrom;
            ValidTo = validTo;
        }
    }
}