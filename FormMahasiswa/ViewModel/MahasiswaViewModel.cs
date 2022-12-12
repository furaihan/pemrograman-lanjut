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
        public MahasiswaViewModel()
        {
            dataContext = new ObservableCollection<Mahasiswa>();
            saveCommand = new ViewModelCommand(ExecuteSaveCommand, CanExecuteSaveCommand);
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
            Mahasiswa mahasiswa = new Mahasiswa();
            mahasiswa.Name = Name;
            mahasiswa.Address = Address;
            mahasiswa.Contact = Contact;
            mahasiswa.Age = age;
            DataContext.Add(mahasiswa);
        }





    }
}
