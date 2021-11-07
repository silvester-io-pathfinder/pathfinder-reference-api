using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class UnleashReflexiveSustainment : Template
    {
        public static readonly Guid ID = Guid.Parse("6d0f298c-4298-4fde-8589-38e0ae7d10f9");

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
            yield return new TextBlock { Id = Guid.Parse("9bf3cde2-78bd-4539-b2c2-5d1267160871"), Type = TextBlockType.Text, Text = "Your mind partitions itself to automatically handle some of your ongoing spells." };
            yield return new TextBlock { Id = Guid.Parse("6a7fdd15-d9fd-4fc7-ac65-576cfbe2bc71"), Type = TextBlockType.Text, Text = "~ Benefit: You become quickened and can use the additional action only to (action: Sustain a Spell)." };
            yield return new TextBlock { Id = Guid.Parse("2f1c360a-84e4-4f89-a0eb-7d244190c8d5"), Type = TextBlockType.Text, Text = "~ Drawback: Partitioning your mind into a second consciousness makes it more difficult to maintain spells. You can’t use reactions or free actions on other creatures’ turns, nor can you (action: Sustain a Spell) as a free action, such as with the (feat: Effortless Concentration) feat." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ffe27911-f2c0-44b9-b6bc-b7109c8480f5"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
