using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Stonecunning : Template
    {
        public static readonly Guid ID = Guid.Parse("5dd1da53-ec03-4ecb-9359-0bfea4b272bd");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Stonecunning",
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
            yield return new TextBlock { Id = Guid.Parse("83756201-3bf5-467f-ab4c-8edbd15951d8"), Type = TextBlockType.Text, Text = $"You have a knack for noticing even small inconsistencies and craftsmanship techniques in the stonework around you. You gain a +2 circumstance bonus to Perception checks to notice unusual stonework. This bonus applies to checks to discover mechanical traps made of stone or hidden within stone." };
            yield return new TextBlock { Id = Guid.Parse("32928d83-2736-4fff-938e-57c3fc50c2d7"), Type = TextBlockType.Text, Text = $"If you aren't using the {ToMarkdownLink<Models.Entities.Action>("Seek", Actions.Instances.Seek.ID)} action or searching, the GM automatically rolls a secret check for you to notice unusual stonework anyway. This check doesn't gain the circumstance bonus, and it takes a –2 circumstance penalty." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("aa0ace30-0d93-4341-90b4-829b88d2ea36"), Traits.Instances.Dwarf.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("46a193f1-0dff-429c-96d8-bb08238b5c27"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
