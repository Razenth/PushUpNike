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
    public class CarrocompraController : BaseController
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly NikeContext _context;

        public CarrocompraController(IUnitOfWork unitOfWork, IMapper mapper, NikeContext context)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _context = context;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<CarrocompraDto>>> Get()
        {
            var result = await _unitOfWork.Carrocompras.GetAllAsync();
            return _mapper.Map<List<CarrocompraDto>>(result);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<CarrocompraDto>> Get(int id)
        {
            var result = await _unitOfWork.Carrocompras.GetByIdAsync(id);

            if (result == null)
            {
                return NotFound();
            }

            return _mapper.Map<CarrocompraDto>(result);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Carrocompra>> Post(CarrocompraDto CarrocompraDto)
        {
            var result = _mapper.Map<Carrocompra>(CarrocompraDto);
            this._unitOfWork.Carrocompras.Add(result);
            await _unitOfWork.SaveAsync();

            if (result == null)
            {
                return BadRequest();
            }
            CarrocompraDto.Id = result.Id;
            return CreatedAtAction(nameof(Post), new { id = CarrocompraDto.Id }, CarrocompraDto);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<CarrocompraDto>> Put(int id, [FromBody] CarrocompraDto CarrocompraDto)
        {
            if (CarrocompraDto.Id == 0)
            {
                CarrocompraDto.Id = id;
            }

            if(CarrocompraDto.Id != id)
            {
                return BadRequest();
            }

            if(CarrocompraDto == null)
            {
                return NotFound();
            }

             // Por si requiero la fecha actual
            /*if (CarrocompraDto.Fecha == DateTime.MinValue)
            {
                CarrocompraDto.Fecha = DateTime.Now;
            }*/

            var result = _mapper.Map<Carrocompra>(CarrocompraDto);
            _unitOfWork.Carrocompras.Update(result);
            await _unitOfWork.SaveAsync();
            return CarrocompraDto;
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _unitOfWork.Carrocompras.GetByIdAsync(id);

            if (result == null)
            {
                return NotFound();
            }

            _unitOfWork.Carrocompras.Remove(result);
            await _unitOfWork.SaveAsync();
            return NoContent();
        }
    }
}