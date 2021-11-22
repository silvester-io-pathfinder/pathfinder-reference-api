using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class UnleashReflexiveSustainment : Template
    {
        public static readonly Guid ID = Guid.Parse("ee8e4ad8-ea31-4e5d-aadb-9458b10aac87");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Unleash Reflexive Sustainment",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8424548f-8d35-4f2a-8cc4-f3816d701ce9"), Type = TextBlockType.Text, Text = "Your mind partitions itself to automatically handle some of your ongoing spells." };
            yield return new TextBlock { Id = Guid.Parse("6dc03e8a-3d4d-45b0-874b-580ade0bd682"), Type = TextBlockType.Text, Text = "~ Benefit: You become quickened and can use the additional action only to (action: Sustain a Spell)." };
            yield return new TextBlock { Id = Guid.Parse("8be82ff9-6d79-4528-a414-2d996349c8dc"), Type = TextBlockType.Text, Text = "~ Drawback: Partitioning your mind into a second consciousness makes it more difficult to maintain spells. You can't use reactions or free actions on other creatures' turns, nor can you (action: Sustain a Spell) as a free action, such as with the (feat: Effortless Concentration) feat." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4b1efce0-1542-4a5a-97bc-fa2f5ce04f1f"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
