using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

using DroidWeb.Areas.System.Models;
using DroidWeb.Data;
using DroidWeb.Data.Entities;
using DroidWeb.Services.Interfaces;
using DroidWeb.Services;

namespace DroidWeb.Areas.System.Controllers
{
    [Area("System")]
    public class HardwareController : Controller
    {
        private readonly ApplicationDbContext context;
        private readonly ILogger<HardwareController> logger;
        private readonly IEnumerable<IHostedService> hostedServices;
        private readonly IHardwareService hardwareService;

        public HardwareController(ApplicationDbContext context, ILogger<HardwareController> logger, IEnumerable<IHostedService> hostedServices)
        {
            this.context = context;
            this.logger = logger;
            this.hostedServices = hostedServices;

            if (this.hostedServices != null)
            {
                this.hardwareService = this.hostedServices.FirstOrDefault(s => s.GetType() == typeof(HardwareService)) as IHardwareService;
            }
        }

        // GET: System/Hardware
        public async Task<IActionResult> Index()
        {
            return await Task.Run(async () =>
            {
                List<Module> modules = new List<Module>();
                if (this.hardwareService != null)
                {
                    modules = await this.hardwareService.GetModules();
                    logger.LogDebug($"HardwareController.Index: {modules.Count} modules found");
                }

                HardwareModel model = new HardwareModel();
                model.Modules = modules;

                return View(model);
            });
        }

        public JsonResult GetTicks()
        {
            uint ticks = 0;
            if (this.hardwareService != null)
            {
                logger.LogDebug($"HardwareController.GetTicks: {ticks} ticks found");
            }

            return Json(ticks);
        }
    }
}
