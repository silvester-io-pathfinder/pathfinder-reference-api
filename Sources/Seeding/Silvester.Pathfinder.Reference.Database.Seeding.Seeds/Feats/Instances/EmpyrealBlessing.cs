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
    public class EmpyrealBlessing : Template
    {
        public static readonly Guid ID = Guid.Parse("113a8ccc-ef98-4674-808c-e371ff3d3dee");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Empyreal Blessing",
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
            yield return new TextBlock { Id = Guid.Parse("ecbbe807-a448-47e4-b2db-c4985673fd4e"), Type = TextBlockType.Text, Text = $"You can call forth a benediction upon your allies, whether you pray to a deity of the celestial realms or just find the power within yourself. You can cast {ToMarkdownLink<Models.Entities.Spell>("bless", Spells.Instances.Bless.ID)} once per day as a 1st-level divine innate spell." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("407e14ec-c780-4cc9-84f2-ab96e0f395fe"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
