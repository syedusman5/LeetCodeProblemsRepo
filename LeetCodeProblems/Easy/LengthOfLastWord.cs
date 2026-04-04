namespace LeetCodeProblems.Easy
{
    internal class LengthOfLastWord
    {
        /*
         Given a string s consisting of words and spaces, return the length of the last word in the string.

            A word is a maximal substring consisting of non-space characters only.

            Example 1:

            Input: s = "Hello World"
            Output: 5
            Explanation: The last word is "World" with length 5.
            Example 2:

            Input: s = "   fly me   to   the moon  "
            Output: 4
            Explanation: The last word is "moon" with length 4.
            Example 3:

            Input: s = "luffy is still joyboy"
            Output: 6
            Explanation: The last word is "joyboy" with length 6.
 

            Constraints:

            1 <= s.length <= 104
            s consists of only English letters and spaces ' '.
            There will be at least one word in s
         */

        //Testcase 1 : "Hello World"
        //Testcase 2 : "   fly me   to   the moon  "
        //Testcase 3 : "luffy is still joyboy"


        public static int Solution(string s)
        {
            int result = 0;

            var words = s.Split(' ').ToList();

            string[] filtredWords = words.Where(x => x != "").ToArray();

            string lastWord = filtredWords[filtredWords.Length - 1];

            result = lastWord.Length;

            return result;
        }

        public static int SolutionTwo(string s)
        {
            string[] words = s.Split(" ");

            List<string> filteredWords = new List<string>();

            for(int i = 0; i < words.Length; i++)
            {
                if(words[i] != "")
                {
                    filteredWords.Add(words[i]);
                }
            }

            string lastWord = filteredWords[filteredWords.Count - 1];

            return lastWord.Length;
        }
    }
}
