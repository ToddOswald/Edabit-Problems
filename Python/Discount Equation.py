def dis(price, discount):
    discount_decimal = discount / 100
    ans = (price - (price * discount_decimal))
    return round(ans, 2)

price = 100
discount = 75

print(dis(price, discount))  # Expected output: 90.0