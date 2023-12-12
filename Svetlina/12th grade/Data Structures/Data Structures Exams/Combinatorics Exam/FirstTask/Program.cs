using System.Text;

namespace FirstTask
{ 
    public class Program
    {
        private static void Main(string[] args)
        {
            string input = "x1y2z";
            var result = GenerateMashup(input);
            foreach (var str in result)
            {
                Console.WriteLine(str);
            }
        }

        private static List<string> GenerateMashup(string input)
        {
            var result = new List<string>();
            Mashup(input, 0, new StringBuilder(), result);
            return result;
        }

        private static void Mashup(string input, int index, StringBuilder current, List<string> result)
        {
            if (index == input.Length)
            {
                result.Add(current.ToString());
                return;
            }

            if (Char.IsLetter(input[index]))
            {
                Mashup(input, index + 1, current.Append(char.ToUpper(input[index])), result);
                current.Remove(current.Length - 1, 1);
                
                Mashup(input, index + 1, current.Append(char.ToLower(input[index])), result);
                current.Remove(current.Length - 1, 1);
            }
            else
            {
                Mashup(input, index + 1, current.Append(input[index]), result);
                current.Remove(current.Length - 1, 1);
            }
        }
    }
}