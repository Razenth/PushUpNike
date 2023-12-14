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
    public class DetallescarrocompraController : BaseController
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly NikeContext _context;

        public DetallescarrocompraController(IUnitOfWork unitOfWork, IMapper mapper, NikeContext context)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _context = context;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<DetallescarrocompraDto>>> Get()
        {
            var result = await _unitOfWork.Detallescarrocompras.GetAllAsync();
            return _mapper.Map<List<DetallescarrocompraDto>>(result);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<DetallescarrocompraDto>> Get(int id)
        {
            var result = await _unitOfWork.Detallescarrocompras.GetByIdAsync(id);

            if (result == null)
            {
                return NotFound();
            }

            return _mapper.Map<DetallescarrocompraDto>(result);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Detallescarrocompra>> Post(DetallescarrocompraDto DetallescarrocompraDto)
        {
            var result = _mapper.Map<Detallescarrocompra>(DetallescarrocompraDto);
            this._unitOfWork.Detallescarrocompras.Add(result);
            await _unitOfWork.SaveAsync();

            if (result == null)
            {
                return BadRequest();
            }
            DetallescarrocompraDto.Id = result.Id;
            return CreatedAtAction(nameof(Post), new { id = DetallescarrocompraDto.Id }, DetallescarrocompraDto);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<DetallescarrocompraDto>> Put(int id, [FromBody] DetallescarrocompraDto DetallescarrocompraDto)
        {
            if (DetallescarrocompraDto.Id == 0)
            {
                DetallescarrocompraDto.Id = id;
            }

            if(DetallescarrocompraDto.Id != id)
            {
                return BadRequest();
            }

            if(DetallescarrocompraDto == null)
            {
                return NotFound();
            }

             // Por si requiero la fecha actual
            /*if (DetallescarrocompraDto.Fecha == DateTime.MinValue)
            {
                DetallescarrocompraDto.Fecha = DateTime.Now;
            }*/

            var result = _mapper.Map<Detallescarrocompra>(DetallescarrocompraDto);
            _unitOfWork.Detallescarrocompras.Update(result);
            await _unitOfWork.SaveAsync();
            return DetallescarrocompraDto;
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _unitOfWork.Detallescarrocompras.GetByIdAsync(id);

            if (result == null)
            {
                return NotFound();
            }

            _unitOfWork.Detallescarrocompras.Remove(result);
            await _unitOfWork.SaveAsync();
            return NoContent();
        }
    }
}