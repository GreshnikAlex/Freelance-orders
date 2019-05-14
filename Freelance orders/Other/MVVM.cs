using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Freelance_orders.Other
{
    class MVVM : INotifyPropertyChanged
    {
        //INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "") => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
    }
}