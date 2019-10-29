import math
from math import sqrt

print("The work has been done by Chechet Mykyta, IC-92")   # printing information about student

x_1 = float(input("First x coordinate = "))                # enter the coordinates
y_1 = float(input("First y coordinate = "))
x_2 = float(input("Second x coordinate = "))
y_2 = float(input("Second y coordinate = "))

round_up = int(input("Enter the round's number = "))       # BONUS: enter the round's number

R = sqrt((x_2 - x_1) ** 2 + (y_2 - y_1) ** 2)              # calculating the distance between two points

print("The distance between this points is ",
      math.ceil(R * 10**round_up)/(10**round_up))          # print the rounded result
