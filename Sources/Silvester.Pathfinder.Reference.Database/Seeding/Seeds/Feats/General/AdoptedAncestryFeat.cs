using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.General
{
    public class AdoptedAncestryFeat : Template
    {
        public static readonly Guid ID = Guid.Parse("b8193a38-a31c-45f2-a715-2542f09b97ca");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Adopted Ancestry",
                Level = 1,
                FeatTypeId = FeatTypes.Instances.General.ID,
                ActionTypeId = ActionTypes.Instances.NoAction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a23693cb-3840-48a8-94fb-7f93f6d118b6"), Type = Utilities.Text.TextBlockType.Text, Text = "You’re fully immersed in another ancestry’s culture and traditions, whether born into them, earned through rite of passage, or bonded through a deep friendship or romance. Choose a common ancestry. You can select ancestry feats from the ancestry you chose, in addition to your character’s own ancestry, as long as the ancestry feats don’t require any physiological feature that you lack, as determined by the GM." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.General.ID;
        }

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new HeritageRarityEffect { Id = Guid.Parse("967c98bc-088c-4fb7-9d44-ff7a6f90f506"), RarityId = Rarities.Instances.Common.ID };
        }
    }
}
