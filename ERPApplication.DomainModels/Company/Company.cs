using ERPApplication.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ERPApplication.DomainModels.Company
{
    public class Company
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public int BaseCurrency { get; set; }
        public int CreatedBy { get; set; }
        [ForeignKey("CreatedBy")]
        public virtual ApplicationUser Users
        {
            get;
            set;
        }
    }
}
