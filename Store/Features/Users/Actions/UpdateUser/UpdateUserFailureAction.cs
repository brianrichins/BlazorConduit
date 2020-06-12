﻿using BlazorConduit.Store.Features.Shared.Actions;
using System.Collections.Generic;

namespace BlazorConduit.Store.Features.Users.Actions.UpdateUser
{
    public class UpdateUserFailureAction : FailureAction
    {
        public UpdateUserFailureAction(string reasonForFailure, IEnumerable<string>? errors = null)
            : base(reasonForFailure, errors)
        {
        }
    }
}
