using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;

using DroidWeb.Areas.System.Models;
using DroidWeb.Data;
using DroidWeb.Data.Entities;
using DroidWeb.Services.Interfaces;
using DroidWeb.Utils.Extensions;

using Microsoft.Extensions.Logging;

namespace DroidWeb.Areas.System.Controllers
{
    [Area("System")]
    public class PositionController : Controller
    {
        private readonly ApplicationDbContext context;
        private readonly ILogger<PositionController> logger;
        private readonly IPositionService positionService;

        public PositionController(ApplicationDbContext context, ILogger<PositionController> logger, IPositionService positionService)
        {
            this.context = context;
            this.logger = logger;
            this.positionService = positionService;
        }

        public async Task<IActionResult> Index()
        {
            List<Position> positions = new List<Position>();

            if (this.positionService != null)
            {
                positions = await this.positionService.AcquirePosition();
                logger.LogDebug($"PositionController.GetHardwareModel: {positions.Count} positions found");
            }

            PositionModel model = new PositionModel();
            model.AcquiredPositions = positions;
            model.PrecisePosition = positions.GetPrecisePosition();

            return View(model);
        }
    }
}