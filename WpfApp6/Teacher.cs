using System.Collections.ObjectModel;

namespace WpfApp6
{
    internal class Teacher
    {
        public String TeacherName { get; set; }
        public ObservableCollection<Course> TeachingCourses { get; set; }
        public Teacher(String name)
        {
            TeacherName = name;
            TeachingCourses = new ObservableCollection<Course>();
        }
    }
}
