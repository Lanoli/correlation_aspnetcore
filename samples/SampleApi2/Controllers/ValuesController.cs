﻿using Microsoft.AspNet.Mvc;
using Toolbox.Correlation;

namespace SampleApi2.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private ICorrelationContext _context;

        public ValuesController(ICorrelationContext context)
        {
            _context = context;
        }

        // GET: api/values
        [HttpGet]
        public object Get()
        {
            return new { Value = $"Result form SampleApi2: CorrelationId = {_context.Id}, CorrelationSourceId = {_context.SourceId}" };
        }
    }
}