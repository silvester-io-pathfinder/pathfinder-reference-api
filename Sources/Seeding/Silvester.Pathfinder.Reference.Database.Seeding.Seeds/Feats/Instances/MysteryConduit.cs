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
    public class MysteryConduit : Template
    {
        public static readonly Guid ID = Guid.Parse("f599a13f-fdeb-478a-bd07-962038a8c0e6");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Mystery Conduit",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("811a58c7-6ba3-493d-9e1f-ed90ad014ba7"), Type = TextBlockType.Text, Text = $"The power of your mystery enables you to cast more than just revelation spells. When you cast a spell of 5th level or lower that has no duration, instead of spending a spell slot, you can advance the effects of your oracular curse in the same manner as when you cast a revelation spell. A spell cast in this way gains the {ToMarkdownLink<Models.Entities.Trait>("cursebound", Traits.Instances.Cursebound.ID)} trait." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("227ba2fd-3cae-47c9-af8d-42ef048c9401"), Traits.Instances.Oracle.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("93cca01a-7a8e-4d13-ba34-4cfafd4a57ba"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
