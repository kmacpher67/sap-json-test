# sap-json-test
Azure HelloWorld Convert json Format Function

Post data to convert from one json format to another. 

PoC to evaluate FaaS, just to touch it and see it, pretty cool, basically create a trigger (web/queue), call your `MyService.doIt(req)` code that runs elsewhere but not fast enough, then scale the crap out of it. 
I'm not sure if you could just take a your `Domain` modules and drop the service layer into this native, but it would be interesting to see how much devops wiring a standard CRUD app would required to be integrated into this architecture. 

Supports multiple langs: C#, F#, Java, maybe ruby or js, like all the Azure stuff, the screens are busy and there's a ton of settings, bottom line, this was a PoC for evaluating event functions as a service for a job opp using C#. It validated the podcasts that I've listen to from AWS, Azure, and GCP about the concept of Function Services.  :) 

Now let's hope I don't get a $1mm bill from MS Azure cause my "free" account on Azure as already been used, even though when I did the "free" Functions did not even exist. 

Interesting side note, the samples show a great deal of Oxford Integrations (AI, ML, natural human processing functions.) maybe I'll fork for this for a future feature. 

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
