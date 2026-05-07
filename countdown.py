import time
print("New Year's countdown") #Title
time.sleep(1.5)

#collects number from user to determine when timer starts
countdown = int(input("Start countdown from:") )

#Countdown logic
while countdown > 0:
	print(countdown)
	time.sleep(1)
	countdown = countdown -1
print("Happy New Year!")
