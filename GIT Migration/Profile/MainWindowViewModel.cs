using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Input;
using Services;

namespace Profile
{

    public class MainWindowViewModel : INotifyPropertyChanged
    {
        private string result;
        private string firstName;
        public event PropertyChangedEventHandler PropertyChanged;
        private IService service;

      

        public MainWindowViewModel()
        {
            Result = "Name Not Found";
            service = new Service();
        }

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        public string FirstName 
        {
            get
            {
                return firstName;
            }

            set
            {
                firstName = value;
                OnPropertyChanged(nameof(FirstName));
            }
        
        }

        private ICommand searchCommand;
        public ICommand SearchCommand
        {
            get
            {
                if(searchCommand == null)
                {
                    searchCommand = new RelayCommand(param => { Execute(); }, execute => { return CanExecute(); });
                }

                return searchCommand;
            }
        }

        private void Execute()
        {

           var profiles = service.GetProfileByFirstName(FirstName);

            if (profiles == null ||  !profiles.Any())
            {
                Result = "First name not matched";
            }

            else
            {
                string names = "Names List: \n";
                foreach (var profile in profiles)
                {
                    names += $"{profile.FirstName} { profile.LastName} \n";
                }

                Result = names.ToUpper();
            }
        }

        private bool CanExecute()
        {
            return service !=null && !string.IsNullOrEmpty(FirstName);
        }

        public string  Result 
        {
            get
            {
                return result;
            }

            set
            {
                result = value;
                OnPropertyChanged(nameof(Result));
            }
        
        }
    }
}
