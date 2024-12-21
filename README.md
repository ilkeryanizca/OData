Weather Forecast API with .Net 8 And OData 🌤️
This project is a sample Web API application developed using .NET 8 and OData. In the project, you can easily manage weather forecast information with OData protocol by querying, filtering, sorting and other operations.

Features ✨
- OData Integration: OData capabilities such as filtering, sorting, and selecting are active.
- Dynamic Data Generation: Random weather data is generated.
- Flexible Query: OData queries such as $select, $filter, $orderby, $expand, $count are supported.
- Easy Extensibility: Suitable infrastructure for adding new data models and OData routes.

Getting Started 🚀
You can run the project in your local environment by following the steps below.

1. Requirements
.NET 8 SDK must be installed.

3. Clone the Project
git clone https://github.com/ilkeryanizca/OData.git
cd OData.Api

3. Install the Required Dependencies
dotnet restore

4. Run the Project
dotnet run

5. Test the API
Try the following URLs in your browser or with an API client like Postman:

All Data:
http://localhost:5000/odata/weatherforecast

Filtering Example:
http://localhost:5000/odata/weatherforecast?$filter=TemperatureC gt 20

Sorting Example:
http://localhost:5000/odata/weatherforecast?$orderby=TemperatureC desc

Selection Example:
http://localhost:5000/odata/weatherforecast?$select=Date,TemperatureC

Project Structure 🏗️
- Model/WeatherForecast.cs: Contains the weather forecast model.
- Constants/Definitions.cs: Contains temperature ranges and descriptions.
- Util/EdmModelBuilder.cs: Contains the EdmModel configuration required for OData.
- Controller/WeatherForecastController.cs: Provides OData endpoints for the API.
- Program.cs: Contains the application startup configuration.

Supported OData Features 🔧
- $filter: Filters the data.
- $orderby: Sorts the data.
- $select: Selects specific fields.
- $count: Returns the number of data.
- $expand: Expands the associated data.

Example OData Queries 📖
1. Temperature above 30°C forecast:
GET http://localhost:5000/odata/weatherforecast?$filter=TemperatureC gt 30

2. Sort by date (descending):
GET http://localhost:5000/odata/weatherforecast?$orderby=Date desc

3. Only Date and Temperature (Celsius):
GET http://localhost:5000/odata/weatherforecast?$select=Date,TemperatureC

4. Get the data count:
GET http://localhost:5000/odata/weatherforecast?$count=true

Contact 📬
If you have any questions or suggestions, you can contact with me:

E-mail: ilker.yanizca@yahoo.com.tr
