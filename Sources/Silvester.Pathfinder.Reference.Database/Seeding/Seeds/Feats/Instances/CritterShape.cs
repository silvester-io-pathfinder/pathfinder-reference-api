using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CritterShape : Template
    {
        public static readonly Guid ID = Guid.Parse("ff520cfb-e384-4f92-80fb-f0a65ca8bdb5");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Critter Shape",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("50802202-cdb0-4677-82cc-d635e8ffb36e"), Type = TextBlockType.Text, Text = "Once per hour, you can use (feat: Change Shape | Change Shape - Beastkin) to enter a critter shape. While in critter shape, you gain the effect of a 1st-level (spell: pest form), except you can only transform into an animal matching your inherent animal. You can remain in critter shape for up to 10 minutes, after which you transform back into your hybrid shape and can’t enter your critter shape again for 1 hour." };
            yield return new TextBlock { Id = Guid.Parse("baed3e45-4e9e-4346-882a-270a83879fd5"), Type = TextBlockType.Text, Text = "You can instead use (feat: Change Shape | Change Shape - Beastkin) to return to your humanoid or hybrid shape at any time during the duration of Critter Shape. If your inherent animal is normally larger than Tiny, you transform into a smaller, younger version of the animal, such as a Tiny bear cub. If your inherent animal has a fly Speed, you can turn into that animal (unlike normal for 1st-level (spell: pest form)), but you still don’t gain a fly Speed." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("12dc9488-6d3f-47b7-ada6-89efa0d7c232"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
