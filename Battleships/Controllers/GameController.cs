using Battleships.Models;
using Battleships.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Battleships.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameController : ControllerBase
    {
        private readonly IGameService _gameService;

        public GameController(IGameService gameService)
        {
            _gameService = gameService; 
        }

        // GET: api/<GameController>
        [HttpGet]
        public List<Board> GetGame()
        {
            return _gameService.GetGame();
        }

    }
}
