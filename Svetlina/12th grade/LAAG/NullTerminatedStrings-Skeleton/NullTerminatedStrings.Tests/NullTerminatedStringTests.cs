using NUnit.Framework;

namespace NullTerminatedStrings.Tests
{
    public unsafe class NullTerminatedStringTests
    {
        private MemoryString memoryString;
        private string inputText;
        private char* input;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            this.memoryString = new MemoryString();
            this.inputText = "inputText";
            this.input = this.memoryString.StringToCharPointer(this.inputText);
        }

        [Test]
        public void Test_StringToCharPointer_CreatesCorrectPointer()
        {
            // Arrange:

            // Act:

            // Assert: strings are exact
            for (int i = 0; i < this.inputText.Length; i++)
            {
                Assert.That(this.inputText[i], Is.EqualTo(this.input[i]));

                if (i == this.inputText.Length - 1)
                {
                    Assert.That('\0', Is.EqualTo(this.input[i + 1]));
                }
            }
        }

        [Test]
        public void Test_strprint_PrintsCorrectly()
        {
            // Arrange:

            // Act: get print version of the pointer
            string actual = this.memoryString.strprint(this.input);

            // Assert: strings are exact
            Assert.That(actual, Is.EqualTo(this.inputText));
        }

        [Test]
        public void Test_strlen_ReturnsCorrectLength()
        {
            // Arrange: get string length
            int expected = this.inputText.Length;

            // Act: get length of pointer
            int actual = this.memoryString.strlen(this.input);

            // Assert: both lengths match
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Test_strcpy_CopiesCorrectly()
        {
            // Arrange: make second string for testing
            char* str = this.memoryString.StringToCharPointer("test");

            // Act: copy input onto str
            this.memoryString.strcpy(str, this.input);

            // Assert: both strings match
            Assert.That(this.memoryString.strprint(str), 
                Is.EqualTo(this.memoryString.strprint(this.input)));
        }

        [Test]
        public void Test_strcat_ConcatsCorrectly()
        {
            // Arrange: make second string for testing
            char* str = this.memoryString.StringToCharPointer("test");
            char* input = this.memoryString.StringToCharPointer("inputText");

            // Act: concat input at the end of str
            char* result = this.memoryString.strcat(str, this.input);
            string actual = this.memoryString.strprint(result);

            // Assert: string concat matches
            string expected = "testinputText";
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Test_strchr_ExistingLetter_ReturnsCorrectLetter()
        {
            // Arrange: create a character to be searched
            char expected = 't';

            // Act: invoke method
            char actual = *this.memoryString.strchr(this.input, expected);

            // Assert: both chars matches
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Test_strchr_NonExistingLetter_ReturnsCorrectLetter()
        {
            // Arrange: create a character to be searched
            char toSearch = 'z';

            // Act: invoke method
            char* actual = this.memoryString.strchr(this.input, toSearch);

            bool isNull = actual == null;
            // Assert: returned result is null
            Assert.That(isNull, Is.True);
        }

        [Test]
        public void Test_strcmp_FirstStringSmaller_ReturnsMinusOne()
        {
            // Arrange: make second string for testing
            char* str = this.memoryString.StringToCharPointer("test");

            // Act: compare both pointer strings
            int actual = this.memoryString.strcmp(this.input, str);

            // Assert: returned result is null
            Assert.That(actual, Is.EqualTo(-1));
        }

        [Test]
        public void Test_strcmp_BothStringsSame_ReturnsZero()
        {
            // Arrange:

            // Act: compare both pointer strings
            int actual = this.memoryString.strcmp(this.input, this.input);

            // Assert: returned result is null
            Assert.That(actual, Is.EqualTo(0));
        }

        [Test]
        public void Test_strcmp_FirstStringBigger_ReturnsOne()
        {
            // Arrange: make second string for testing
            char* str = this.memoryString.StringToCharPointer("Test");

            // Act: compare both pointer strings
            int actual = this.memoryString.strcmp(this.input, str);

            // Assert: returned result is null
            Assert.That(actual, Is.EqualTo(1));
        }
    }
}
