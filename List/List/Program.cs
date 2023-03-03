namespace List
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            MyList<int> list = new MyList<int>();
            list.Add(1);
            list.Add(3);
            list.Add(2);
            list.Add(4);
            list.Sort();
            list.AddRange(new int[] { 5, 6, 7, 8 });
            list.RemoveAt(3);
            list.Remove(2);
            Console.WriteLine(list.ToString());

            MyList<string> list2 = new MyList<string>();
            list2.Add("a");
            list2.Add("b");
            list2.Add("d");
            list2.Add("c");
            list2.Add("g");
            list2.Add("f");
            list2.Add("e");
            list2.Sort();
            list2.AddRange(new string[] { "a1", "b1", "c1", "d1" });
            list2.RemoveAt(3);
            list2.Remove("b1");

            Console.WriteLine(list2.ToString());
        }
    }
}