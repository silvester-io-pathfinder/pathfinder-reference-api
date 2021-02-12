using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Feats.General
{
    public class AdoptedAncestryFeat : AbstractFeatTemplate
    {
        protected override string FeatType => "General";
        protected override string ActionType => "No Action";

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = Guid.Parse("b8193a38-a31c-45f2-a715-2542f09b97ca"),
                Name = "Adopted Ancestry",
                Level = 1
            };
        }

        protected override IEnumerable<FeatDetailsBlock> GetDetailBlocks()
        {
            yield return new FeatDetailsBlock { Id = Guid.Parse("a23693cb-3840-48a8-94fb-7f93f6d118b6"), Text = "You’re fully immersed in another ancestry’s culture and traditions, whether born into them, earned through rite of passage, or bonded through a deep friendship or romance. Choose a common ancestry. You can select ancestry feats from the ancestry you chose, in addition to your character’s own ancestry, as long as the ancestry feats don’t require any physiological feature that you lack, as determined by the GM." };
        }

        protected override IEnumerable<string> GetTraits()
        {
            yield return "General";
        }

        protected override IEnumerable<FeatEffect> GetEffects(FeatSeeder seeder)
        {
            yield return new GainHeritageEffect { Id = Guid.Parse("967c98bc-088c-4fb7-9d44-ff7a6f90f506"), HeritageRarityId = seeder.GetHeritageRarity("Common") };
        }
    }
}
