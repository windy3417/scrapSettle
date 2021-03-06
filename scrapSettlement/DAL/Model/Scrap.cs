﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScrapSettlement.DAL.Model
{
   public class Scrap
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ScrapID { get; set; }
        [Key]
        public int ScrapCode { get; set; }
        public string ScrapName { get; set; }
      
        public DateTime EffectDate { get; set; }

      
        public Nullable<System.DateTime> FailuerDate
        {
            get;

            set;
        }
    }
}
