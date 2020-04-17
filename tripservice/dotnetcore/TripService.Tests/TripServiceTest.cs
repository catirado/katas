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
        [Fact]
        public void not_allow_to_get_trips_to_not_logged_in_user()
        {
            var tripService = new TestableTripService();

            Invoking(() => tripService.GetTripsByUser(null)).Should().Throw<UserNotLoggedInException>();            
        }
    }

    public class TestableTripService : TripService
    {
        protected override User GetLoggedInUser()
        {
            return null;
        }
    }
}
