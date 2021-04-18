using Silvester.Pathfinder.Official.Database.Extensions;
using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
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

            TextBlock[] details = GetDetails(seeder).ToArray();
            for(int i = 0; i < details.Length; i ++)
            {
                TextBlock detail = details[i];
                detail.Order = i;
                detail.OwnerId = action.Id;
                seeder.Builder.AddOwnedData((Models.Action o) => o.Details, detail);
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
        protected abstract IEnumerable<TextBlock> GetDetails(ActionSeeder seeder);
        
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
