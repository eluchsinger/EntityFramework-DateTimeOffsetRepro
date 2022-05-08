using Microsoft.AspNetCore.Mvc;

namespace EF.Demo.SqlProvider.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private readonly ApplicationDbContext dbContext;

    public WeatherForecastController(ApplicationDbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    [HttpGet("")]
    public List<SomeDbModel> GetStuff()
    {
        dbContext.MyModels.Add(new SomeDbModel()
        {
            CreateDate = DateTime.Now,
            Name = Guid.NewGuid().ToString()
        });
        dbContext.SaveChanges();
        var models = dbContext.MyModels.ToList();
        return models;
    }
}