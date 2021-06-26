using AutoMapper;
using IEduca.Model;
using IEduca.Model.Dto;
using IEduca.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IEduca.Service
{
    public interface IAlbumService
    {

        Task<List<AlbumListDto>> GetAll();
        Task<AlbumDto> GetById(int id);
        Task<AlbumDto> Create(AlbumCreateDto model);

    }

    public class AlbumService : IAlbumService
    {

        private readonly AppDbContext _context;

        private readonly IMapper _mapper;

        public AlbumService(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        public async Task<AlbumDto> GetById(int id)
        {
            return _mapper.Map<AlbumDto>(
                await _context.Albumes
                    .Include(x => x.Canciones)
                    .SingleAsync(x => x.Id == id)
            );
        }


        public async Task<AlbumDto> Create(AlbumCreateDto model)
        {
            var entry = _mapper.Map<Album>(model);
            await _context.AddAsync(entry);
            await _context.SaveChangesAsync();

            return _mapper.Map<AlbumDto>(
                await GetById(entry.Id)
            );
        }
        public async Task<List<AlbumListDto>> GetAll()
        {
            try
            {
                return _mapper.Map<List<AlbumListDto>>(
               await _context.Albumes.OrderBy(x => x.Id)
               .AsQueryable()
               .ToListAsync()
               );
            }
            catch (Exception ex )
            {

                throw new Exception (ex.Message);
            }
           
        }

    }
}
