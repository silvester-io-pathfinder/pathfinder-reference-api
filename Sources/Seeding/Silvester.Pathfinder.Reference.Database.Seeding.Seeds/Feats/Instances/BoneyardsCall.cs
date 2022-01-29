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
    public class BoneyardsCall : Template
    {
        public static readonly Guid ID = Guid.Parse("39013171-9675-43d8-abcb-7363cfe71578");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Boneyard's Call",
                Level = 17,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("720d9cb0-369b-4ba8-b46a-662a5739b59d"), Type = TextBlockType.Text, Text = $"You have a powerful connection to the Boneyard and its courts, granting you the ability to travel to and from the Boneyard. You gain {ToMarkdownLink<Models.Entities.Spell>("plane shift", Spells.Instances.PlaneShift.ID)} as a divine innate spell. You can cast it twice per week. This can be used only to travel to the Boneyard or from the Boneyard to the Material Plane. Due to your unique connection to the Boneyard, your body serves as the focus, and you don't require a tuning fork." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6b6b599c-05f4-453a-8ed6-99c954d48466"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
