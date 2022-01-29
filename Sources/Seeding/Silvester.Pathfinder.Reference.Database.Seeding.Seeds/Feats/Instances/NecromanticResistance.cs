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
    public class NecromanticResistance : Template
    {
        public static readonly Guid ID = Guid.Parse("2cb4c0a2-bd9b-443f-8d8a-c2259ff7528e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Necromantic Resistance",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0622d4f5-6a39-4a04-8349-d28b68641cd5"), Type = TextBlockType.Text, Text = $"As part of your training, you've inured yourself against necromancy through repeated exposure. You gain a +1 circumstance bonus to saves against {ToMarkdownLink<Models.Entities.Trait>("necromancy", Traits.Instances.Necromancy.ID)} effects and gain resistance to negative damage equal to half your level." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("6290cc3c-3652-4ae1-87b2-cef47de08c1c"), Feats.Instances.LastwallSentryDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Archetype.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1e5b5daa-6145-49fc-9dc3-331f1a5decf3"),
                SourceId = Sources.Instances.LostOmensWorldGuide.ID,
                Page = -1
            };
        }
    }
}
