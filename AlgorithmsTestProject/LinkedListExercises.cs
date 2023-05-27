using System.Security.Cryptography.X509Certificates;

namespace AlgorithmsTestProject
{
    public static class LinkedListExercises
    {
        public static int Count<T>(this IList<T> self)
        {
            return self.Enumerate().Count();
        }

        public static void Prepend<T>(this IList<T> self, T x)
        {
            self.Insert(self.GetIterator(), x);
        }

        public static IIterator<T> GetLastIterator<T>(this IList<T> self)
        {
            var iter = self.GetIterator();
            while (iter.HasValue())
                iter = iter.GetNext();
            return iter;
        }

        public static void Append<T>(this IList<T> self, T x)
        {
            self.Insert(self.GetLastIterator(), x);
        }

        public static T GetAt<T>(this IList<T> self, int index)
        {
            var i = 0; 
            var iter = self.GetIterator();
            while (iter.HasValue() && i < index)
            {
                iter = iter.GetNext();
                i += 1;
            }

            return iter.GetElement();
        }

        public static void SetAt<T>(this IList<T> self, int index, T element)
        {
            var i = 0;
            var iter = self.GetIterator();
            while (iter.HasValue() && i < index)
            {
                iter = iter.GetNext();
                i += 1;
            }

            self.Insert(iter, element);
        }

        public static void Swap<T>(this IList<T> self, int a, int b)
        {
            var tmp = self.GetAt(a);
            self.SetAt(a, self.GetAt(b));

        }

        public static IList<T> Reverse<T>()
        {
            throw new NotImplementedException();

        }

        public static IEnumerable<T> Enumerate<T>(this IList<T> self)
        {
            for (var iter = self.GetIterator(); 
                 iter.HasValue(); 
                 iter = iter.GetNext())
            {
                yield return iter.GetElement();
            }
        }
    }
}
