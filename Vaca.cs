using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Granja
{
    public class Vaca : Animales 
    {
        private decimal peso;
        
        public Vaca( string nombre, string especie, Guid nom ,decimal peso) : base(nombre, especie,nom)
        {
            this.peso = peso;
        }

        public decimal Peso
        {
            get => this.peso;
            set
            {
                this.peso = value;
                OnProperty();
            }
        }

        public override void Comer(object sender, EventArgs e)
        {
            this.peso += 10;
        }

    }
}
