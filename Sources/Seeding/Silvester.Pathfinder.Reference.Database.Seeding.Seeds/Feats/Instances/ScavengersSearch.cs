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
    public class ScavengersSearch : Template
    {
        public static readonly Guid ID = Guid.Parse("bee409a3-a03c-4a81-b47a-1d9bfc7f561a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Scavenger's Search",
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
            yield return new TextBlock { Id = Guid.Parse("94d5acbf-148d-4dfc-aadb-eddd0d477bba"), Type = TextBlockType.Text, Text = $"You're always on the lookout for supplies and valuables. Each time you use the {ToMarkdownLink<Models.Entities.Action>("Seek", Actions.Instances.Seek.ID)} action to search for objects (including secret doors and hazards), you can search for objects in your choice of a 10-foot emanation around you or an adjacent 15-foot-by-15-foot area, rather than a single adjacent 10-foot-by-10-foot area." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("6571fcb2-402f-4051-9730-e90290451770"), Traits.Instances.Tengu.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8fb20d37-7786-4270-9aeb-0ec74ab928a7"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
