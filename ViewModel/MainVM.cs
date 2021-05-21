using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitionApp.ViewModel
{
    using MVVMCore;
    using Expert;
    using Org;
    using Base;

    class MainVM : INotify
    {

        private byte[] logo = CompetitionDBEntities.currentCompettion.Logo;

        public byte[] Logo
        {
            get { return logo; }
            set { logo = value; }
        }


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

        /// ГЛАВНЫЙ ЭКСПЕРТ
        public Command ExpertUserCommand { get; set; }
        public Command ExpertExpertCommand { get; set; }
        public Command ExpertProtocolCommand { get; set; }

        public ExpertUsersViewModel ExpertUsersVM { get; set; }
        public ExpertExpertsViewModel ExpertExpertVM { get; set; }
        public ExpertProtocolsViewModel ExpertProtocolsVM { get; set; }


        /// ОРГАНИЗАТОР
        public Command OrgUserCommand { get; set; }
        public Command OrgExpertCommand { get; set; }
        public Command OrgSettingCommand { get; set; }
        public Command OrgReportCommand { get; set; }

        public OrgUserViewModel OrgUserVM { get; set; }
        public OrgExpertViewModel OrgExpertVM { get; set; }
        public OrgSettingsViewModel OrgSettingVM { get; set; }
        public OrgReportViewModel OrgReportVM { get; set; }


        public MainVM()
        {
            /// ГЛАВНЫЙ ЭКСПЕРТ
            ExpertUsersVM = new ExpertUsersViewModel();
            ExpertExpertVM = new ExpertExpertsViewModel();
            ExpertProtocolsVM = new ExpertProtocolsViewModel();

            ExpertUserCommand = new Command(o =>
            {
                CurrentView = ExpertUsersVM;
            });

            ExpertExpertCommand = new Command(o =>
            { 
                CurrentView = ExpertExpertVM;
            });

            ExpertProtocolCommand = new Command(o =>
            {
                CurrentView = ExpertProtocolsVM;
            });


            /// ОРГАНИЗАТОР
            OrgUserVM = new OrgUserViewModel();
            OrgExpertVM = new OrgExpertViewModel();
            OrgSettingVM = new OrgSettingsViewModel();
            OrgReportVM = new OrgReportViewModel();

            OrgUserCommand = new Command(o =>
            {
                CurrentView = OrgUserVM;
            });

            OrgExpertCommand = new Command(o =>
            {
                CurrentView = OrgExpertVM;
            });

            OrgSettingCommand = new Command(o =>
            {
                CurrentView = OrgSettingVM;
            });

            OrgReportCommand = new Command(o =>
            {
                CurrentView = OrgReportVM;
            });

            /// Что первое выводится
            if (CompetitionDBEntities.currentUser.UserRoleID == 3)
            {
                CurrentView = ExpertUsersVM;
            }
            if (CompetitionDBEntities.currentUser.UserRoleID == 6)
            {
                CurrentView = OrgUserVM;
            }
        }
    }
}
