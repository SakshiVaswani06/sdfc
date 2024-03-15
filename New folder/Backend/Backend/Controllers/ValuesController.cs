using Application.CQRS.Command;
using Application.CQRS.Queries;
using Application.DTO;
using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ApiController
    {
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] AddAssQues command)
        {
            return Ok(await Mediator.Send(command));
        }

        [HttpGet]
        public async Task<IEnumerable<AssDto>> Get()
        {
            return await Mediator.Send(new GetData());
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update([FromBody] EditQuestions editProperty)
        {
            return Ok(await Mediator.Send(editProperty));
        }
    }
}

//return Ok(await Mediator.Send(new EditQuestions { quedto = editProperty, Id = editProperty.i });
