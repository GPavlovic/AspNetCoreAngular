using System.Collections.Generic;
using System.Threading.Tasks;
using AspNetCoreAngular.Controllers.Resources;
using AspNetCoreAngular.Models;
using AspNetCoreAngular.Persistence;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreAngular.Controllers
{
    public class FeaturesController : Controller
    {
        private readonly VegaDbContext _context;
        private readonly IMapper _mapper;
        public FeaturesController(VegaDbContext context, IMapper mapper)
        {
            this._mapper = mapper;
            this._context = context;
        }

        [HttpGet("/api/features")]
        public async Task<IEnumerable<FeatureResource>> GetFeatures()
        {
            var features = await _context.Features.ToListAsync();
            return _mapper.Map<List<Feature>, List<FeatureResource>>(features);
        }
    }
}