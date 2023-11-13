using FeatureManagementExperiment.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.FeatureManagement.Mvc;
using System.Diagnostics;

namespace FeatureManagementExperiment.Controllers
{
    public class FeatureFlagOneController : Controller
    {
        private readonly ILogger<FeatureFlagOneController> _logger;

        public FeatureFlagOneController(ILogger<FeatureFlagOneController> logger) => _logger = logger;

        public IActionResult Index() => View();
    }
}
