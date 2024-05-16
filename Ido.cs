using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather
{
    internal class Ido
    {
        public Ido(string r)
        {
            var v = r.Split(','); 
            this.varos =v[0];
            this.homerseklet = double.Parse(v[1].Replace('.',','));
            this.para = int.Parse(v[2]);
            this.szel = double .Parse(v[3].Replace('.', ','));

        }


        public string varos { get; set; }
        public double homerseklet { get; set; }
        public int para { get; set; }
        public double szel { get; set; }

        public override string ToString()
        {
            
            return $"{varos}  |  {homerseklet} C˙  |  {para}%  |  {szel}km/h\t";
        }
    }
}
