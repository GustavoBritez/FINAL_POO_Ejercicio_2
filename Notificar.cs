using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Granja
{
    public class Notificar : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnProperty([CallerMemberName] string property = null )
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property) );
        }

    }
}
