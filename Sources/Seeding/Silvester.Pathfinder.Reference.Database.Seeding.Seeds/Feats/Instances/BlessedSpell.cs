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
    public class BlessedSpell : Template
    {
        public static readonly Guid ID = Guid.Parse("6eec53c6-be03-41e9-bd4d-0fb9c9224dfc");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Blessed Spell",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per 10 minutes"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7ed6dfd7-9fb6-4661-996d-d888ec657c05"), Type = TextBlockType.Text, Text = $"When you focus your magic on an ally, you can remove harmful conditions. If your next action is to {ToMarkdownLink<Models.Entities.Rule>("Cast a Spell", Rules.Instances.CastASpell.ID)} from a spell slot, and that spell targets only a single ally, you can also attempt to remove a harmful condition from that ally. The condition must be one that could be removed by your {ToMarkdownLink<Models.Entities.Feat>("Mercy", Feats.Instances.Mercy.ID)} feat, including those granted by later feats such as {ToMarkdownLink<Models.Entities.Feat>("Greater Mercy", Feats.Instances.GreaterMercy.ID)}. Attempt a counteract check based on the spell's DC and level. This effect is in addition to the normal effects of your spell." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("d3cceeeb-dddb-4446-b133-af49a683b083"), Feats.Instances.BlessedOneDedication.ID);
            //TODO: Add prerequisites.
            builder.HaveSpecificFeat(Guid.Parse("473f9760-18cc-4e41-91a2-cb4b72991b34"), Feats.Instances.Mercy.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Archetype.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Concentrate.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Metamagic.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0e41cd37-b4c9-40db-bdc3-9938a725171b"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
