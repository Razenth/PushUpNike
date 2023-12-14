using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Controllers;
using API.Dtos;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Persistence.Data;

namespace API.Controller
//1. CarpetaApiNombre
//2. NombreEntidad
//3. Nombre en UnitOfWork, generalmente en plural
{
    public class DetallespedidoController : BaseController
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly NikeContext _context;

        public DetallespedidoController(IUnitOfWork unitOfWork, IMapper mapper, NikeContext context)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _context = context;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<DetallespedidoDto>>> Get()
        {
            var result = await _unitOfWork.Detallespedidos.GetAllAsync();
            return _mapper.Map<List<DetallespedidoDto>>(result);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<DetallespedidoDto>> Get(int id)
        {
            var result = await _unitOfWork.Detallespedidos.GetByIdAsync(id);

            if (result == null)
            {
                return NotFound();
            }

            return _mapper.Map<DetallespedidoDto>(result);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Detallespedido>> Post(DetallespedidoDto DetallespedidoDto)
        {
            var result = _mapper.Map<Detallespedido>(DetallespedidoDto);
            this._unitOfWork.Detallespedidos.Add(result);
            await _unitOfWork.SaveAsync();

            if (result == null)
            {
                return BadRequest();
            }
            DetallespedidoDto.Id = result.Id;
            return CreatedAtAction(nameof(Post), new { id = DetallespedidoDto.Id }, DetallespedidoDto);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<DetallespedidoDto>> Put(int id, [FromBody] DetallespedidoDto DetallespedidoDto)
        {
            if (DetallespedidoDto.Id == 0)
            {
                DetallespedidoDto.Id = id;
            }

            if(DetallespedidoDto.Id != id)
            {
                return BadRequest();
            }

            if(DetallespedidoDto == null)
            {
                return NotFound();
            }

             // Por si requiero la fecha actual
            /*if (DetallespedidoDto.Fecha == DateTime.MinValue)
            {
                DetallespedidoDto.Fecha = DateTime.Now;
            }*/

            var result = _mapper.Map<Detallespedido>(DetallespedidoDto);
            _unitOfWork.Detallespedidos.Update(result);
            await _unitOfWork.SaveAsync();
            return DetallespedidoDto;
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _unitOfWork.Detallespedidos.GetByIdAsync(id);

            if (result == null)
            {
                return NotFound();
            }

            _unitOfWork.Detallespedidos.Remove(result);
            await _unitOfWork.SaveAsync();
            return NoContent();
        }
    }
}