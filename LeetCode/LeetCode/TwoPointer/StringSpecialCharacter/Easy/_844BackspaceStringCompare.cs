using System.Text;

namespace LeetCode.TwoPointer.StringSpecialCharacter.Easy
{
    public static class _844BackspaceStringCompare
    {
        //O(M+N) Time
        //O(1) Space
        public static bool BackspaceCompare(string s, string t)
        {
            var i = s.Length - 1;
            var j = t.Length - 1;
            var skipS = 0;
            var skipT = 0;

            while (i >= 0 || j >= 0)
            {
                while (i >= 0)
                {
                    if (s[i] == '#')
                    {
                        skipS++;
                        i--;
                    }
                    else if (skipS > 0)
                    {
                        skipS--;
                        i--;
                    }
                    else
                    {
                        break;
                    }
                }
                while(j>=0)
                {
                    if (t[j] == '#')
                    {
                        skipT++;
                        j--;
                    }
                    else if (skipT > 0)
                    {
                        skipT--;
                        j--;
                    }
                    else 
                    {
                        break;
                    }
                }

                if (s[i] != s[j]) return false;
                i--;
                j--;
            }

            return true;
        }
    }
}
