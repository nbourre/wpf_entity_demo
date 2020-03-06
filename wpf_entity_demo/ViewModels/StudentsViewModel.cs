using Demo.Business;
using Demo.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Demo.UI.ViewModels
{
    public class StudentsViewModel : BaseViewModel
    {
        StudentDataService data = new StudentDataService();
        ObservableCollection<Student> students;

        public ObservableCollection<Student> Students { 
            get => students;
            set {
                students = value;
                OnPropertyChanged();
            }
        }

        public StudentsViewModel()
        {
            Students = new ObservableCollection<Student>(data.GetAll());
        }




    }
}
