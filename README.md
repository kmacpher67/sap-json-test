# sap-json-test
Azure HelloWorld Convert json Format Function

Post data to convert from one json format to another. 

Input format: 
```
{
    "name": "Roth Test Function",
    "address": "331 Central Parkway",
    "cityStateZip": "Warren, OH 44483",
    "area": 43000, 
    "contact": "Ken"
}
``` 
Output format: 
```
{
	"Name" : "Roth Test Function",
	"Address" : "331 Central Parkway",
	"CityStateZip" : "Warren, OH 44483",
	"BuildingSize" : 43000,
	"Caller" : "Ken",
	"CreateDate" : "2017-12-20T01:11:31.3669528+00:00"
}
```

Ajax post data to: 
https://sap-json-test.azurewebsites.net/api/HttpTriggerCSharp1?code=mI1aIRrlgFqEQgw7dT9IJeDe4FTRo3RhynsMupAQzeleVZUwLAU9zQ==
