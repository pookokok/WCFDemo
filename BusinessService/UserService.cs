namespace BusinessService
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using BusinessServiceContracts;
    using ViewModel;

    public class UserService : IUserService
    {
        public IList<UserViewModel> Users { get; set; } = new List<UserViewModel>()
        {
            new UserViewModel()
            {
                Id = 1,
                Name = "Ramesh, Swamy",
                Address = "Banashankari",
                PhoneNumber = "+91-875-123-4567",
                City = "Bengaluru",
                Dob = new DateTime(1990,01,20),
                Country = "India",
                ZipCode = 57600
            },
            new UserViewModel()
            {
                Id = 2,
                Name = "Andrew, Christopher",
                Address = "Duncan St",
                PhoneNumber = "+1-541-754-3010",
                City = "San Fransico",
                Dob = new DateTime(1985,10,30),
                Country = "United States",
                ZipCode = 94117
            },
            new UserViewModel()
            {
                Id = 3,
                Name = "Michael, Suhl",
                Address = "Lichenberg",
                PhoneNumber = "+49-8757-452-1212",
                City = "Berlin",
                Dob = new DateTime(1980,12,20),
                Country = "Germany",
                ZipCode = 10352
            }
        };


        public TableData<UserViewModel> GetAllUser()
        {
            return new TableData<UserViewModel>() { RecordList = Users, Count = Users.Count };
        }

        public int Create(UserViewModel user)
        {
            user.Id = Users.Max(x => x.Id) + 1;
            Users.Add(user);
            return user.Id;
        }

        public bool DeleteUser(int userId)
        {
            return Users.Remove(Users.FirstOrDefault(x => x.Id.Equals(userId)));
        }

        public UserViewModel Get(int userId)
        {
            return Users.FirstOrDefault(x => x.Id.Equals(userId));
        }

        public bool UpdateUser(UserViewModel user)
        {
            var currentData = Users.FirstOrDefault(x => x.Id.Equals(user.Id));
            if (currentData != null)
            {
                currentData.Name = user.Name;
                currentData.Address = user.Address;
                currentData.PhoneNumber = user.PhoneNumber;
                currentData.ZipCode = user.ZipCode;
                currentData.Country = user.Country;
                currentData.City = user.City;
                currentData.Dob = user.Dob;
                return true;
            }
            return false;
        }
    }
}
