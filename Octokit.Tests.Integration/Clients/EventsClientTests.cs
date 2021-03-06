﻿using System.Threading.Tasks;
using Xunit;

namespace Octokit.Tests.Integration.Clients
{
    public class EventsClientTests
    {
        public class TheGetUserPerformedMethod
        {
            [Fact]
            public async Task ReturnsACollection()
            {
                var github = Helper.GetAuthenticatedClient();
                var events = await github.Activity.Events.GetUserPerformed("shiftkey");
                Assert.NotEmpty(events);
            } 
        }
    }
}
