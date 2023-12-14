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
    public class TransaccionesController : BaseController
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly NikeContext _context;

        public TransaccionesController(IUnitOfWork unitOfWork, IMapper mapper, NikeContext context)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _context = context;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<TransaccionesDto>>> Get()
        {
            var result = await _unitOfWork.Transacciones.GetAllAsync();
            return _mapper.Map<List<TransaccionesDto>>(result);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<TransaccionesDto>> Get(int id)
        {
            var result = await _unitOfWork.Transacciones.GetByIdAsync(id);

            if (result == null)
            {
                return NotFound();
            }

            return _mapper.Map<TransaccionesDto>(result);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Transacciones>> Post(TransaccionesDto TransaccionesDto)
        {
            var result = _mapper.Map<Transacciones>(TransaccionesDto);
            this._unitOfWork.Transacciones.Add(result);
            await _unitOfWork.SaveAsync();

            if (result == null)
            {
                return BadRequest();
            }
            TransaccionesDto.Id = result.Id;
            return CreatedAtAction(nameof(Post), new { id = TransaccionesDto.Id }, TransaccionesDto);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<TransaccionesDto>> Put(int id, [FromBody] TransaccionesDto TransaccionesDto)
        {
            if (TransaccionesDto.Id == 0)
            {
                TransaccionesDto.Id = id;
            }

            if(TransaccionesDto.Id != id)
            {
                return BadRequest();
            }

            if(TransaccionesDto == null)
            {
                return NotFound();
            }

             // Por si requiero la fecha actual
            /*if (TransaccionesDto.Fecha == DateTime.MinValue)
            {
                TransaccionesDto.Fecha = DateTime.Now;
            }*/

            var result = _mapper.Map<Transacciones>(TransaccionesDto);
            _unitOfWork.Transacciones.Update(result);
            await _unitOfWork.SaveAsync();
            return TransaccionesDto;
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _unitOfWork.Transacciones.GetByIdAsync(id);

            if (result == null)
            {
                return NotFound();
            }

            _unitOfWork.Transacciones.Remove(result);
            await _unitOfWork.SaveAsync();
            return NoContent();
        }
    }
}