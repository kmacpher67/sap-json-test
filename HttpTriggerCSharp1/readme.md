# HttpTrigger - C<span>#</span>

The `HttpTrigger` makes it incredibly easy to have your functions executed via an HTTP call to your function.

## How it works

When you call the function, be sure you checkout which security rules you apply. If you're using an apikey, you'll need to include that in your request.

## Learn more

<TODO> Documentation


<a href="https://sap-json-test.azurewebsites.net/api/HttpTriggerCSharp1?code=mI1aIRrlgFqEQgw7dT9IJeDe4FTRo3RhynsMupAQzeleVZUwLAU9zQ=="
   target="_blank">
   GET URL
</a> 

Sample JSON
```{
    "name": "Roth Test Function",
    "address": "331 Central Parkway",
    "cityStateZip": "Warren, OH 44483",
    "area": 43000, 
    "contact": "Ken"
}```

<form action="https://sap-json-test.azurewebsites.net/api/HttpTriggerCSharp1?code=mI1aIRrlgFqEQgw7dT9IJeDe4FTRo3RhynsMupAQzeleVZUwLAU9zQ=="
      method="POST" name="myForm"
      enctype='application/json'>
    <p><label for="name">First Name:</label>
    <input type="text" name="name" id="name">Your Name Here!</p>

    <p><label for="address">address:</label>
    <input type="text" name="address" id="address"></p>

    <input value="Submit" type="submit" >
