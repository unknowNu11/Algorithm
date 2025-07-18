T = int(input())
for x in range(T):
    H, W, N = map(int, input().split())
    X = N % H
    Y = N // H + 1
    if X == 0:
        X = H
        Y = N // H
    print(f"{X}{Y:02}")

        