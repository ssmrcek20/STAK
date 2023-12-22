using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commuting
{
    public class Prijevoz
    {
        public string Naziv { get; set; }
        public double Cijena { get; set; }
        public double Vrijeme { get; set; }
        public double PocetnaCijena { get; set; }
        public double Odrzavanje { get; set; }

        public Prijevoz(string naziv, double cijena, double vrijeme, double pocetnaCijena, double odrzavanje)
        {
            Naziv=naziv;
            Cijena=cijena;
            Vrijeme=vrijeme;
            PocetnaCijena=pocetnaCijena;
            Odrzavanje=odrzavanje;
        }
    }
}
