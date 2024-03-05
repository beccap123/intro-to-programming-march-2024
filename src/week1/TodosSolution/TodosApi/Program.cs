using Microsoft.AspNetCore.Mvc;
using TodosApi;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// GET /status
app.MapGet("/status", () =>
{
    return Results.Ok();
});

app.MapPost("/todos", ([FromBody] TodoCreateRequest request) =>
{
    // look at the content they sent and validate it
    // if it's not "valid", send thema 400 response
    // if it is valid, 
    //   - Assign an ID to it
    //   - Save it somewhere (database?)
    //   - Send it back to them

    //send fake response
    var response = new TodoCreateResponse
    {
        Id = Guid.NewGuid(),
        Description = request.Description,
        Status = TodoStatus.Incomplete
    };
    return Results.Ok(response);
});

//Console.WriteLine("Fixin' to start the server");
app.Run(); // starts server and just listens for requests
//Console.WriteLine("Done running the server");

public partial class Program { }
