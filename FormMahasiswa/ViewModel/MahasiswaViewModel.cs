using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using FormMahasiswa.Model;

namespace FormMahasiswa.ViewModel
{
    internal class MahasiswaViewModel : ViewModelBase
    {
        private string name;
        private int age;
        private string contact;
        private string address;
        private ICommand saveCommand;
        private ICommand resetCommand;
        private ObservableCollection<Mahasiswa> dataContext;
        private string errorMessage;
        private Mahasiswa selectedItem;
        private ICommand deleteCommand;

        public string Name
        {
            get => name;
            set
            {
                name = value;
                OnPropertyChanged();
            }
        }

        public int Age
        {
            get => age;
            set
            {
                age = value;
                OnPropertyChanged();
            }
        }

        public string Address
        {
            get => address;
            set
            {
                address = value;
                OnPropertyChanged();
            }
        }

        public string Contact
        {
            get => contact;
            set
            {
                contact = value;
                OnPropertyChanged();
            }
        }
        public string ErrorMessage
        {
            get => errorMessage;
            set
            {
                errorMessage = value;
                OnPropertyChanged();
            }
        }
        public Mahasiswa SelectedItem
        {
            get => selectedItem;
            set
            {
                selectedItem = value;
                OnPropertyChanged();
            }
        }
        public ObservableCollection<Mahasiswa> DataContext
        {
            get => dataContext;
            set
            {
                dataContext = value;
                OnPropertyChanged();
            }
        }

        public ICommand SaveCommand { get => saveCommand; set => saveCommand = value; }
        public ICommand ResetCommand { get => resetCommand; set => resetCommand = value; }
        public ICommand DeleteCommand { get => deleteCommand; set => deleteCommand = value; }
        public MahasiswaViewModel()
        {
            dataContext = new ObservableCollection<Mahasiswa>();
            saveCommand = new ViewModelCommand(ExecuteSaveCommand, CanExecuteSaveCommand);
            resetCommand = new ViewModelCommand(ExecuteResetCommand, CanExecuteResetCommand);
            deleteCommand = new ViewModelCommand(ExecuteDeleteCommand, CanExecuteDeleteCommand);
        }
        private bool CanExecuteSaveCommand(object obj)
        {
            return !string.IsNullOrWhiteSpace(Name) &&
                !string.IsNullOrWhiteSpace(Address) &&
                !string.IsNullOrWhiteSpace(Contact) &&
                age > 0;
        }
        private void ExecuteSaveCommand(object obj)
        {
            try
            {
                foreach (var item in dataContext)
                {
                    if (item.Name == name &&
                        item.Contact == contact &&
                        item.Address == address &&
                        item.Age == age)
                    {
                        ErrorMessage = "The specified entities already exist! Please Reset";
                        return;
                    }
                }
                Mahasiswa mahasiswa = new()
                {
                    Name = name,
                    Address = address,
                    Contact = contact,
                    Age = age
                };
                DataContext.Add(mahasiswa);
                Name = string.Empty;
                Address = string.Empty;
                Contact = string.Empty;
                Age = 0;
            }
            catch (Exception e)
            {
                ErrorMessage = e.Message;
            }
        }
        private bool CanExecuteResetCommand(object obj)
        {
            return !string.IsNullOrWhiteSpace(Name) ||
                !string.IsNullOrWhiteSpace(Address) ||
                !string.IsNullOrWhiteSpace(Contact) ||
                age > 0;
        }
        private void ExecuteResetCommand(object obj)
        {
            try
            {
                Name = string.Empty;
                Address = string.Empty;
                Contact = string.Empty;
                Age = 0;
                ErrorMessage = string.Empty;
            }
            catch (Exception e)
            {
                ErrorMessage = e.Message;
            }
        }
        private bool CanExecuteDeleteCommand(object obj)
        {
            return dataContext.Any() && selectedItem != null;
        }
        private void ExecuteDeleteCommand(object obj)
        {
            try
            {
                DataContext.Remove(selectedItem);
            }
            catch (Exception e)
            {
                ErrorMessage = e.Message;
            }
        }




    }
}
