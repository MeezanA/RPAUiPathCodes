function(element,input)
{
	const JSONObject = JSON.parse(input)
	
	
	
		document.querySelector('input[ng-reflect-name="labelFirstName"]').value = JSONObject['First Name']
		document.querySelector('input[ng-reflect-name="labelLastName"]').value = JSONObject['Last Name ']
		document.querySelector('input[ng-reflect-name="labelEmail"]').value = JSONObject['Email']
		document.querySelector('input[ng-reflect-name="labelRole"]').value = JSONObject['Role in Company']
		document.querySelector('input[ng-reflect-name="labelAddress"]').value = JSONObject['Address']
		document.querySelector('input[ng-reflect-name="labelPhone"]').value = JSONObject['Phone Number']
		document.querySelector('input[ng-reflect-name="labelCompanyName"]').value = JSONObject['Company Name']
		document.querySelector('input[type="submit"]').click()
	
}