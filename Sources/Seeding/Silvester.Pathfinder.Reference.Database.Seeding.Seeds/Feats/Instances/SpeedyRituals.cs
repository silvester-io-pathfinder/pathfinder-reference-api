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
    public class SpeedyRituals : Template
    {
        public static readonly Guid ID = Guid.Parse("3eabbe7d-dd8b-4f79-a490-0dafd05f8b95");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Speedy Rituals",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c624afe1-16da-44ea-be86-1708fae46aa5"), Type = TextBlockType.Text, Text = $"You can perform rituals in only a fraction of the usual time. If a ritual has a casting time measured in days, you can cast it in an equal number of hours. If this results in a ritual longer than 8 hours, you split the ritual between multiple days, as normal for a ritual." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("b43adf69-4d09-4361-a2dc-b8b09f1468f3"), Feats.Instances.EfficientRituals.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("583f3a88-1176-4f37-9a02-e36e90e3ad14"), Traits.Instances.Archetype.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("91045fd3-c25d-4c19-9d6e-93f0cc4c6f87"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
