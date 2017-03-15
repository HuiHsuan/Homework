using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace Work.Models.Validation
{
    public class MobleFormatAttribute : DataTypeAttribute
    {
        public MobleFormatAttribute() : base(DataType.Text)
        {
            this.ErrorMessage = "手機格式錯誤，請輸入09XX-XXXXXX";
        }

        public override bool IsValid(object value)
        {
            if (value is String)
            {
                return Regex.IsMatch(value.ToString(), "^[0-9]{4}-[0-9]{6}");
            }

            return true;
        }

    }
}