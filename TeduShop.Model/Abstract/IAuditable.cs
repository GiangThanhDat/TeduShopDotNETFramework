using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Model.Model
{
    interface IAuditable
    {
        DateTime? CreateDate { set; get; }
        string CreateBy { get; set; }
        DateTime? UpdateDate { set; get; }
        string UpdateBy { set; get; }
        string MetaKeyword { set; get; }
        string MetaDescription { set; get; }
        bool Status { set; get; }
    }
}
