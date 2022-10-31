using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class TestSuite
    {
        private float result = 0.0f;
        

        [Test]
        public void TestAddition()
        {
            // Use the Assert class to test conditions

            result = Calculator.CalculatePair(5 , 2 , "+");
            Assert.AreEqual(result, 7);
        }
            
        [Test]
        public void TestSubtraction()
        {
            // Use the Assert class to test conditions

            result = Calculator.CalculatePair(5, 2, "-");
            Assert.AreEqual(result, 3);
        }

        [Test]
        public void TestMultiplication()
        {
            // Use the Assert class to test conditions

            result = Calculator.CalculatePair(5, 2, "*");
            Assert.AreEqual(result, 10);
        }

        [Test]
        public void TestDivision()
        {
            // Use the Assert class to test conditions

            result = Calculator.CalculatePair(5, 2, "/");
            Assert.AreEqual(result, 2.5f);
        }

        [Test]
        public void TestSquareRoot()
        {
            // Use the Assert class to test conditions

            result = Mathf.Sqrt(100);
            Assert.AreEqual(result, 10);
        }

        [Test]
        public void TestPower()
        {
            // Use the Assert class to test conditions

            result = Mathf.Pow(10, 2);
            Assert.AreEqual(result, 100);
        }


        [Test]
        public void TestSuiteSimplePasses()
        {
            // Use the Assert class to test conditions
        }

       
        [UnityTest]
        public IEnumerator TestSuiteWithEnumeratorPasses()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.   
            yield return null;
        }

        [UnityTest]
        public IEnumerator TestUnityAddition()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return null;

            result = Calculator.CalculatePair(5, 2, "+");
            Assert.AreEqual(result, 7);
        }
    }
}
