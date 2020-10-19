using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Coworking.Api.Application;
using Coworking.Api.Application.Contracts;
using Coworking.Api.Business;
using Indicadores.Api.DataAccess.Contracts.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoColasController : ControllerBase
    {
        private readonly ITipoColasService _tipoColasService;
        public TipoColasController(ITipoColasService tipoColasService)
        {
            _tipoColasService = tipoColasService;
        }

        [HttpGet]
       

        public async Task<IActionResult> GetAll()
        {
            try
            {
                return Ok(await _tipoColasService.GetAll());
            }
            catch (Exception e)
            {
                return NotFound();
            }
        }
       
      
        [HttpPost]
        public async Task<IActionResult> Post([FromBody]TipoColasModel tipoColas)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(new { Message = "Algunos campos no coinciden con el tipo de dato", ModelState });
           
                    await _tipoColasService.AddTipoColas(tipoColas);
                    return Ok(new { Message = "Datos registrados" });
                
                return BadRequest(new { Message = "El dato ya existe" });
            }
            catch (Exception e)
            {
                return BadRequest(new { Message = "comuniquese con el administardor del sistema" });
            }

        }

       
        [HttpPut]
        public async Task<IActionResult> Put([FromBody]TipoColasModel tipoColas)
        {
            try
            {
                if (tipoColas.TicId > 0)
                {
                    await _tipoColasService.UpdateTipoColas(tipoColas);
                    return Ok(new { Message = "Datos actualizados" });
                }
                return NotFound();
            }
            catch (Exception e)
            {
                return BadRequest(new { Message = "No se actualizaron los datos" });
            }
        }
    }

}