using System;
using System.Collections.Generic;
using Contoso.Application.Requests;
using Contoso.Application.Responses;

namespace Contoso.Application.Interfaces
{
    public interface IUserAppService : IDisposable
    {
        IEnumerable<UserResponse> GetAll();
        UserResponse GetById(int id);
        void Create(UserRequest user);
        void Update(UserRequest user);
        void Remove(int id);
    }
}