using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScrapSettlement.DAL.Model
{
   public class Person

    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Key]
        public int Code { get; set; }
        public string Name { get; set; }

        public string pwd { get; set; }
      
        public DateTime EffectDate { get; set; }

      
        public Nullable<System.DateTime> FailuerDate
        {
            get;

            set;
        }
    }
}
