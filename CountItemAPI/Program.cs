var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapPost("/count", (List<string> items) =>
{
    var result = items
        .GroupBy(item => item)
        .ToDictionary(group => group.Key, group => group.Count());

    return Results.Json(result);
});

app.Run();