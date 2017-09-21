using System.Collections.Generic;

namespace _03.StackOfStrings
{
    public class StackOfStrings : List<string>
    {
        private List<string> data;

        public StackOfStrings()
        {
            this.data=new List<string>();
        }

        public void Push(string word)
        {
            this.data.Add(word);
        }

        public void Pop()
        {
            this.data.RemoveAt(this.data.Count-1);
        }

        public string Peek()
        {
            return this.data[this.data.Count - 1];
        }

        public bool IsEmpty()
        {
            return this.data.Count == 0 ? true : false;
        }
    }
}
