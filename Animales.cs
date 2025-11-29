using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Granja
{
    public abstract class Animales : INotifyPropertyChanged
    {
        private string nombre;
        private string especie;
        private Guid id;

        private event EventHandler AlimentarHandler;
        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnProperty([CallerMemberName] string property = null )
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
        protected Animales(string nombre, string especie, Guid id)
        {
            this.nombre = nombre;
            this.especie = especie;
            Id = id;
        }

        public string Nombre
        {
            get => this.nombre; 
            set
            {
                this.nombre = value;
                OnProperty();
            }
        }

        public string Especie
        {
            get => this.especie;
            set
            {
                this.especie = value;
                OnProperty();
            }
        }

        public Guid Id
        {
            get => this.id;
            set
            {
                this.id = value;
                OnProperty();
            }
        }

        public abstract void Comer(object sender , EventArgs e );
    }
}
