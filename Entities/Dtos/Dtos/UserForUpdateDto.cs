using Core.Entities.Concrete;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos.Dtos
{
    public class UserForUpdateDto : IDto
    {
        public User User { get; set; }
        public string Password { get; set; }
    }
}
