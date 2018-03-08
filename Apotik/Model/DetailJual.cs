using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apotik.Model
{
    public class DetailJual : BaseModel
    {
        public static string tableName = "tb_detail_jual";

        [Attributes.Reference(Type = typeof(Obat))]
        public Obat Obat { get; set; }

        [Attributes.Reference(Type = typeof(Penjualan))]
        public Penjualan Penjualan { get; set; }

        [Attributes.Field(Name = "qty", AllowNull = false)]
        public int Quantity { get; set; }
    }
}
