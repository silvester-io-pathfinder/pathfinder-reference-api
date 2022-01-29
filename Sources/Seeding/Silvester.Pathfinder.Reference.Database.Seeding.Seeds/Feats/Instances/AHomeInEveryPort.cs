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
    public class AHomeInEveryPort : Template
    {
        public static readonly Guid ID = Guid.Parse("b5b369a9-7915-45df-b491-1af03452b47a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "A Home in Every Port",
                Level = 11,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9f1425e6-3389-4df6-8954-6bb7e0d6bdcd"), Type = TextBlockType.Text, Text = $"You have a reputation in towns and villages you've visited, and residents are always willing to open their doors to you. When in a town or village, during downtime, you can spend 8 hours to locate a resident willing to provide lodging for you and up to six allies for up to 24 hours at no charge. The standard of living within the acquired lodging is comfortable, and square meals are provided at no cost. After 24 hours, you must pay standard prices for further lodging and meals or use this feat again to find a new resident willing to host you." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificStat(Guid.Parse("bee5190a-cc47-4730-96d3-0ddc0f1d6319"), requiredStatValue: 16, Stats.Instances.Charisma.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5c384c94-99e5-4a7a-ba85-e73a4e488d80"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
