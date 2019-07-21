using System;

using ArxOne.MrAdvice.Advice;

namespace MrAdviceCore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            new TestClass().TestMethod();
            Console.ReadLine();
        }
    }

    public class TestClass
    {
        [Log]
        public void TestMethod()
        {
            Console.WriteLine("This is a call.");
        }
    }

	[AttributeUsage(AttributeTargets.Method, AllowMultiple = true, Inherited = false)]
	public class LogAttribute : Attribute, IMethodAdvice
	{
		public void Advise(MethodAdviceContext context)
		{
            Console.WriteLine("Before call.");
            context.Proceed();
            Console.WriteLine("After call.");
		}
	}
}
