

namespace Lesson7
{
    /// <summary>
    /// Класс шифрует строку посредством сдвига каждого символа на одну позицию 
    /// </summary>
    internal class ACode : ICode
    {
        public string Encode(string text)
        {
            char[] chars = text.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                chars[i]++;
            }
            return new string(chars); ;
        }

        public string Decode(string text)
        {
            return Encode(text);
        }
    }
}
