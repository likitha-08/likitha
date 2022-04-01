using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationWithSql.Models;

namespace WebApplicationWithSql.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SampleController : ControllerBase
    {
        public SampleController(FileDbContext _fileDbContext)
        {
            FileDbContext = _fileDbContext;
        }

        public FileDbContext FileDbContext { get; }

        [HttpGet]
        public IEnumerable<FileTable1> Get()
        {
            return FileDbContext.FileTable1s.ToList();
        }
    }
}
