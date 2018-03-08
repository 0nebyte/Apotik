using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apotik.Model
{
    public class Penjualan : BaseModel
    {
        public static string tableName = "tb_jual";
        

        public Penjualan()
        {
        }

        public Penjualan(int id, string faktur, int total, int sub_total, int diskon,
            int ppn, int grand_total)
        {
            Id = id;
            Faktur = faktur;
            Total = total;
            SubTotal = sub_total;
            Diskon = diskon;
            PPN = ppn;
            GrandTotal = grand_total;
        }

        [Attributes.Field(Name = "id_jual", PrimaryKey = true, AutoIncrement = true)]
        public virtual int Id { get; set; }

        [Attributes.Field(Name = "no_faktur", AllowNull = true)]
        public virtual string Faktur { get; set; }

        [Attributes.Field(Name = "total", AllowNull = true)]
        public virtual int Total { get; set; }

        [Attributes.Field(Name = "sub_total", AllowNull = true)]
        public virtual int SubTotal { get; set; }

        [Attributes.Field(Name = "diskon", AllowNull = true)]
        public virtual int Diskon { get; set; }

        [Attributes.Field(Name = "ppn", AllowNull = true)]
        public virtual int PPN { get; set; }

        [Attributes.Field(Name = "grand_total", AllowNull = true)]
        public virtual int GrandTotal { get; set; }

        public override string ToString()
        {
            return base.ToString() + "\n" +
                "\tid: " + Id + "\n" +
                "\tfaktur: " + Faktur + "\n" +
                "\ttotal: " + Total + "\n" +
                "\tsubtotal: " + SubTotal + "\n" +
                "\tdiskon: " + Diskon + "\n" +
                "\tppn: " + PPN + "\n" +
                "\tgrandtotal: " + GrandTotal;
        }
    }
}
