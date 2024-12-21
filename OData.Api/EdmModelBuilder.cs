using Microsoft.OData.Edm;
using Microsoft.OData.ModelBuilder;

namespace OData.Api
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
