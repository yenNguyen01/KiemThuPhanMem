import csv

with open ('DocFile.csv', 'w', newline='') as f:
    filename = ['user', 'password']
    writer = csv.DictWriter(f, fieldnames=filename)
    writer.writeheader()
    writer.writerow({'user':'1951052250', 'password':'0931184856'})


with open ('DocFile.csv', 'r', newline='') as f:
    reader = csv.DictReader(f)
    for row in reader:
        user = row['user']
        password = row['password']
        print(user)
        print(password)