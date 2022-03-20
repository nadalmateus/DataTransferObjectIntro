using AutoMapper;

using DataTransferObjectIntro.Dto;
using DataTransferObjectIntro.Profiles;
using DataTransferObjectIntro.Repositories;

using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<IUserRepository, UserRepository>();
builder.Services.AddAutoMapper(typeof(UserProfile));


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapGet("/user", async ([FromServices] IUserRepository repository, [FromServices] IMapper mapper) => mapper.Map<IEnumerable<UserDto>>(await repository.GetAllAsync()));

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
