namespace Demo
{
    public class Student : Person
    {
        private string school;
        private int heigth;

        public string School
        {
            get { return this.school; }
            set { this.school = value; }
        }
    }
}
