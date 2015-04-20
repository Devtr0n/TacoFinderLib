using System;
using System.ServiceModel.Web;

namespace WcfJsonRestService
{
    public class Service1 : IService1
    {
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json,
                    UriTemplate = "data/{id}")]
        public Taco GetTaco(string id)
        {
            // lookup taco with the requested id 
            return new Taco()
            {
                Id = Convert.ToInt32(id),
                Name = "Tacos Al Pastor",
                TacoFillingType = 3,
                TacoFillingSubType = 1,
                TortillaType = 2,
                TortillaShellType = 4,
                SalsaType = 7,
                TacoToppingsType = 3
            };
        }
    }

    public class Taco
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TacoFillingType { get; set; }
        public int TacoFillingSubType { get; set; }
        public int TortillaType { get; set; }
        public int TortillaShellType { get; set; }
        public int SalsaType { get; set; }
        public int TacoToppingsType { get; set; }
    }
}