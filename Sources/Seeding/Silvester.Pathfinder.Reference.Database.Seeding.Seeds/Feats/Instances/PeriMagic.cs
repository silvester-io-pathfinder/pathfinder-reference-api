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
    public class PeriMagic : Template
    {
        public static readonly Guid ID = Guid.Parse("fa5b8ff8-1577-4918-9f44-85f9ca90f79d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Peri Magic",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ee43511f-69a6-4805-8e43-55d91e38ac6f"), Type = TextBlockType.Text, Text = $"The shimmering embers of the righteous peris crackle at your fingertips. You can cast {ToMarkdownLink<Models.Entities.Spell>("glitterdust", Spells.Instances.Glitterdust.ID)} and {ToMarkdownLink<Models.Entities.Spell>("status", Spells.Instances.Status.ID)} each once per day as 2nd-level divine innate spells." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("980ff358-c9a6-41c1-928e-a7a3da56daf1"), Feats.Instances.Emberkin.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("773d7c1d-20f2-41a7-b16d-4c9e1acb2e4d"), Traits.Instances.Aasimar.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b3546ac8-a48e-4cc1-9f1b-a067edd38f91"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
