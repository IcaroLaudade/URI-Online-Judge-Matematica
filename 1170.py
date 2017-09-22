a=int(raw_input())
for i in range(a):
    b=float(raw_input())
    cont=0
    while b>1:
        b=b/2
        cont+=1
    print str(cont)+" dias"
    