using Silvester.Pathfinder.Official.Database.Extensions;
using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Classes
{
    public abstract class AbstractActionTemplate
    {
        public void Seed(ActionSeeder seeder)
        {
            Models.Action action = GetAction(seeder);

            foreach (ActionDetailsBlock detail in GetDetails(seeder))
            {
                detail.ActionId = action.Id;
                seeder.Builder.AddData(detail);
            }

            foreach (Trait trait in GetTraits(seeder))
            {
                seeder.Builder.HasJoinData((action, trait));
            }

            RollableEffect? rollableEffect = GetRollableEffect(seeder);
            if(rollableEffect != null)
            {
                action.RollableEffectId = rollableEffect.Id;
                seeder.Builder.AddData(rollableEffect);
            }

            seeder.Builder.AddData(action);
        }

        protected abstract Models.Action GetAction(ActionSeeder seeder);
        protected abstract IEnumerable<ActionDetailsBlock> GetDetails(ActionSeeder seeder);
        
        protected virtual RollableEffect? GetRollableEffect(ActionSeeder seeder)
        {
            return null;
        }

        protected virtual IEnumerable<Trait> GetTraits(ActionSeeder seeder)
        {
            yield break;
        }
    }
}
