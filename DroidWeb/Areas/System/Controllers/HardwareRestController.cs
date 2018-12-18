using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

using DroidWeb.Areas.System.Models;
using DroidWeb.Data;
using DroidWeb.Services.Interfaces;
using DroidWeb.Data.Entities;

namespace DroidWeb.Areas.System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HardwareRestController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        private readonly ILogger<HardwareRestController> logger;
        private readonly IHardwareService hardwareService;
        private readonly IRemoteControlService remoteControlService;

        public HardwareRestController(ApplicationDbContext context, ILogger<HardwareRestController> logger, IHardwareService hardwareService, IRemoteControlService remoteControlService)
        {
            this.context = context;
            this.logger = logger;
            this.hardwareService = hardwareService;
            this.remoteControlService = remoteControlService;
        }

        // GET: api/HardwareRest
        [HttpGet]
        public async Task<HardwareModel> GetHardwareModel()
        {
            List<HWModule> modules = new List<HWModule>();
            if (hardwareService != null)
            {
                modules = await hardwareService.GetModules();
                logger.LogDebug($"HardwareRestController.GetHardwareModel: {modules.Count} modules found");
            }

            HardwareModel model = new HardwareModel();
            model.Modules = modules;

            return model;
        }
    }
}