import math

def radians_to_degrees(rad):
	ans = rad * (180 / math.pi)
	return round(ans, 1)

rad = 1

print(radians_to_degrees(rad))