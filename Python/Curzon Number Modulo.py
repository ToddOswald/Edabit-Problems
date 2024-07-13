def is_curzon(num):
    top = 2 ** num + 1
    bottom = 2 * num + 1

    if top % bottom == 0:
        return True
    else: 
        return False

num = 5
print(is_curzon(num))





# If number is curzon return true
# If number is not curzon return false
