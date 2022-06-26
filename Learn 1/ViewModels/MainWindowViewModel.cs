using Learn_1.ViewModels.Base;

namespace Learn_1.ViewModels
{
    class MainWindowViewModel : ViewModel
    {
        private string _Title = "окошко";

        /// <summary> Заголовок </summary>
        
        public string Title
        {
            get => _Title;

            set => Set(ref _Title, value);
        }
    }
}
