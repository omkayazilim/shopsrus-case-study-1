using shopsrus.Domain.Dtos;
using shopsrus.Domain.Entityes;
using shopsrus.Domain.Interfaces;
using shopsrus.Domain.ViewModels;
using shopsrus.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shopsrus.Applications
{
    public interface IUserService : ISingletonDependency
    {
       
    }
    public class UserService : ServicesBase, IUserService
    {
        public UserService(IServiceProvider provider) : base(provider)
        {

        }

       
    }
}
