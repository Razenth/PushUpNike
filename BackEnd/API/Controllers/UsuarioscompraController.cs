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
    public class UsuarioscompraController : BaseController
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly NikeContext _context;

        public UsuarioscompraController(IUnitOfWork unitOfWork, IMapper mapper, NikeContext context)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _context = context;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<UsuarioscompraDto>>> Get()
        {
            var result = await _unitOfWork.Usuarioscompras.GetAllAsync();
            return _mapper.Map<List<UsuarioscompraDto>>(result);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<UsuarioscompraDto>> Get(int id)
        {
            var result = await _unitOfWork.Usuarioscompras.GetByIdAsync(id);

            if (result == null)
            {
                return NotFound();
            }

            return _mapper.Map<UsuarioscompraDto>(result);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Usuarioscompra>> Post(UsuarioscompraDto UsuarioscompraDto)
        {
            var result = _mapper.Map<Usuarioscompra>(UsuarioscompraDto);
            this._unitOfWork.Usuarioscompras.Add(result);
            await _unitOfWork.SaveAsync();

            if (result == null)
            {
                return BadRequest();
            }
            UsuarioscompraDto.Id = result.Id;
            return CreatedAtAction(nameof(Post), new { id = UsuarioscompraDto.Id }, UsuarioscompraDto);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<UsuarioscompraDto>> Put(int id, [FromBody] UsuarioscompraDto UsuarioscompraDto)
        {
            if (UsuarioscompraDto.Id == 0)
            {
                UsuarioscompraDto.Id = id;
            }

            if(UsuarioscompraDto.Id != id)
            {
                return BadRequest();
            }

            if(UsuarioscompraDto == null)
            {
                return NotFound();
            }

             // Por si requiero la fecha actual
            /*if (UsuarioscompraDto.Fecha == DateTime.MinValue)
            {
                UsuarioscompraDto.Fecha = DateTime.Now;
            }*/

            var result = _mapper.Map<Usuarioscompra>(UsuarioscompraDto);
            _unitOfWork.Usuarioscompras.Update(result);
            await _unitOfWork.SaveAsync();
            return UsuarioscompraDto;
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _unitOfWork.Usuarioscompras.GetByIdAsync(id);

            if (result == null)
            {
                return NotFound();
            }

            _unitOfWork.Usuarioscompras.Remove(result);
            await _unitOfWork.SaveAsync();
            return NoContent();
        }
    }
}