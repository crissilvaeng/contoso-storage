using System;
using System.Collections.Generic;
using Contoso.Application.Requests;
using Contoso.Application.Responses;

namespace Contoso.Application.Interfaces
{
    public interface IUserAppService : IDisposable
    {
        void Create(UserRequest user);
        IEnumerable<UserResponse> GetAll();
        UserResponse GetById(long id);
        void Update(UserRequest user);
        void Remove(long id);
    }
}