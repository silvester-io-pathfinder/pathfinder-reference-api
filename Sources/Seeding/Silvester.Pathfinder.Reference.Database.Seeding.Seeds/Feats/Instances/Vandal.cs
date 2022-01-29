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
    public class Vandal : Template
    {
        public static readonly Guid ID = Guid.Parse("d7e3f5c9-3197-430e-9b10-84e2cee12845");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Vandal",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b93e9c0e-b4d9-485f-bd77-3e8b486023c4"), Type = TextBlockType.Text, Text = $"You have a knack for breaking and dismantling things. Putting them back together is the boring part, so you largely don't bother with that. You become trained in Thievery. If you would automatically become trained in Thievery (from your background or class, for example), you instead become trained in a skill of your choice. In addition, whenever you hit with a {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} against a trap or an unattended object, you ignore the first 5 points of the object's Hardness." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d1debe41-01b7-45f8-bf1f-086482d13c1f"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
