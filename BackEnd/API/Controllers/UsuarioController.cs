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
    public class UsuarioController : BaseController
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly NikeContext _context;

        public UsuarioController(IUnitOfWork unitOfWork, IMapper mapper, NikeContext context)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _context = context;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<UsuarioDto>>> Get()
        {
            var result = await _unitOfWork.Usuarios.GetAllAsync();
            return _mapper.Map<List<UsuarioDto>>(result);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<UsuarioDto>> Get(int id)
        {
            var result = await _unitOfWork.Usuarios.GetByIdAsync(id);

            if (result == null)
            {
                return NotFound();
            }

            return _mapper.Map<UsuarioDto>(result);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Usuario>> Post(UsuarioDto UsuarioDto)
        {
            var result = _mapper.Map<Usuario>(UsuarioDto);
            this._unitOfWork.Usuarios.Add(result);
            await _unitOfWork.SaveAsync();

            if (result == null)
            {
                return BadRequest();
            }
            UsuarioDto.Id = result.Id;
            return CreatedAtAction(nameof(Post), new { id = UsuarioDto.Id }, UsuarioDto);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<UsuarioDto>> Put(int id, [FromBody] UsuarioDto UsuarioDto)
        {
            if (UsuarioDto.Id == 0)
            {
                UsuarioDto.Id = id;
            }

            if(UsuarioDto.Id != id)
            {
                return BadRequest();
            }

            if(UsuarioDto == null)
            {
                return NotFound();
            }

             // Por si requiero la fecha actual
            /*if (UsuarioDto.Fecha == DateTime.MinValue)
            {
                UsuarioDto.Fecha = DateTime.Now;
            }*/

            var result = _mapper.Map<Usuario>(UsuarioDto);
            _unitOfWork.Usuarios.Update(result);
            await _unitOfWork.SaveAsync();
            return UsuarioDto;
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _unitOfWork.Usuarios.GetByIdAsync(id);

            if (result == null)
            {
                return NotFound();
            }

            _unitOfWork.Usuarios.Remove(result);
            await _unitOfWork.SaveAsync();
            return NoContent();
        }
    }
}