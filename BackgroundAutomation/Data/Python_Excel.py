import pandas as pd

def ExcelData(input1, input2):
    # Convert file path to lowercase for case-insensitive comparison
    input1_lower = input1.lower()
    
    if ".xlsx" in input1_lower or ".xlsm" in input1_lower or ".xltx" in input1_lower:  # Case 1
        # Read the Excel file with the specified sheet
        datam = pd.read_excel(input1, sheet_name=input2)
        
    elif ".xls" in input1_lower or ".xlx" in input1_lower:  # Case 2
        # Read the Excel file with the specified sheet
        datam = pd.read_excel(input1, sheet_name=input2, header=0, engine='xlrd')
        
    elif ".xlsb" in input1_lower:  # Case 3
        # Read the Excel file with the specified sheet
        datam = pd.read_excel(input1, sheet_name=input2, header=0, engine='pyxlsb')
        
    elif ".xlm" in input1_lower:  # Case 4
        # Read the Excel file with the specified sheet
        datam = pd.read_excel(input1, sheet_name=input2, header=0, engine='xlrd')
        
    elif ".ods" in input1_lower:  # Case 5
        # Read the Excel file with the specified sheet
        datam = pd.read_excel(input1, sheet_name=input2, header=0, engine='odf')
        
    elif ".csv" in input1_lower:  # Case 6 for CSV files
        # Read the CSV file
        datam = pd.read_csv(input1)
        
    else:
        raise ValueError(f"Unsupported file format: {input1}")

    # Convert all data in DataFrame to strings and then to JSON string
    datax = datam.astype(str).to_json(orient='records')
    
    return datax

