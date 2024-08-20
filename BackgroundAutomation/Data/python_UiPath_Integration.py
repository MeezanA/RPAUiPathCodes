import pandas as pd;

filePath = input("enter the path")
exceldata = pd.read_excel(filePath,engine='xlrd')
print(exceldata)

