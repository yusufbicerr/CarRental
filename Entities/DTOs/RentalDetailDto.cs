﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class RentalDetailDto : IDto
    {
        public int RentalId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BrandName { get; set; }
        public string Description { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime ReturnDate { get; set; }
    }
}
