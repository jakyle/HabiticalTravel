﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HabiticaTravel.Utility
{
    public static partial class HabiticaPost
    {

        public static async Task<string> RegisterNewUser(ApplicationUser user, RegisterViewModel model)
        {

            return await "https://habitica.com/api/v3/tasks/user"
                    .PostUrlEncodedAsync(new
                    {
                      
                    })
                    .ReceiveString();
        }
    }
}