import math

print("The work has been done by Chechet Mykyta, IC-92")

a = 0
b = math.pi
i = 1
total = 0

x = float(input("Enter x: "))
n = int(input("Enter a number of columns for integral."
              "It depends at accuracy of calculation: "))
round_numb = int(input("Enter the number of symbols after comma"
                       "to which is needed to round: "))

h = (b - a)/n

while i <= n:
    x_i = i * h - h / 2
    f_xi = math.log(2 + math.sin(x))
    total += h * f_xi
    i += 1

print("The result is ", round(total, round_numb))





