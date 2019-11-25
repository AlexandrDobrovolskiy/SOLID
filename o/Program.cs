using System;

namespace o
{
    interface ILibraryMiddleware {
        void onOperation(int middleValue);
    }
    class Library {
        private ILibraryMiddleware[] _middleware;
        public Library(ILibraryMiddleware[] middleware)
        {
            this._middleware = middleware;
        }

        public void Operation() {
            // ... Some operation logic

            var someMiddleValue = 3;

            foreach (ILibraryMiddleware middleware in this._middleware) {
                middleware.onOperation(someMiddleValue);
            }

            // ... Rest operation

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
