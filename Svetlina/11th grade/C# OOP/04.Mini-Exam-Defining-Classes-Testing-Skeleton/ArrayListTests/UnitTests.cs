using NUnit.Framework;
using System;
using UnitTesting;

namespace ArrayListTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_ArrayList_Constructor()
        {
            ArrayList arrayList = new ArrayList();
            Assert.AreEqual(2, arrayList.CountFreePositions());
        }

        [Test]
        public void Test_ArrayList_Add()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            Assert.AreEqual(1, arrayList.CountFreePositions());
            arrayList.Add(2);
            arrayList.Add(3);
            Assert.AreEqual(1, arrayList.CountFreePositions());
        }

        [Test]
        public void Test_Cut()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add(2);
            arrayList.Add(3);
            arrayList.Cut(2);
            Assert.AreEqual(1, arrayList.Count);
            Assert.That(() => 
            { 
                arrayList.Cut(2); 
            }, 
            Throws.TypeOf<ArgumentOutOfRangeException>());
            Assert.That(() =>
            {
                arrayList.Cut(-1);
            },
            Throws.TypeOf<ArgumentOutOfRangeException>());
        }

        [Test]
        public void Test_Change()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add(2);
            arrayList.Add(3);
            Assert.AreEqual(1, arrayList.Change(2, 4));
            Assert.AreEqual(-1, arrayList.Change(5, 4));
        }
    }
}