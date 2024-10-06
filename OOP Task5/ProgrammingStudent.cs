namespace OOP_Task5
{
    internal class ProgrammingStudent:Student
    {
        public ProgrammingStudent(string fullname,int no):base(fullname, no)
        {
            
        }
        public override void DoHomework()
        {
            Console.WriteLine($"Branch:Programming Student, FullName:{FullName} GroupNo:{GroupNo}");
        }
    }
}
