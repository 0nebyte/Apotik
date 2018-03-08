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

        public Penjualan(int id, string id_dokter, string faktur, string id_obat, string qty, string total, 
            string sub_total, string diskon, string ppn, string grand_total)
        {
            Id = id;
            ID_Dokter = id_dokter;
            Faktur = faktur;
            Total = total;
            Sub_Total = sub_total;
            Diskon = diskon;
            PPN = ppn;
            Grand_Total = grand_total;
        }

        [Attributes.Field(Name = "id_jual", PrimaryKey = true, AutoIncrement = true)]
        public int Id { get; set; }

        [Attributes.Field(Name = "id_dokter", AllowNull = true)]
        public string ID_Dokter { get; set; }

        [Attributes.Field(Name = "no_faktur", AllowNull = true)]
        public string Faktur { get; set; }

        [Attributes.Field(Name = "total", AllowNull = true)]
        public string Total { get; set; }

        [Attributes.Field(Name = "sub_total", AllowNull = true)]
        public string Sub_Total { get; set; }

        [Attributes.Field(Name = "diskon", AllowNull = true)]
        public string Diskon { get; set; }

        [Attributes.Field(Name = "ppn", AllowNull = true)]
        public string PPN { get; set; }

        [Attributes.Field(Name = "grand_total", AllowNull = true)]
        public string Grand_Total { get; set; }

        public override string ToString()
        {
            return base.ToString() + "\n" +
                "\tid: " + Id + "\n" +
                "\tIdDokter: " + ID_Dokter + "\n" +
                "\tfaktur: " + Faktur + "\n" +
                "\ttotal: " + Total + "\n" +
                "\tsubtotal: " + Sub_Total + "\n" +
                "\tdiskon: " + Diskon + "\n" +
                "\tppn: " + PPN + "\n" +
                "\tgrandtotal: " + Grand_Total;
        }
    }
}
