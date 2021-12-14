using backend2.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend2.Domain.IRepositories
{
    public interface IUsuarioRepository
    {
        Task SaveUser(Usuario usuario);
    }
}
