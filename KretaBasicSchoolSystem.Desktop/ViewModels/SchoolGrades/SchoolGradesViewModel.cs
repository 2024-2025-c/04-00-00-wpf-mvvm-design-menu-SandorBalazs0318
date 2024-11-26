using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using KretaBasicSchoolSystem.Desktop.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KretaBasicSchoolSystem.Desktop.ViewModels.SchoolGrades
{
    public partial class SchoolGradesViewModel: BaseViewModel
    {
        private ClassesTaughtViewModel _classesTaughtViewModel;
        private CurrentLessonViewModel _currentLessonViewModel;
        private EndofSemesterViewModel _endofSemesterViewModel;
        private EndofYearViewModel _endofYearViewModel;

        public SchoolGradesViewModel() 
        {
            _currentSchoolGradesChildView = new ClassesTaughtViewModel();
        }

        public SchoolGradesViewModel(CurrentLessonViewModel currentLessonViewModel, ClassesTaughtViewModel classesTaughtViewModel, EndofSemesterViewModel endofSemesterViewModel, EndofYearViewModel endofYearViewModel)
        {
            _classesTaughtViewModel = classesTaughtViewModel;
            _currentLessonViewModel = currentLessonViewModel;
            _endofSemesterViewModel = endofSemesterViewModel;
            _endofYearViewModel = endofYearViewModel;

            _currentSchoolGradesChildView = new ClassesTaughtViewModel();
        }

        [ObservableProperty]
        private BaseViewModel _currentSchoolGradesChildView;

        [RelayCommand]
        public void ShowClassesTaughtView()
        {
            CurrentSchoolGradesChildView = _classesTaughtViewModel;
        }

        [RelayCommand]
        public void ShowCurrentLessonViewModel()
        {
            CurrentSchoolGradesChildView = _currentLessonViewModel;
        }

        [RelayCommand]
        public void ShowEndofSemesterView()
        {
            CurrentSchoolGradesChildView = _endofSemesterViewModel;
        }

        [RelayCommand]
        public void ShowEndofYearViewModel()
        {
            CurrentSchoolGradesChildView = _endofYearViewModel;
        }
    }
}
