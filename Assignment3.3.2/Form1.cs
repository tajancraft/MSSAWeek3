using System.ComponentModel;

namespace Assignment3._3._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            List<Student> students = new List<Student>();
            students.Add(new Student() { StudId = "1234", FirstName = "Yebin", LastName = "Kim", Address = "132 main", MonthOfAdmission = Month.March, Grade = 'A'});
            students.Add(new Student() { StudId = "2345", FirstName = "Chris", LastName = "Evans", Address = "123 Hollywood", MonthOfAdmission = Month.September, Grade = 'B' });


            var bindingList = new BindingList<Student>(students);
            var source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = source;
        }

    }
    public enum Month
    {
        January, February, March, April, May, June,
        July, August, September, October, November, December
    }
    public class Student
    {
        public string StudId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public Month MonthOfAdmission { get; set; }
        public char Grade { get; set; }
    }
    
}
