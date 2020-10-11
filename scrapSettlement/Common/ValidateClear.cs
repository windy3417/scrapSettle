using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ScrapSettlement.Common
{
    /// <summary>
    /// 数据非空验证与清空数据
    /// </summary>
     public class ValidateClear
    {
        /// <summary>
        /// 所有输入项均非空验证
        /// </summary>
        /// <param name="inputTablePanel"></param>
        /// <returns></returns>
        public bool inputVlidate(TableLayoutPanel inputTablePanel)
        {

            for (int i = 0; i < inputTablePanel.Controls.Count;)
            {
              
                    if (inputTablePanel.Controls[i].Text == "" || inputTablePanel.Controls[i].Text == null)
                    {
                        MessageBox.Show(inputTablePanel.Controls[i].Tag + "不能为空", "输入校验");
                        return false;
                    }
                

                i++;


            }
            return true;


        }

        public void clearDate(TableLayoutPanel inputTablePanel)
        {
            foreach (Control item in inputTablePanel.Controls)
            {

                //if (item.Name.Substring(0, 3) != "lbl")
                if (item.GetType() != typeof(Label))
                {
                    item.Text = "";
                }



            }
        }
    }
}
