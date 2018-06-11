using System.Linq;

namespace Prototypes1
{
    public class MyFunctions
    {
        public string ReverseString(string myString)
        {
            string revString = myString;

            return new string(revString.ToCharArray().Reverse().ToArray());
        }
    }
}
