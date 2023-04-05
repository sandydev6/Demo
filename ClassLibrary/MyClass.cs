using System;

namespace ClassLibrary
{
    public class MyClass
    {
        public MyClass()
        {
            
        }
        private void TestAnalyzer()
        {
            int i = 0;
            string msg = string.Empty;
            if (i == 1)
                i = 0;
            while (i == 0)
                msg = "please wait";
            for (int j = 0; j < 10; j++)
                i = 1 + j;
        }

        public virtual int data(int x, int y)
        {
            return (x + y);
        }
    }

    public class TestFxCopRule:MyClass
    {
        public override int data(int x, int y)
        {
            return (x + y) * 2;
        }
    }
}
