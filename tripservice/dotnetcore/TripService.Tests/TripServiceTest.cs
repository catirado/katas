using ContosoTrips.Exceptions;
using ContosoTrips.Trips;
using ContosoTrips.Users;
using FluentAssertions;
using NSubstitute;
using System;
using System.Collections.Generic;
using Xunit;
using static FluentAssertions.FluentActions;

namespace TripServiceTests
{
    public class trip_service_should
    {
        private static User loggedInUser;

        private static User GUEST = null;

        [Fact]
        public void not_allow_to_get_trips_to_not_logged_in_users()
        {
            TripService tripService = new TestableTripService();

            loggedInUser = GUEST;

            Invoking(() => tripService.GetTripsByUser(loggedInUser)).Should().Throw<UserNotLoggedInException>();            
        }

        private class TestableTripService : TripService
        {
            protected override User GetLoggedInUser()
            {
                return loggedInUser;
            }
        }
    }

    
}
