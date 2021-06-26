using AutoMapper;
using IEduca.Model.Dto;
using IEduca.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace IEduca.Service
{
    public interface ICancionService
    {
        Task<CancionSingleDto> GetById(int id);
    }
    public class CancionService : ICancionService
    {
        private readonly AppDbContext _context;

        private readonly IMapper _mapper;


        public CancionService(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        public async Task<CancionSingleDto> GetById(int id)
        {
            return _mapper.Map<CancionSingleDto>(
                await _context.Canciones.SingleAsync(x => x.Id == id)
            );
        }
    }
}
