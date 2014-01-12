import struct

f = open('C:\\Users\\aaron.CORP\\Documents\\GitHub\\tools\GIS\\sample.grd', 'rb')
if f.read(4) != b'DSBB':
    print("Not a Surfer 6 grid file")
else:
    print(str.format('Columns: {0}', struct.unpack('<H', f.read(2))[0]))
    print(str.format('Rows:    {0}', struct.unpack('<H', f.read(2))[0]))
    print(str.format('Minimum X value: {0}', struct.unpack('<d', f.read(8))[0]))
    print(str.format('Maximum X value: {0}', struct.unpack('<d', f.read(8))[0]))
    print(str.format('Minimum Y value: {0}', struct.unpack('<d', f.read(8))[0]))
    print(str.format('Maximum Y value: {0}', struct.unpack('<d', f.read(8))[0]))
    print(str.format('Minimum Z value: {0}', struct.unpack('<d', f.read(8))[0]))
    print(str.format('Maximum Z value: {0}', struct.unpack('<d', f.read(8))[0]))

    count = 0
    nextBytes = f.read(1)
    while nextBytes:
        count += 1
        nextBytes = f.read(1):
    print(str.format('Found {0} values', count))