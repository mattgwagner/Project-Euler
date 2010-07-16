#Find the sum of all numbers, less than one million,
#which are palindromic in base 10 and base 2.
print (1...1000000).select{|x| x == x.to_s.reverse.to_i and x.to_s(2).to_i == x.to_s(2).reverse.to_i}.inject{|sum,x| sum += x}