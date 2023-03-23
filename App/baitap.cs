using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    internal class baitap
    {
        private string macauhoi;
        private string dapan1;
        private string dapan2;
        private string dapan3;
        private string dapan4;
        private string dapandung;
        private int dapanchon;
        private string cauhoi;
        public baitap() { 
            dapanchon = -1;
        }

        public string Macauhoi { get => macauhoi; set => macauhoi = value; }
        public string Dapan1 { get => dapan1; set => dapan1 = value; }
        public string Dapan2 { get => dapan2; set => dapan2 = value; }
        public string Dapan3 { get => dapan3; set => dapan3 = value; }
        public string Dapan4 { get => dapan4; set => dapan4 = value; }
        public string Dapandung { get => dapandung; set => dapandung = value; }
        public int Dapanchon { get => dapanchon; set => dapanchon = value; }
        public string Cauhoi { get => cauhoi; set => cauhoi = value; }
    }
}
