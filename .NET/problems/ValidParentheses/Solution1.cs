namespace ValidParentheses
{
    public class Solution1
    {
        public bool IsValid(string s)
        {
            //If string length is 1, it cannot be valid
            if (s.Length == 1)
                return false;

            var chars = new Dictionary<char, char>()
            {
                [')'] = '(',
                ['}'] = '{',
                [']'] = '[',
            };
            int y = 0;
            int countX = 0;
            int countY = 0;

            for (int x = 0; x < s.Length; x++)
            {
                //Check for opening brackets
                if (s[x] == '(' || s[x] == '{' || s[x] == '[')
                {
                    //Move the y pointer to point to the last opening bracket
                    y = x;
                    countY++;
                    continue;
                }

                //Else Check for closing brackets
                //Check if closing bracket is at the start
                if (x == 0)
                    return false;

                //Check if there is a matching opening bracket
                //If the closing bracket does not match the last opening bracket    
                if (y >= 0 && s[y] != chars[s[x]])
                    return false;

                y--;
                countX++;
            }
            //If number of opening brackets is equal to number of closing brackets
            return countY == countX;
        }
    }
}
