using ContosoTrips.Exceptions;
using ContosoTrips.Trips;
using ContosoTrips.Users;
using FluentAssertions;
using NSubstitute;
using System;
using System.Collections.Generic;
using Xunit;
using static FluentAssertions.FluentActions;

namespace ContosoTrips.Tests
{
    public class trip_service_should
    {
        private readonly int ZERO_TRIPS = 0;
        private static User loggedInUser;
        private static User GUEST = null;
        private static User UNUSED_USER = null;
        private static User REGISTERED_USER = new User();
        private User ANOTHER_USER = new User();
        private Trip TO_LONDON = new Trip();
        private Trip TO_KIOTO = new Trip();
        private TripService tripService;
        
        public trip_service_should()
        {
            tripService = new TestableTripService();
        }

        [Fact]
        public void not_allow_to_get_trips_when_user_is_not_logged_on()
        {
            loggedInUser = GUEST;

            Invoking(() => tripService.GetTripsByUser(UNUSED_USER)).Should().Throw<UserNotLoggedInException>();            
        }

        [Fact]
        private void not_allow_to_get_trips_to_users_that_are_not_friends()
        {
            loggedInUser = REGISTERED_USER;

            var notFriend = Builder.User
                                .WithFriends(ANOTHER_USER)
                                .WithTrips(TO_LONDON, TO_KIOTO)
                                .Build();

            var trips = tripService.GetTripsByUser(notFriend);
            trips.Should().HaveCount(ZERO_TRIPS);
        }

        [Fact]
        private void allow_to_get_trips_when_user_is_a_friend()
        {
            loggedInUser = REGISTERED_USER;

            var friend = Builder.User
                                .WithFriends(loggedInUser, ANOTHER_USER)
                                .WithTrips(TO_LONDON, TO_KIOTO)
                                .Build();

            var trips = tripService.GetTripsByUser(friend);

            trips.Should().HaveCount(friend.Trips().Count);
        }

        private class TestableTripService : TripService
        {
            protected override User GetLoggedInUser()
            {
                return loggedInUser;
            }

            protected override List<Trip> GetTripsBy(User user)
            {
                return user.Trips();
            }
        }
    }

    
}
