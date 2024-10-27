def voltage(b,c,a):
   if a=='v':
    voltage=b*c
    return voltage
   elif a=='c':
    current=b/c
    return current
   elif a=='r':
    resistance=b/c


a=float(input("current value:"))
b=float(input("voltage value:"))
d=float(input("resistance: "))
e='v'
f='c'
g='r'
v=voltage(b,d,e)
c=voltage(b,d,f)
r=voltage(a,d,g)
print(v,c,r)