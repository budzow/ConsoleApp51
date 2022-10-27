using System;

namespace ConsoleApp51
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        void func(bool condition)
        {
            if (condition)  // Noncompliant
           DoTheThing();

            DoTheOtherThing();
            SomethingElseEntirely();

            Foo();
        }

        private void Foo()
        {
            throw new NotImplementedException();
        }

        private void SomethingElseEntirely()
        {
            throw new NotImplementedException();
        }

        private void DoTheOtherThing()
        {
            throw new NotImplementedException();
        }

        private void DoTheThing()
        {
            throw new NotImplementedException();
        }
    }
}
