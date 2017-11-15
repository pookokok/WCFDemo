namespace BusinessServiceContracts
{
    using System.ServiceModel;
    using ViewModel;

    [ServiceContract]
    public interface IUserService
    {
        /// <summary>
        /// This method will return all the users available in the system
        /// </summary>
        /// <returns>list of users</returns>
        [OperationContract]
        TableData<UserViewModel> GetAllUser();

        /// <summary>
        /// This method is used to create a new user in the system
        /// </summary>
        /// <param name="user">new user details</param>
        /// <returns>user id of newly created user</returns>
        [OperationContract]
        int Create(UserViewModel user);

        /// <summary>
        /// Get an existing user from the system based on user id
        /// </summary>
        /// <param name="userId">user id of the user to be fetched from the system</param>
        /// <returns>user matching user id</returns>
        [OperationContract]
        UserViewModel Get(int userId);

        /// <summary>
        /// update existing user details based
        /// </summary>
        /// <param name="user">updated user details</param>
        /// <returns>update successfull or not</returns>
        [OperationContract]
        bool UpdateUser(UserViewModel user);

        /// <summary>
        /// deletes user from the system based on the user id
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        [OperationContract]
        bool DeleteUser(int userId);
    }
}
