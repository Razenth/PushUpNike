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
    public class DetallestransaccionController : BaseController
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly NikeContext _context;

        public DetallestransaccionController(IUnitOfWork unitOfWork, IMapper mapper, NikeContext context)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _context = context;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<DetallestransaccionDto>>> Get()
        {
            var result = await _unitOfWork.Detallestransacciones.GetAllAsync();
            return _mapper.Map<List<DetallestransaccionDto>>(result);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<DetallestransaccionDto>> Get(int id)
        {
            var result = await _unitOfWork.Detallestransacciones.GetByIdAsync(id);

            if (result == null)
            {
                return NotFound();
            }

            return _mapper.Map<DetallestransaccionDto>(result);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Detallestransaccion>> Post(DetallestransaccionDto DetallestransaccionDto)
        {
            var result = _mapper.Map<Detallestransaccion>(DetallestransaccionDto);
            this._unitOfWork.Detallestransacciones.Add(result);
            await _unitOfWork.SaveAsync();

            if (result == null)
            {
                return BadRequest();
            }
            DetallestransaccionDto.Id = result.Id;
            return CreatedAtAction(nameof(Post), new { id = DetallestransaccionDto.Id }, DetallestransaccionDto);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<DetallestransaccionDto>> Put(int id, [FromBody] DetallestransaccionDto DetallestransaccionDto)
        {
            if (DetallestransaccionDto.Id == 0)
            {
                DetallestransaccionDto.Id = id;
            }

            if(DetallestransaccionDto.Id != id)
            {
                return BadRequest();
            }

            if(DetallestransaccionDto == null)
            {
                return NotFound();
            }

             // Por si requiero la fecha actual
            /*if (DetallestransaccionDto.Fecha == DateTime.MinValue)
            {
                DetallestransaccionDto.Fecha = DateTime.Now;
            }*/

            var result = _mapper.Map<Detallestransaccion>(DetallestransaccionDto);
            _unitOfWork.Detallestransacciones.Update(result);
            await _unitOfWork.SaveAsync();
            return DetallestransaccionDto;
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _unitOfWork.Detallestransacciones.GetByIdAsync(id);

            if (result == null)
            {
                return NotFound();
            }

            _unitOfWork.Detallestransacciones.Remove(result);
            await _unitOfWork.SaveAsync();
            return NoContent();
        }
    }
}