namespace CompetitionApp.ViewModel.Expert
{
    using MVVMCore;

    class ExpertProtocolsViewModel : INotify
    {
        private object сurrentView;

        public object CurrentView
        {
            get { return сurrentView; }
            set 
            { 
                сurrentView = value;
                OnPropertyChanged();
            }
        }

        public Command ProtocolFormCommand { get; set; }
        public Command ProtocolReportCommand { get; set; }

        public ExpertProtocolFormViewModel ProtocolFormVM { get; set; }
        public ExpertProtocolReportViewModel ProtocolReportVM { get; set; }


        public ExpertProtocolsViewModel()
        {
            ProtocolFormVM = new ExpertProtocolFormViewModel();
            ProtocolReportVM = new ExpertProtocolReportViewModel();

            CurrentView = ProtocolFormVM;

            ProtocolFormCommand = new Command(o =>
            {
                CurrentView = ProtocolFormVM;
            });
            ProtocolReportCommand = new Command(o =>
            {
                CurrentView = ProtocolReportVM;
            });
        }
    }
}
