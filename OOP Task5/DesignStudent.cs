namespace OOP_Task5
{
    public class DesignStudent:Student
    {
        public DesignStudent(string name, int no) : base(name, no) { }
       
        public override void DoHomework()
        {
            Console.WriteLine($"Branch:Design Student, FullName:{FullName} GroupNo:{GroupNo}");
        }
    }
}
