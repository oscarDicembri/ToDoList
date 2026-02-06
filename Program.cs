using ToDoList.Api.Services;

var builder = WebApplication.CreateBuilder(args);

// Servizi
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// CORS (solo per sviluppo)
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy
            .AllowAnyOrigin()
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});

// Dependency Injection
builder.Services.AddSingleton<ITaskService, TaskService>();

var app = builder.Build();

// Middleware
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// app.UseHttpsRedirection();

// ATTIVA CORS QUI
app.UseCors();

app.UseAuthorization();
app.MapControllers();

app.Run();
