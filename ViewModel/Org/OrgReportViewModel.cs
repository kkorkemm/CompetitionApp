namespace CompetitionApp.ViewModel.Org
{
    using MVVMCore;
    using Org.OrgReport;

    class OrgReportViewModel : INotify
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

        public Command ReportCommand { get; set; }
        public Command DetailedReportCommand { get; set; }

        public OrgMainReportViewModel ReportVM { get; set; }
        public OrgDetailedReportViewModel DetailedReportVM { get; set; }

        public OrgReportViewModel()
        {
            ReportVM = new OrgMainReportViewModel();
            DetailedReportVM = new OrgDetailedReportViewModel();

            CurrentView = ReportVM;

            ReportCommand = new Command(o =>
            {
                CurrentView = ReportVM;
            });
            DetailedReportCommand = new Command(o =>
            {
                CurrentView = DetailedReportVM;
            });
        }
    }
}
