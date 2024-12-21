using Microsoft.AspNetCore.OData;
using OData.Api.Util;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers()
    .AddOData(opt =>
    {
        opt.AddRouteComponents("odata", EdmModelBuilder.GetEdmModel());
        opt.Select().Filter().OrderBy().Expand().Count().SetMaxTop(100);
    });

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthorization();
app.MapControllers();

app.Run();
