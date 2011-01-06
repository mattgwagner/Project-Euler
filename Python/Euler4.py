largest = 0

def isPalindrome(x):
    return x == x[::-1]

for x in range(100,1000):
    for y in range(100,1000):
        if(isPalindrome(str(x*y))):
            if(x*y > largest):
                largest = x*y

print(largest)