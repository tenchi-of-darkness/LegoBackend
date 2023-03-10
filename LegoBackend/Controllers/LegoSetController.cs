using Dapper;
using LegoBackend.Model;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;

namespace LegoBackend.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class LegoSetController : Controller
{
    [HttpGet]
    public ActionResult<IEnumerable<LegoSetEntity>> GetAll()
    {
        using var connection = new MySqlConnection("Server=localhost;Database=legoapp;User=root;Password=root");
        
        return Ok(connection.Query<LegoSetEntity>("SELECT * FROM lego_set"));
    }
}