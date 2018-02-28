using System;
using System.Collections.Generic;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Contoso.Application.Interfaces;
using Contoso.Application.Requests;
using Contoso.Application.Responses;
using Contoso.Domain.Interfaces;
using Contoso.Domain.Models;

namespace Contoso.Application.Services
{
    public class UserAppService : IUserAppService
    {
        private readonly IMapper mapper;
        private readonly IUserRepository repository;

        public UserAppService(IMapper mapper, IUserRepository repository)
        {
            this.mapper = mapper;
            this.repository = repository;
        }

        public IEnumerable<UserResponse> GetAll()
        {
            return this.repository.GetAll().ProjectTo<UserResponse>();
        }

        public UserResponse GetById(int id)
        {
            return this.mapper.Map<UserResponse>(this.repository.GetById(id));
        }

        public void Create(UserRequest user)
        {
            this.repository.AddAsync(this.mapper.Map<User>(user));
        }

        public void Update(UserRequest user)
        {
            this.repository.Update(this.mapper.Map<User>(user));
        }

        public void Remove(int id)
        {
            this.repository.Remove(id);
        }
        
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}