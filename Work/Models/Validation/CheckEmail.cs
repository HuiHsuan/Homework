using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace Work.Models.Validation
{
    public class CheckEmailAttribute : DataTypeAttribute
    {
        private 客戶資料Entities db = new 客戶資料Entities();
        public CheckEmailAttribute() : base(DataType.Text)
        {
            this.ErrorMessage = "已存在相同Email";
        }

        public override bool IsValid(object value)
        {
            string str = Convert.ToString(value);
            var email = db.客戶聯絡人.Where(p => p.Email == str);

            if (email != null)
            {
                return false;
            }
            return true;
        }
    }
}