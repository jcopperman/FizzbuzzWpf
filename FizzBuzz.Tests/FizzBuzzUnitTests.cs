using System;
using NUnit.Framework;
using FizzBuzzWpf;


namespace FizzBuzz.Tests
{
    [TestFixture]
    public class FizzBuzzUnitTests
    {
        [Test]       
        public void Given1Return1()
        {
            FizzbuzzCalculator calculator = new FizzbuzzCalculator();
            calculator.value = 1;
            calculator.Fizzbuzz();
            string expected = "1 ";
            string actual = calculator.output;
       
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void Given3Return12Fizz()
        {
            FizzbuzzCalculator calculator = new FizzbuzzCalculator();
            calculator.value = 3;
            calculator.Fizzbuzz();
            string expected = "1 2 Fizz ";
            string actual = calculator.output;

            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void Given5Return12Fizz4Buzz()
        {
            FizzbuzzCalculator calculator = new FizzbuzzCalculator();
            calculator.value = 5;
            calculator.Fizzbuzz();
            string expected = "1 2 Fizz 4 Buzz ";
            string actual = calculator.output;

            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void Given15ReturnFizzBuzz()
        {
            FizzbuzzCalculator calculator = new FizzbuzzCalculator();
            calculator.value = 15;
            calculator.Fizzbuzz();
            string expected = "1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz 11 Fizz 13 14 FizzBuzz ";
            string actual = calculator.output;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ForAge_Given31_Return8()
        {
            FizzbuzzCalculator calculator = new FizzbuzzCalculator();
            calculator.value = 15;
            calculator.Fizzbuzz();

            int expected = 8;
           
            Assert.AreEqual(expected, 2);
        }
    }
}
