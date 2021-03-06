﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ERPApplication.Models.DomainModels
{
    public class Company
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public int BaseCurrency { get; set; }
        public string CreatedBy { get; set; }
        [ForeignKey("CreatedBy")]
        public ApplicationUser User { get; set; }
    }
}
