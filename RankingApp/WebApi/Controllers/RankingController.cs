using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SharedData.Models;
using WebApi.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{


    [Route("api/[controller]")]
    [ApiController]
    public class RankingController : Controller
    {

        ApplicationDbContext _context;

        public RankingController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Create

        // Read
        [HttpGet]
        public List<GameResult> GetGameResults()
        {
            List<GameResult> results = _context.GameResults
                .OrderByDescending(item => item.Score)
                .ToList();

            return results;
                
        }

        [HttpGet("{id}")]
        public GameResult GetGameResults(int id)
        {
            GameResult result = _context.GameResults
                .Where(item => item.Id == id)
                .FirstOrDefault();

            return result;

        }


        // Update

        // Delete

    }
}

