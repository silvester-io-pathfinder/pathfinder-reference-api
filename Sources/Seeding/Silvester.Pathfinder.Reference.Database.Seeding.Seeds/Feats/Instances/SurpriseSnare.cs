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
    public class SurpriseSnare : Template
    {
        public static readonly Guid ID = Guid.Parse("3916d22a-821e-4a37-adf2-29008f0166ff");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Surprise Snare",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("20f03f1f-3732-4258-b844-8dc026121c9a"), Type = TextBlockType.Text, Text = $"You install one of your snares prepared for quick deployment in a space that's occupied by an opponent. It must be a snare that normally takes 1 minute or less to {ToMarkdownLink<Models.Entities.SkillAction>("Craft", SkillActions.Instances.Craft.ID)}. The snare automatically triggers, but it takes a -2 circumstance penalty to any applicable save DC, as well as any attack rolls or other checks the snare attempts." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("dc542fbb-f645-4da1-834e-b2361fb3aa1a"), Feats.Instances.SnarecrafterDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Archetype.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Manipulate.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fceabb00-3656-4ff7-a795-fa5cbe9ddae8"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
