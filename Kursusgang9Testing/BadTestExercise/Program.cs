namespace BadListExercise
{   
    
    class Program
    {
        static void Main()
        {

        }
    }

    public class BadList 
    {
        private class Node
        {
            public Node(int data)
            {
                Data = data;
            }
            public int Data { get; }
            public Node Next { get; set; }
        }
        public BadList()
        {
            Head = null;
            Length = 0;
        }

        public int Length { get; private set; }
        private Node? Head { get; set; }

        /// <summary>
        /// Count elements that contains [number]
        /// </summary>
        /// <param name="number">Number to count</param>
        /// <returns></returns>
        public int CountNumbers(int number)
        {
            int count = 0;
            Node current = Head;
            while (current != null)
            {
                if (current.Data == number)
                    count++;
                current = current.Next;
            }
                
            return count;
        }

        public void Add(int i)
        {
            if(Head == null)
                Head = new Node(i);
            else
                GetNodeBefore(Length - 1).Next = new Node(i);
            Length++;
        }

        public int Get(int index)
        {
            return GetNodeAt(index).Data;
        }

        public void Remove(int index)
        {
            Node n = GetNodeBefore(index);
            n.Next = n.Next.Next;
            Length--;
        }

        public bool IsEmpty
        {
            get { return Head == null; }
        }

        public void InsertAt(int index, int value)
        {
            GetNodeBefore(index).Next = new Node(value) { Next = GetNodeAt(index) };
            Length++;
        }

        private Node GetNodeAt(int index)
        {
            Node result = GetNodeBefore(index + 1);
            return result;
        }
        private Node GetNodeBefore(int index)
        {
            try
            {
                Node current = Head;
                while (index-- > 0)
                {
                    if(current.Next != null)
                        current = current.Next;
                }
                return current;
            }
            catch (NullReferenceException)
            {
                throw new IndexOutOfRangeException(index.ToString());
            }
        }
    }
}