using AutoMapper;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class ExampleController : ControllerBase
{
    private readonly IMapper _mapper;

    public ExampleController(IMapper mapper)
    {
        _mapper = mapper;
    }

    [HttpGet]
    public ActionResult<DestinationClass> GetMappedResult()
    {
        var source = new SourceClass { Id = 1, Name = "John" };
        var destination = _mapper.Map<DestinationClass>(source);

        return Ok(destination);
    }
}