// See https://aka.ms/new-console-template for more information

class Program
{
    static void Main()
    {
        List<string> list = new List<string>() { "Hej", " med", " dig", " du", " ser", " da", " dum", " ud." };
        List<int> intList = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8};
        Console.WriteLine(JoinAll(list, (a, b) => a + b));
        Console.WriteLine(JoinAll(intList, (a,b) => a +b));
        Console.WriteLine(Exists( r => r == 9, intList));

        static string JoinThree(string str1, string str2, string str3, StringJoin joinDelegate)
        {
            string tempString = joinDelegate(str1, str2);
            return joinDelegate(tempString, str3);
        }

        static string JoinAllStrings(List<string> stringList, StringJoin joinDele)
        {
            string tempString = "";
            foreach (string str in stringList)
            {
                tempString = joinDele(tempString, str);
            }
            return tempString;
        }

        static T JoinAll<T>(List<T> tList, Join<T> joiner) 
            where T : notnull
        {
            T temp = tList[0];
            for(int i = 1; i < tList.Count; i++)
            {
                temp = joiner(temp, tList[i]);
            }
            return temp;
           
        }

        static bool Exists<T>(Predicate<T> f, List<T> a)
        {
            foreach (T item in a)
            {
                if (f(item))
                    return true;
            }
            return false;
        }

        static T Twice<T>(Func<T, T> f, T v)
        {
            v = f(v);
            v = f(v);
            return v;
        }
    }
}

delegate string StringJoin(string param1, string param2);
delegate T Join<T>(T param1, T param2);