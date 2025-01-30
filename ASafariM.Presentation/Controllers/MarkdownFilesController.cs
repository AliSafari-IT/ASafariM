using ASafariM.Application.DTOs;
using ASafariM.Domain.Entities;
using ASafariM.Domain.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace ASafariM.Presentation.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MarkdownFilesController : ControllerBase
{
    private readonly IMarkdownFilesService _markdownFilesService;
    private readonly IMapper _mapper;

    public MarkdownFilesController(IMarkdownFilesService markdownFilesService, IMapper mapper)
    {
        _markdownFilesService =
            markdownFilesService ?? throw new ArgumentNullException(nameof(markdownFilesService));
        _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<MarkdownFileResponseDto>>> GetAllMarkdownFiles()
    {
        var markdownFiles = await _markdownFilesService.GetAllMarkdownFiles();
        var response = _mapper.Map<IEnumerable<MarkdownFileResponseDto>>(markdownFiles);
        return Ok(response);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<MarkdownFileResponseDto>> GetMarkdownFileById(Guid id)
    {
        var markdownFile = await _markdownFilesService.GetMarkdownFileById(id);
        if (markdownFile == null)
            return NotFound();

        var response = _mapper.Map<MarkdownFileResponseDto>(markdownFile);
        return Ok(response);
    }

    [HttpPost]
    public async Task<ActionResult<MarkdownFileResponseDto>> CreateMarkdownFile(
        [FromBody] CreateMarkdownFileDto createDto
    )
    {
        var userIdClaim = User.Claims.FirstOrDefault(c => c.Type == "sub")?.Value;
        if (string.IsNullOrEmpty(userIdClaim) || !Guid.TryParse(userIdClaim, out var userId))
        {
            return Unauthorized("User ID not found in token claims");
        }

        var markdownFile = _mapper.Map<MarkdownFile>(createDto);
        var createdMarkdownFile = await _markdownFilesService.CreateMarkdownFile(
            markdownFile,
            userId
        );
        var response = _mapper.Map<MarkdownFileResponseDto>(createdMarkdownFile);
        return CreatedAtAction(nameof(GetMarkdownFileById), new { id = response.Id }, response);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<MarkdownFileResponseDto>> UpdateMarkdownFile(
        Guid id,
        [FromBody] CreateMarkdownFileDto updateDto
    )
    {
        var existingFile = await _markdownFilesService.GetMarkdownFileById(id);
        if (existingFile == null)
            return NotFound();

        _mapper.Map(updateDto, existingFile);
        var updatedMarkdownFile = await _markdownFilesService.UpdateMarkdownFile(existingFile);
        var response = _mapper.Map<MarkdownFileResponseDto>(updatedMarkdownFile);
        return Ok(response);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteMarkdownFile(Guid id)
    {
        var markdownFile = await _markdownFilesService.GetMarkdownFileById(id);
        if (markdownFile == null)
            return NotFound();

        await _markdownFilesService.DeleteMarkdownFile(id);
        return NoContent();
    }

    [HttpDelete]
    [Route("delete-many")]
    public async Task<IActionResult> DeleteMarkdownFiles([FromBody] IEnumerable<Guid> ids)
    {
        foreach (var id in ids)
        {
            await _markdownFilesService.DeleteMarkdownFile(id);
        }
        return NoContent();
    }
}
