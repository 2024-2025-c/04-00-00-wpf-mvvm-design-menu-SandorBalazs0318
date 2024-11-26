using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using KretaBasicSchoolSystem.Desktop.ViewModels.Base;

namespace KretaBasicSchoolSystem.Desktop.ViewModels.SchoolCitizens
{
    public partial class SchoolCitizensViewModel : BaseViewModel
    {
        private StudentViewModel _studentViewModel;
        private TeacherViewModel _teacherViewModel;
        private ParentViewModel _parentViewModel;

        public SchoolCitizensViewModel()
        {
            _currentSchoolCitizensChildView = new StudentViewModel();

            _studentViewModel = new StudentViewModel();
            _teacherViewModel = new TeacherViewModel();
            _parentViewModel = new ParentViewModel();
        }

        public SchoolCitizensViewModel(StudentViewModel studentViewModel, TeacherViewModel teacherViewModel, ParentViewModel parentViewModel)
        {
            _studentViewModel = studentViewModel;
            _teacherViewModel = teacherViewModel;
            _parentViewModel = parentViewModel;

            _currentSchoolCitizensChildView = new StudentViewModel();
        }

        [ObservableProperty]
        private BaseViewModel _currentSchoolCitizensChildView;

        [RelayCommand]
        public void ShowStudentView()
        {
            CurrentSchoolCitizensChildView = _studentViewModel;
        }

        [RelayCommand]
        public void ShowTeacherView()
        {
            CurrentSchoolCitizensChildView = _teacherViewModel;
        }

        [RelayCommand]
        public void ShowParentView()
        {
            CurrentSchoolCitizensChildView = _parentViewModel;
        }
    }
}
