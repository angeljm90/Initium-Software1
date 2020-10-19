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
    public class TicketController : ControllerBase
    {
        private readonly ITicketService _ticketService;
        public TicketController(ITicketService ticketService)
        {
            _ticketService = ticketService;
        }
        [HttpPut]
        public async Task<IActionResult> Put([FromBody]TicketModel ticket)
        {
            try
            {
                if (ticket.TikId > 0)
                {
                    await _ticketService.UpdateTicket(ticket);
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