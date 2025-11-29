using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Granja
{
    public class Gallina : Animales
    {
        private decimal huevo;

        public Gallina(string nombre, string especie, Guid id, string huevo) : base(nombre, especie, id)
        {
            this.huevo = Convert.ToDecimal(huevo);
        }

        public decimal Huevo
        {
            get => this.huevo;
            set
            {
                this.huevo = value; OnProperty();
            }
        }

        public override void Comer(object sender, EventArgs e)
        {
            this.huevo += 10;
        }
       
    }
}
