using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CompetitionApp.MVVMCore
{
    class INotify : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
