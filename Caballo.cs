using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Granja
{
    public class Caballo : Animales
    {
        private decimal energia;

        public Caballo(string nombre, string especie, Guid id, decimal _energia ) : base(nombre,especie,id)
        {
            this.energia = _energia;
        }

        public decimal Energia
        {
            get => this.energia;
            set
            {
                this.energia = value;
                OnProperty();
            }
        }

        public override void Comer(object sender, EventArgs e)
        {
            this.energia += this.energia * 0.20m;
        }
    }
}
