#By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, 
#we can see that the 6^(th) prime is 13.
#
#What is the 10001^(st) prime number?

def isPrime?(n)
	if n % 2 == 0
		return false
	end
	
	3.step(Math::sqrt(n), 2) do |i|
		if n % i == 0
			return false
		end
	end
	
	true
end

curr = 3
count = 2

while count < 10001
	curr+=2
	if isPrime?(curr)
		count+=1
	end
end

print curr