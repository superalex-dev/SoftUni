using System;
using System.Text;

namespace NullTerminatedStrings
{
    public unsafe class MemoryString
    {
        // Method caller takes ownership
        public char* StringToCharPointer(string str)
        {
            str += '\0';
            fixed (char* strPtr = str)
            {
                return strPtr;
            }
        }

        public int strlen(char* str)
        {
            int len = 0;

            while (*str != '\0')
            {
                len++;
                str++;
            }

            return len;
        }

        public void strcpy(char* dest, char* src)
        {
            while (*src != '\0')
            {
                *dest = *src;
                src++;
                dest++;
            }

            *dest = '\0';
        }

        public string strprint(char* str)
        {
            StringBuilder sb = new StringBuilder();

            while (*str != '\0')
            {
                sb.Append(*str++);
            }

            return sb.ToString();
        }

        // Method caller takes ownership
        public char* strchr(char* str, char chr)
        {
            int offset = 0;

            while (*(str + offset) != '\0')
            {
                if (*(str + offset) == chr)
                {
                    return str + offset;
                }

                offset++;
            }

            return null;
        }

        public int strcmp(char* strOne, char* strTwo)
        {
            int offset = 0;

            while (strOne[offset] != '\0')
            {
                if (strOne[offset] != strTwo[offset])
                {
                    return (strOne[offset] < strTwo[offset]) ? -1 : 1;
                }
                offset++;
            }

            if (strTwo[offset] != '\0')
            {
                return -1;
            }

            return 0;
        }

        // Method caller takes ownership
        public char* strcat(char* dest, char* src)
        {
            char* p = dest;

            while (*p != '\0')
            {
                p++;
            }

            while (*src != '\0')
            {
                *p = *src;
                p++;
                src++;
            }

            *p = '\0';

            return dest;
        }

        private char* strptrsize(int size)
        {
            char[] chars = new char[size];

            fixed (char* ptr = chars)
            {
                return ptr;
            }
        }
    }
}