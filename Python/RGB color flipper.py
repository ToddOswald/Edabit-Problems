def color_invert(rgb):
    r = rgb[0]
    g = rgb[1]
    b = rgb[2]
    r1 = abs(255 - r)
    r2 = abs(255 - g)
    r3 = abs(255 - b)
    return (r1, r2, r3)

rgb = (255, 0, 0)

print(color_invert(rgb)) 
