using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ballance.Model.DataModels {
    [Table("[User]")]
    
    internal class User {

        public int Id { get; set; }

        public string user_Name { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string PasswordHash { get; set; }

        public string Image { get; set; }

    }
}
