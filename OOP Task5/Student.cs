namespace OOP_Task5
{
    public class Student
    {
        public string FullName { get; set; }
        public int GroupNo { get; set; }
        public Student(string fullname,int no)
        {
            FullName = fullname;
            GroupNo = no;
        }
        public virtual void DoHomework()
        {
            Console.WriteLine($"FullName:{FullName} GroupNo:{GroupNo} ");
        }
    }
}
