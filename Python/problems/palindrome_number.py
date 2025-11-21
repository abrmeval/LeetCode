class Solution(object):
    def isPalindrome(self, x):
        """
        :type x: int
        :rtype: bool
        """

        if(x < -2**31 or  x > 2**31 -1):
            return False
        if x < 0:
            return False
        if x <= 9:
            return True
        
        reversed_num = 0
        xcopy = x

        while xcopy > 0:
            digit = xcopy % 10  # Get the last digit
            reversed_num = reversed_num * 10 + digit # Add digit to reversed number
            xcopy //= 10  # Remove the last digit

        return x != reversed_num
  
print(Solution().isPalindrome(121))
print(Solution().isPalindrome(-121))
print(Solution().isPalindrome(10))
print(Solution().isPalindrome(313))
print(Solution().isPalindrome(1122))

## Test cases
# Input: x = 121
# Output: True
# Explanation: 121 is a palindrome.
# Desktop Test: 
#   121 % 10 = 1
#   reversed_num = 0 * 10 + 1 = 1
#   121 // 10 = 12
#   xcopy = 12 
#   12 % 10 = 2
#   reversed_num = 1 * 10 + 2 = 12
#   12 // 10 = 1
#   xcopy = 1
#   1 % 10 = 1
#   reversed_num = 12 * 10 + 1 = 121
#   1 // 10 = 0
#    xcopy = 0

# Input: x = -121
# Output: False
# Explanation: -121 is not a palindrome.

# Input: x = 10
# Output: False
# Explanation: 10 is not a palindrome.

# Input: x = 313
# Output: True
# Explanation: 313 is a palindrome.
# Desktop Test: 
#   313 % 10 = 3
#   reversed_num = 0 * 10 + 3 = 3
#   313 // 10 = 31
#   xcopy = 31
#   31 % 10 = 1
#   reversed_num = 3 * 10 + 1 = 31
#   31 // 10 = 3
#   xcopy = 3
#   3 % 10 = 3
#   reversed_num = 31 * 10 + 3 = 313
#   3 // 10 = 0
#    xcopy = 0

# Input: x = 1122
# Output: False
# Explanation: 1122 is not a palindrome.

