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
    public class GrimInsight : Template
    {
        public static readonly Guid ID = Guid.Parse("b109d498-5c67-4491-a634-311ba4735632");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Grim Insight",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("eb275068-a229-48b3-92a0-594701d40d1a"), Type = TextBlockType.Text, Text = $"Others' attempts to scare you often grant you insights about your would-be bullies that you can then exploit. If you roll a success on a saving throw against a {ToMarkdownLink<Models.Entities.Trait>("fear", Traits.Instances.Fear.ID)} effect, you get a critical success instead, and the source of the {ToMarkdownLink<Models.Entities.Trait>("fear", Traits.Instances.Fear.ID)} effect is flat-footed to you until the end of your next turn." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificHeritage(Guid.Parse("fc20b8d4-bbb4-404f-b0e3-fba9266b586a"), Heritages.Instances.UmbralGnome.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7f4ae77b-7ff0-4d35-9cb7-db7dac9f8ff7"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
