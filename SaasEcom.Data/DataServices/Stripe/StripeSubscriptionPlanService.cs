﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SaasEcom.Data.DataServices.Interfaces;
using SaasEcom.Data.Models;

namespace SaasEcom.Data.DataServices.Stripe
{
    public class StripeSubscriptionPlanService : ISubscriptionPlanService
    {
        public Task<List<SubscriptionPlan>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Models.SubscriptionPlan> FindAsync(int planId)
        {
            throw new NotImplementedException();
        }

        public Task AddAsync(Models.SubscriptionPlan plan)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateAsync(SubscriptionPlan plan)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int planId)
        {
            throw new NotImplementedException();
        }
    }
}
