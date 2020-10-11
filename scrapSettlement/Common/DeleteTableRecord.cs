using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Entity;


namespace scrapSettlement.Common
{
  public  class DeleteTableRecord
    {
        //public void deleteSingleRecord(DataGridView qeuryRecord,DbContext dbContext)
        //{
        //    if (qeuryRecord.Rows.Count > 0)
        //    {
        //        string selected = qeuryRecord.SelectedRows[0].Cells[0].Value.ToString();
        //        if (DialogResult.Yes == MessageBox.Show("是否确定删除", "删除提醒", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
        //        {

        //            dbContext db = new dbContext();

        //            List<Coefficient> del = (from d in db.Coefficients
        //                                     where d.VoucherNO == selected
        //                                     select d).ToList<Coefficient>();
        //            //移除数据库的数据
        //            db.Coefficients.Remove(del[0]);
        //            db.SaveChanges();
        //            clearDate();

        //            //如果是在新增界面状态使用删除功能，则同时删除内存中的集合数据
        //            //数据库中的条件实体delCustomer不能成为内存中的待删除实体
        //            //即：customerList.Remove(delCustomer[0])返回false,故无法实现
        //            //内存当中的数据集记录删除;
        //            if (saveOrModifQueryFlag == saveOrChangeOrQueryMolde.save.ToString())
        //            {

        //                List<Coefficient> coefficients = archivesList.Where(c => c.VoucherNO == selected).ToList<Coefficient>();
        //                archivesList.Remove(coefficients[0]);

        //            }
        //            bind_gv_dateSource();
        //        }
        //    }

        //    return;
        //}

       
    }
}
