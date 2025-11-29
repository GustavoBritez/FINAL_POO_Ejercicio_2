using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Granja
{
    public class Gestionar_Granja
    {
        private BindingList<Animales> listaAnimales = new BindingList<Animales>();

        public event EventHandler AlimentarAnimales;

        public void AgregarAnimal(Animales ani)
        {
            var existe = (from dato in listaAnimales
                          where dato.Nombre == ani.Nombre
                          select dato).Any();

            if (existe)
            {
                throw new ArgumentException("No podemos agregar un animal que ya existe");
            }
            else
            {
                AlimentarAnimales += ani.Comer;
                listaAnimales.Add(ani);
            }
        }

        public void AlimentarTodos()
        {
            this.AlimentarAnimales?.Invoke(this,EventArgs.Empty);
        }

        public void Eliminar( Animales anim)
        {

            listaAnimales.Remove(anim);
            AlimentarAnimales -= anim.Comer;
        }
            
        public BindingList<Animales> ObtenerLista => listaAnimales;
    }
}
