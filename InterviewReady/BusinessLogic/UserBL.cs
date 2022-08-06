using InterviewReady.UserContext;

namespace InterviewReady.BusinessLogic
{
    public class UserBL
    {
        private UserDbContext userDbContext;
         
        public UserBL(UserDbContext userDbContext)
        {
            this.userDbContext = userDbContext;
        }

        public dynamic UserExits(UserShoppingTable model)
        {
            bool rValue = false;

            List<UserShoppingTable> students;

            var username = model.Username;
            rValue =  userDbContext.UserShoppingTable.Any(r => r.Username == username);

            


            return rValue;
        }
    }
}


