using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.Entity;


namespace lab_122_db_wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Student student;
        public MainWindow()
        {
            InitializeComponent();
            Initialise();
        }
        void Initialise()
        {
            List<Student> students = new List<Student>();
            using (var db = new CollegeContext())
            {
                students = db.Students.ToList<Student>();
            }
            using (var db = new CollegeContext())
            {
                var student01 = new Student()
                {
                    StudentName = "Jeff",
                    Height = 200,
                    Weight = 140
                };
                db.Students.Add(student01);
                Lb01.ItemsSource = students;
                Lb01.DisplayMemberPath = "StudentName";
                db.SaveChanges();
            }
        }

        public void StudentSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            student = (Student)Lb01.SelectedItem;
            Selected.Text = $"Student ID: {student.StudentID}\n Name: {student.StudentName}\n Height: {student.Height}\n Weight: {student.Weight}";
            string name = student.StudentName;
        }
    }



    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public byte[] Photo { get; set; }
        public decimal Height { get; set; }
        public float Weight { get; set; }

        public Qualification Qualification { get; set; }
    }

    public class Qualification
    {
        public int QualificationId { get; set; }
        public string QualificationName { get; set; }
        public string Section { get; set; }

        public ICollection<Student> Students { get; set; }
    }

    public class CollegeContext : DbContext
    {
        // Constructor method : bounce responsibilty 
        // back up to Entity DbContext to do all the hard work
        public CollegeContext() : base("AdamsDb01")
        {
            // default blank
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Qualification> Qualifications { get; set; }
    }
}
