
namespace Lesson7
{
    /// <summary>
    /// Класс шифрует строку, выполняя замену каждой буквы, стоящей в английском алфавите на i-й позиции, 
    /// на букву того же регистра, расположенную в алфавите на i-й позиции с конца алфавита
    /// </summary>
    internal class BCode : ICode
    {

        public string Encode(string text)
        {
            char[] chars = text.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                if(chars[i] >= 'A' && chars[i] <= 'Z')
                {
                    chars[i] = (char)((int)'Z' - ((int)chars[i] - (int)'A'));
                } else if(chars[i] >= 'a' && chars[i] <= 'z')
                {
                    chars[i] = (char)((int)'z' - ((int)chars[i] - (int)'a'));
                }
            }
            return new string(chars);
        }

        public string Decode(string text)
        {            
            return Encode(text);
        }
    }
}
