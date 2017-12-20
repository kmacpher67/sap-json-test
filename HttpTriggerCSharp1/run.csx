#r "Newtonsoft.Json"
using System.Net;
using Newtonsoft.Json;

public static async Task<HttpResponseMessage> Run(HttpRequestMessage req, TraceWriter log)
{
    log.Info("C# HTTP trigger function processed a request." + req.ToString());

    // parse query parameter
    string name = req.GetQueryNameValuePairs()
        .FirstOrDefault(q => string.Compare(q.Key, "name", true) == 0)
        .Value;

    // Get request body
    dynamic data = await req.Content.ReadAsAsync<object>();
    log.Info("dynamic data= " + data);

    HelloWorld helloWorld = new HelloWorld();
    if (null != data && data.name != null ) {
        helloWorld.Name = data.name ;
        helloWorld.Address = data.address;
        helloWorld.CityStateZip = data.cityStateZip;
        helloWorld.BuildingSize = data.area ?? 0;
        helloWorld.Caller = data.contact;
        helloWorld.CreateDate = data.createDate ?? DateTime.Now;
    } 
    else {
        helloWorld.Name = "fill name here";
    }

    return name == null
        ? req.CreateResponse(HttpStatusCode.BadRequest, "Please pass at least a name on the json object" + Newtonsoft.Json.JsonConvert.SerializeObject(helloWorld))
        : req.CreateResponse(HttpStatusCode.OK, helloWorld);
}
public class HelloWorld
{
    public string Name { get; set; }
    public string Address { get; set; }
    public string CityStateZip { get; set; }
    public int BuildingSize { get; set; }
    public string Caller { get; set; }
    public DateTime CreateDate { get; set; }
}