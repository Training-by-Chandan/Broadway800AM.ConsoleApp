using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ECom
{
    public class SomeService : ISomeService, ITestService
    {
        public void FunctionOne()
        {
        }

        public void FunctionTwo()
        {
        }
    }

    public interface ISomeService
    {
        void FunctionOne();
    }

    public interface ITestService
    {
        void FunctionTwo();
    }
}
