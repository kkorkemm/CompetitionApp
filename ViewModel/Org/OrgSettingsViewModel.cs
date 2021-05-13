using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitionApp.ViewModel.Org
{
    using MVVMCore;
    using Org.OrgSettings;

    class OrgSettingsViewModel : INotify
    {
        private object currentView;
        public object CurrentView
        {
            get { return currentView; }
            set 
            { 
                currentView = value;
                OnPropertyChanged();
            }
        }

        public OrgMainSettingsViewModel MainSettingsVM { get; set; }
        public OrgSettingsProtocolsViewModel ProtocolsVM { get; set; }
        public OrgSettingsExpertRolesViewModel ExpertRolesVM { get; set; }

        public Command MainSettingsCommand { get; set; }
        public Command ProtocolsCommand { get; set; }
        public Command ExpertRolesCommand { get; set; }

        public OrgSettingsViewModel()
        {
            MainSettingsVM = new OrgMainSettingsViewModel();
            ProtocolsVM = new OrgSettingsProtocolsViewModel();
            ExpertRolesVM = new OrgSettingsExpertRolesViewModel();

            CurrentView = MainSettingsVM;

            MainSettingsCommand = new Command(o =>
            {
                CurrentView = MainSettingsVM;
            });
            ProtocolsCommand = new Command(o =>
            {
                CurrentView = ProtocolsVM;
            });
            ExpertRolesCommand = new Command(o =>
            {
                CurrentView = ExpertRolesVM;
            });
        }
    }
}
