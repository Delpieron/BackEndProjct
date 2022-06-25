using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreApi
{
    public static class ApiRoutes
    {
        public const string Base = "api/v1/";

        public static class User
        {
            public const string GetUserId = Base + "Workout/{id}";
            public const string AddUserId = Base + "Workout";
            public const string EditUserId = Base + "Workout";
            public const string DeleteUserId = Base + "Workout/{id}";
        }
    }
}
