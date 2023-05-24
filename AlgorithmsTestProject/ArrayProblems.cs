namespace AlgorithmsTestProject;

public static class ArrayProblems
{
    public static bool AreArraysEqual<T>(T[] xs, T[] ys)
    {
        return Object.Equals(xs, ys);
    }

    public static void Swap<T>(T[] xs, int a, int b)
    {
        if (xs.GetLength(0) < 2)
        {
            throw new IndexOutOfRangeException();
        }
        else
        {
            T tempa = xs[a];
            xs[a] = xs[b];
            xs[b] = tempa;
        }
    }

    public static T FirstElement<T>(T[] xs)
    {
        if (xs.GetLength(0) < 1)
        {
            throw new IndexOutOfRangeException();
        }
        else
        {
            return xs[0];
        }
    }

    public static T LastElement<T>(T[] xs)
    {
        if (xs.GetLength(0) < 1)
        {
            throw new IndexOutOfRangeException();
        }
        else
        {
            return xs[xs.GetLength(0) - 1];
        }
    }

    public static T MiddleElement<T>(T[] xs)
    {
        if (xs.GetLength(0) < 1)
        {
            throw new IndexOutOfRangeException();
        }
        else
        {
            return xs[xs.GetLength(0)/2];
        }
    }

    public static void Reverse<T>(T[] xs)
    {
        T[] tempx = new T[xs.GetLength(0)];
        Array.Copy(xs, tempx, xs.GetLength(0));

        for (int i = 0; i < xs.GetLength(0); i++)
        {
            xs[i] = tempx[xs.GetLength(0) - i - 1];
        }
    }

    public static int CountElement<T>(T[] xs, T element)
    {
        int counter = 0;
        foreach (T i in xs)
        {
            if(Object.Equals(element,i))
            {
                counter++;
            }
        }
        return counter;
    }

    public static string ToCommaDelimitedString<T>(T[] xs)
    {
        if (xs.GetLength(0) < 1)
        {
            return "";
        }
        else
        {
            string str = "";
            foreach (T i in xs)
            {
                str = $"{str},{i}";
            }
            str = str.Substring(1);

            return str;
        }
    }

    // Bonus problems

    public static int Count<T>(T[] xs, Func<T, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public static T Min<T>(T[] xs, Func<T, T, int> comparer)
    {
        throw new NotImplementedException();
    }

    public static T Max<T>(T[] xs, Func<T, T, int> comparer)
    {
        throw new NotImplementedException();
    }

    public static bool HasDuplicates<T>(T[] xs)
    {
        throw new NotImplementedException();
    }
}