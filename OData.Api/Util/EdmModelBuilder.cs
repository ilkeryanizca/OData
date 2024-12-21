using Microsoft.OData.Edm;
using Microsoft.OData.ModelBuilder;
using OData.Api.Model;

namespace OData.Api.Util
{
    public static class EdmModelBuilder
    {
        public static IEdmModel GetEdmModel()
        {
            var odataBuilder = new ODataConventionModelBuilder();
            odataBuilder.EntitySet<WeatherForecast>("WeatherForecast");
            return odataBuilder.GetEdmModel();
        }
    }
}
