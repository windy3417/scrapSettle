using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScrapSettlement.DAL.Model
{
    public class Customer
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CustomerID { get; set; }
        [Key]
        public int CusCode { get; set; }
        public string CusName { get; set; }
        public DateTime EffectDate { get; set; }
        
        //实体类中的字段若设定为DateTime类型，其有默认的存储值0001-1-1 0:00:00
        //对其赋值仅仅是在基础值在加偏移量，故要避免此问题唯有设定Nullable泛型才能实现
        //该功能是通过DBfirst模式生成实体类发现的。


        //其它比如把数据库字段类型改为string,录入时采用正则校验；或存入数据库时把默认值
        //改为空（此方法只能是在sqlparameter中实现，使用EF的存储功能则无用）
        public Nullable<System.DateTime> FailuerDate { get;

            set; }
    }
}
