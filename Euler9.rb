##A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,
##a^(2) + b^(2) = c^(2)
##
##For example, 3^(2) + 4^(2) = 9 + 16 = 25 = 5^(2).
##
##There exists exactly one Pythagorean triplet for which a + b + c = 1000.
##Find the product abc.

def check a,b,c
	if (a + b + c == 1000) and (a < b and b < c)
		return (a**2 + b**2 == c**2)
	end
	
	false
end

for a in (1..1000)
	for b in (a..1000)
		c = Math.sqrt(a**2 + b**2)
		print (a*b*c) if check(a,b,c)
	end
end