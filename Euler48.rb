#The series, 1^(1) + 2^(2) + 3^(3) + ... + 10^(10) = 10405071317.

#Find the last ten digits of the series, 1^(1) + 2^(2) + 3^(3) + ... + 1000^(1000).
sum=0

for i in (1...1000)
	sum+= (i**i)
end

print sum.to_s()[-10..-1]