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
    public class HalcyonSpeakerDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("0f2f01ca-10d1-474b-bf35-42c642e56975");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Halcyon Speaker Dedication",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You cannot select another dedication feat until you have gained two other feats from the halcyon speaker archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c79bb55b-488a-422c-b09d-4f51d1dbac6a"), Type = TextBlockType.Text, Text = $"You devote much of your study to halcyon magic. You gain access to two common Halcyon cantrips and two common 1st-level halcyon spells (see halcyon spells on Lost Omens Character Guide pg 100). In addition to being able to cast your halcyon spells via your arcane or primal spell slots, you also gain a 1st-level halcyon spell slot. You can use your halcyon spell slots to spontaneously cast your halcyon spells." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("a1f18275-7002-4660-b969-72fb12af7bc9"), Feats.Instances.MagaambyanAttendantDedication.ID);
            builder.Manual(Guid.Parse("55c2d135-8211-4fe8-ad06-c280499a099d"), "Member of the Magaambya of conversant rank.");
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("c415b917-3182-41b7-8d55-39a607dea3c5"), Traits.Instances.Archetype.ID);
            builder.Add(Guid.Parse("07d0dc63-1aed-465f-8846-507f60788f13"), Traits.Instances.Dedication.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("86eee8a6-363b-40b5-944f-f0051309daf9"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
