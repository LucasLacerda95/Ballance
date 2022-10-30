using Ballance.Model.DataModels;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ballance.Model.Repositories {
    internal class UserRepository {
        private readonly SqlConnection _connection;

        public UserRepository(SqlConnection connection)
            => _connection = connection;

        public IEnumerable<User> Get()
            => _connection.GetAll<User>();

        public User Get(int id)
            => _connection.Get<User>(id);
        
        public void Create(User user) {
            user.Id = 0;
            _connection.Insert(user);
        }

        public void Update(User user) {
            if(user.Id != 0)
                _connection.Update<User>(user);
        }

        public void Delete(User user) {
            if(user.Id != 0)
                _connection.Delete<User>(user);
        }

        public void Delete(int id) {
            if (id != 0)
                return;

            var user = _connection.Get<User>(id);
            _connection.Delete(user);
        }
    
    }
}
