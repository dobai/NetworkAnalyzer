using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkAnalzyer
{
    class Data
    {
        DataTable tabulka;
        public Data()
        {
            tabulka = new DataTable();
            tabulka.Columns.Add("cislo", typeof(int));
            tabulka.Columns.Add("nazov", typeof(string));
            tabulka.Columns.Add("macZdroj", typeof(string));
            tabulka.Columns.Add("macCiel", typeof(string));
            tabulka.Columns.Add("typ", typeof(string));
            tabulka.Columns.Add("poznamka", typeof(string));
            tabulka.Columns.Add("paket", typeof(string));           
        }

        public DataTable vratTabulku()
        {
            return tabulka;
        }

        public void vlozZaznam(int cislo, string nazov, string macZdroj, string macCiel, string typ, string poznamka, string paket)
        {
            DataRow riadok = tabulka.NewRow();
            riadok["cislo"] = cislo;
            riadok["nazov"] = nazov;
            riadok["macZdroj"] = macZdroj;
            riadok["macCiel"] = macCiel;
            riadok["typ"] = typ;
            riadok["poznamka"] = poznamka;
            riadok["paket"] = paket;
            tabulka.Rows.Add(riadok);
        }
    }
}
