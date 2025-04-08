﻿using BulletinBoard.DAL.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BulletinBoard.DAL.Interfaces
{
    public interface IAdRepository : IRepository<Ad>
    {
        Task<IEnumerable<Ad>> GetAdsByUserIdAsync(int userId);
        Task<IEnumerable<Ad>> GetAdsByCategoryIdAsync(int categoryId);
        Task<Ad> GetAdWithDetailsAsync(int id);
        Task<IEnumerable<Ad>> GetAllWithDetailsAsync();
    }
}
