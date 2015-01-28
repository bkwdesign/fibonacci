using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace bkwdesign.web.math.tests
{
    [TestClass]
    public class UnitTestFibonacci
    {

        [TestMethod]
        public void WikiPediaTest_0()
        {
            long expected = 0;
            long input = 0;
            long output = bkwdesign.math.fibonacci.GetNthNumber(input);

            Console.WriteLine(String.Format("{0} yielded {1}", input, output));

            Assert.IsTrue(expected == output, "Entering 0 should have yielded 0");
        }

        [TestMethod]
        public void WikiPediaTest_1()
        {
            long expected = 1;
            long input = 1;
            long output = bkwdesign.math.fibonacci.GetNthNumber(input);

            Console.WriteLine(String.Format("{0} yielded {1}", input, output));

            Assert.IsTrue(expected == output, "Entering 1 should have yielded 1");
        }

        [TestMethod]
        public void WikiPediaTest_2()
        {
            long expected = 1;
            long input = 2;
            long output = bkwdesign.math.fibonacci.GetNthNumber(input);

            Console.WriteLine(String.Format("{0} yielded {1}", input, output));

            Assert.IsTrue(expected == output, "Entering 2 should have yielded 1");
        }

        [TestMethod]
        public void WikiPediaTest_3()
        {
            long expected = 2;
            long input = 3;
            long output = bkwdesign.math.fibonacci.GetNthNumber(input);

            Console.WriteLine(String.Format("{0} yielded {1}", input, output));

            Assert.IsTrue(expected == output, "Entering 3 should have yielded 2");
        }

        [TestMethod]
        public void WikiPediaTest_4()
        {
            long expected = 3;
            long input = 4;
            long output = bkwdesign.math.fibonacci.GetNthNumber(input);

            Console.WriteLine(String.Format("{0} yielded {1}", input, output));

            Assert.IsTrue(expected == output, "Entering 4 should have yielded 3");
        }

        [TestMethod]
        public void WikiPediaTest_5()
        {
            long expected = 5;
            long input = 5;
            long output = bkwdesign.math.fibonacci.GetNthNumber(input);

            Console.WriteLine(String.Format("{0} yielded {1}", input, output));

            Assert.IsTrue(expected == output, "Entering 5 should have yielded 5");
        }

        [TestMethod]
        public void WikiPediaTest_6()
        {
            long expected = 8;
            long input = 6;
            long output = bkwdesign.math.fibonacci.GetNthNumber(input);

            Console.WriteLine(String.Format("{0} yielded {1}", input, output));

            Assert.IsTrue(expected == output, "Entering 6 should have yielded 8");
        }

        [TestMethod]
        public void ArchwayTest_14()
        {
            long expected = 377;
            long input = 14;
            long output = bkwdesign.math.fibonacci.GetNthNumber(input);

            Console.WriteLine(String.Format("{0} yielded {1}", input, output));

            Assert.IsTrue(expected == output, "Entering 14 should have yielded 377");
        }

        [TestMethod]
        public void ArchwayTest_78()
        {
            long expected = 8944394323791463;
            long input = 78;
            long output = bkwdesign.math.fibonacci.GetNthNumber(input);

            Console.WriteLine(String.Format("{0} yielded {1}", input, output));

            Assert.IsTrue(expected == output, "Entering 78 should have yielded 8944394323791463");
        }
    }
}
