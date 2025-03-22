using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Domain.Interfaces
{
    internal interface IUserRepository: IBaseRepository <User>
    {
        Task<User> GetByEmail(string email, CancellationToken cancellationToken);
    }
}
