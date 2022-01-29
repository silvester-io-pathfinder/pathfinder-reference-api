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
    public class QuickCircle : Template
    {
        public static readonly Guid ID = Guid.Parse("cf1374c8-7330-43ef-81aa-140336c1fdd3");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Quick Circle",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("664caa13-b06f-4711-9ef0-053a8f456374"), Type = TextBlockType.Text, Text = $"Long hours of practice and an instinctive understanding of boundaries lets you create protective circles impossibly quickly. As you fling your esoterica during a quick spin, you find that everything falls in a perfect circle each time. You can {ToMarkdownLink<Models.Entities.Feat>("Draw a Warding Circle", Feats.Instances.DrawWardingCircle.ID)} as a three-action activity, instead of taking 1 minute to do so." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("083496c5-4364-438c-b8ca-d7512247f32c"), Feats.Instances.DrawWardingCircle.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3a50389a-3d33-4b10-ab6c-a194154742db"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
