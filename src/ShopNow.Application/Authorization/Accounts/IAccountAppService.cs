﻿using System.Threading.Tasks;
using Abp.Application.Services;
using ShopNow.Authorization.Accounts.Dto;

namespace ShopNow.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
