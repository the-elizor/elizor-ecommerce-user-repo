﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace elizor.ecommerce.user.dbcontext.tables
{
    public partial class eep_t_currency
    {
        public eep_t_currency()
        {
            eep_t_client = new HashSet<eep_t_client>();
        }

        public string Id { get; set; }
        public string CurrencyCode { get; set; }
        public string CurrencyName { get; set; }
        public string DisplayName { get; set; }
        public sbyte Status { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }

        public virtual ICollection<eep_t_client> eep_t_client { get; set; }
    }
}