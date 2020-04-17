using System.Collections.Generic;
using ContosoTrips.Exceptions;
using ContosoTrips.Users;

namespace ContosoTrips.Trips
{
    public class TripService
    {
        private readonly IUserSession userSession;
        private readonly ITripDAO tripDAO;

        public TripService():this(UserSession.GetInstance(), new TripDAO())
        {

        }

        public TripService(IUserSession userSession, ITripDAO tripDAO)
        {
            this.userSession = userSession ?? throw new System.ArgumentNullException(nameof(userSession));
            this.tripDAO = tripDAO ?? throw new System.ArgumentNullException(nameof(tripDAO));
        }

        public List<Trip> GetTripsByUser(User user)
        {
            User loggedUser = userSession.GetLoggedUser();

            Ensure.NotNull<UserNotLoggedInException>(loggedUser, "The user is not logged in");

            return user.IsFriendOf(loggedUser) ?
                tripDAO.GetTripsBy(user) :
                NoTrips();
        }

        private List<Trip> NoTrips() => new List<Trip>();
    }
}
