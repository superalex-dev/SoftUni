using System;
using NUnit.Framework;

namespace P01_Database
{
    [TestFixture]
    public class DatabaseTests
    {
        private Database database;

        [SetUp]
        public void SetUp()
        {
            database = new Database(new int[] { 1, 2, 3 });
        }

        [Test]
        public void TestConstructorWithMoreThan16Elements()
        {
            int[] elements = new int[20];

            Assert.Throws<InvalidOperationException>(() =>
            {
                database = new Database(elements);
            });
        }

        [Test]
        public void TestAdd()
        {
            database.Add(4);
            int[] elements = database.Fetch();

            Assert.AreEqual(4, elements[3]);
        }

        [Test]
        public void TestAddWithMoreThan16Elements()
        {
            int magicNumber = 16;

            for (int i = database.Count; i < 16; i++)
            {
                database.Add(magicNumber);
            }

            Assert.Throws<InvalidOperationException>(() => database.Add(magicNumber));
        }


        [Test]
        public void TestRemove()
        {
            database.Remove();
            int[] elements = database.Fetch();

            Assert.AreEqual(2, elements.Length);
            Assert.AreEqual(1, elements[0]);
            Assert.AreEqual(2, elements[1]);
        }

        [Test]
        public void TestRemoveFromEmptyDatabase()
        {
            for (int i = database.Count - 1; i >= 0; i--)
            {
                database.Remove();
            }

            Assert.Throws<InvalidOperationException>(() => database.Remove());
        }


        [Test]
        public void TestFetch()
        {
            int[] elements = database.Fetch();

            Assert.AreEqual(3, elements.Length);
            Assert.AreEqual(1, elements[0]);
            Assert.AreEqual(2, elements[1]);
            Assert.AreEqual(3, elements[2]);
        }
    }

    
}