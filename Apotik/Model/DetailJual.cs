using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apotik.Model
{
    [Attributes.Table(TableName = "tb_detail_jual")]
    public class DetailJual : BaseModel
    {
        [Attributes.Reference(Type = typeof(Obat))]
        public virtual Obat Obat { get; set; }

        [Attributes.Reference(Type = typeof(Penjualan))]
        public virtual Penjualan Penjualan { get; set; }

        [Attributes.Field(Name = "qty", AllowNull = false)]
        public virtual int Quantity { get; set; }
    }
}
