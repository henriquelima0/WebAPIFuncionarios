using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.DataContext;
using WebAPI.Models;
using WebAPI.Service.FuncionarioService;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class FuncionarioController : ControllerBase
{
    private readonly IFuncionarioInterface _funcionarioInterface;
    public FuncionarioController(IFuncionarioInterface funcionarioInterface)
    {
        _funcionarioInterface = funcionarioInterface;
    }
    [HttpGet]
    public async Task<ActionResult<ServiceResponse<List<FuncionarioModel>>>> GetFuncionarios()
    {
        return Ok( await _funcionarioInterface.GetFuncionarios());
    }

    [HttpPost]
    public async Task<ActionResult<ServiceResponse<List<FuncionarioModel>>>> CreateFuncionario(FuncionarioModel novoFuncionario)
    {
        return Ok(await _funcionarioInterface.CreateFuncionario(novoFuncionario));
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<ServiceResponse<FuncionarioModel>>> GetFuncionarioById(int id)
    {
        return Ok(await _funcionarioInterface.GetFuncionarioById(id));
    }

    [HttpPut]
    public async Task<ActionResult<ServiceResponse<List<FuncionarioModel>>>> UpdateFuncionario(FuncionarioModel editadoFuncionario)
    {
        ServiceResponse<List<FuncionarioModel>> serviceResponse = await _funcionarioInterface.UpdateFuncionario(editadoFuncionario);

        return Ok(serviceResponse);

    }

    [HttpPut("inativaFuncionario")]
    public async Task<ActionResult<ServiceResponse<List<FuncionarioModel>>>> InativaFuncionario(int id)
    {
        ServiceResponse<List<FuncionarioModel>> serviceResponse = await _funcionarioInterface.InativaFuncionario(id);

        return Ok(serviceResponse);

    }

    [HttpDelete]
    public async Task<ActionResult<ServiceResponse<List<FuncionarioModel>>>> DeleteFuncionario(int id)
    {
        ServiceResponse<List<FuncionarioModel>> serviceResponse = await _funcionarioInterface.DeleteFuncionario(id);

        return Ok(serviceResponse);
    }
}
