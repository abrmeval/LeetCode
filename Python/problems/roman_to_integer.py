class Solution(object):
    def romanToInt(self, s):
        """
        :type s: str
        :rtype: int
        """
        lenght = len(s)
        chars = {'I': 1,'V': 5, 'X': 10, 'L': 50,'C': 100, 'D': 500, 'M': 1000}

        if lenght < 1 or lenght > 15:
            return 0
        
        num = 0
        for x in range(lenght - 1, -1, -1):
            current = chars.get(s[x])
            prev_index =   x + 1 

            if current is None:
                return 0
            
            if prev_index < lenght:
                prev =  chars[s[prev_index]]
                
                if current >= prev:
                    num += current
                else:
                    num -= current
            else:
                num =  current

            if  num > 3999:
                return 0
            
        return num  
    
print(Solution().romanToInt("III"))
print(Solution().romanToInt("IV"))
print(Solution().romanToInt("IX"))
print(Solution().romanToInt("LVIII"))
print(Solution().romanToInt("MCMXCIV"))
print(Solution().romanToInt("MMMCMXCIX"))
print(Solution().romanToInt("MMMMMCMXCIX"))