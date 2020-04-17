using System.Collections.Generic;
using ContosoTrips.Exceptions;
using ContosoTrips.Users;

namespace ContosoTrips.Trips
{
    public class TripService
    {
        public List<Trip> GetTripsByUser(User user)
        {
            User loggedUser = GetLoggedInUser();

            if (loggedUser == null)
            {
                throw new UserNotLoggedInException();
            }

            return user.IsFriendOf(loggedUser) ?
                GetTripsBy(user) :
                NoTrips();
        }

        private List<Trip> NoTrips() => new List<Trip>();

        protected virtual List<Trip> GetTripsBy(User user)
        {
            return TripDAO.FindTripsByUser(user);
        }

        protected virtual User GetLoggedInUser()
        {
            return UserSession.GetInstance().GetLoggedUser();
        }
    }
}
