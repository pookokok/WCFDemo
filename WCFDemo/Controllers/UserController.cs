namespace WCFDemo.Controllers
{
    using System.ServiceModel;
    using System.Web.Mvc;
    using BusinessServiceContracts;
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            var channelFactory = new ChannelFactory<IUserService>("");
            var userServie = channelFactory.CreateChannel();
            var users = userServie.GetAllUser();
            return View(users.RecordList);
        }
    }
}