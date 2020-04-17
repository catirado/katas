using System.Collections.Generic;
using ContosoTrips.Exceptions;
using ContosoTrips.Users;

namespace ContosoTrips.Trips
{
    public class TripService
    {
        public List<Trip> GetTripsByUser(User user)
        {
            List<Trip> tripList = new List<Trip>();
            User loggedUser = GetLoggedInUser();
            bool isFriend = false;
            if (loggedUser != null)
            {
                isFriend = user.IsFriendOf(loggedUser);
                if (isFriend)
                {
                    tripList = GetTripsBy(user);
                }
                return tripList;
            }
            else
            {
                throw new UserNotLoggedInException();
            }
        }

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
