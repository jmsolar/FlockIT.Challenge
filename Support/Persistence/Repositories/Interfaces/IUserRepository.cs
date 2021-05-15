﻿using Support.Domain;
using Support.DTOs;
using Support.Filters;
using System.Threading.Tasks;

namespace Support.Persistence.Repositories.Interfaces
{
    public interface IUserRepository
    {
        Task<ApiResponse<User>> GetUserByFilter(UserFilter filter);
    }
}