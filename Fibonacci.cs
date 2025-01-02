// Fibonacci Sequance
using System.Linq.Expressions;
using System.Security.Principal;

static int Fibonacci(int n)
{   
    if (n <= 1)
    {
        return n;
    }
    return Fibonacci(n - 1) + Fibonacci(n - 2);
}

static List<int> FibonacciSequence(int n)
{
    n--;
    List<int> lst = new List<int>();
    int t1=1, t2=2, t3;
    if(n>0)
    {
        lst.Add(0);
        n--;
        if(n>0)
        {
            lst.Add(1);
            n--;
            if(n>0)
            {
                lst.Add(1);
                n--;
                if(n>0)
                {
                    lst.Add(2);
                    n--;
                    if(n>0)
                    {
                        while(n>=0)
                        {
                            t3 = t1 + t2;
                            lst.Add(t3);
                            t1 = t2;
                            t2 = t3;
                            n--;
                        }
                    }
                }
            }
        }
    }
    return lst;
}


Console.Write("Enter the number: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Here is the number in Fibonacci sequence: "+Fibonacci(n-1));
Console.Write("Here is the Fibonacci sequence up to your number: ");
foreach(int i in FibonacciSequence(n))
{
    Console.Write(i+",");
}