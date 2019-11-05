import math

x = float(input("Enter the x coordinate "))    # entering the first coordinate
y = float(input("Enter the y coordinate "))    # entering the second coordinate

if -1 <= x <= 1 and 0 <= y < 1:                # condition if point exists in allowable range
    if y >= math.fabs(x):                      # condition if point belongs to the graphic
        print("The point does exists")
    else:
        print("The point doesn't exists")
else:
    print("The point doesn't exists, because one of the coordinates is out of a system")
