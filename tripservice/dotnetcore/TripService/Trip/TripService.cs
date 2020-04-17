using System.Collections.Generic;
using ContosoTrips.Exceptions;
using ContosoTrips.Users;

namespace ContosoTrips.Trips
{
    public class TripService
    {
        private readonly IUserSession userSession;

        public TripService()
        {
            this.userSession = UserSession.GetInstance();
        }

        public TripService(IUserSession userSession)
        {
            this.userSession = userSession ?? throw new System.ArgumentNullException(nameof(userSession));
        }

        public List<Trip> GetTripsByUser(User user)
        {
            User loggedUser = userSession.GetLoggedUser();

            Ensure.NotNull<UserNotLoggedInException>(loggedUser, "The user is not logged in");

            return user.IsFriendOf(loggedUser) ?
                GetTripsBy(user) :
                NoTrips();
        }

        private List<Trip> NoTrips() => new List<Trip>();

        protected virtual List<Trip> GetTripsBy(User user)
        {
            return TripDAO.FindTripsByUser(user);
        }
    }
}
