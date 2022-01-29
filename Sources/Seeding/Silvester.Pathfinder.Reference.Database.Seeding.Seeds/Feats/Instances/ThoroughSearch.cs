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
    public class ThoroughSearch : Template
    {
        public static readonly Guid ID = Guid.Parse("51567d9c-caf4-4d75-87a1-9048ba76f248");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Thorough Search",
                Level = 3,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ad1005e2-69b6-4937-a75e-e413f67038b6"), Type = TextBlockType.Text, Text = $"You take your time searching to ensure you find everything. When {ToMarkdownLink<Models.Entities.Activity>("Searching", Activities.Instances.Search.ID)}, you can take twice as long to search. Normally this means you {ToMarkdownLink<Models.Entities.Activity>("Search", Activities.Instances.Search.ID)} at up to one quarter of your Speed, to a maximum of 150 feet per minute to check everything, or 75 feet per minute to check everything before you walk into it. If you do, you gain a +2 circumstance bonus to your Perception checks to {ToMarkdownLink<Models.Entities.Action>("Seek", Actions.Instances.Seek.ID)}." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("c8a4aa75-fb1f-4ef4-a2c0-49fe069564a6"), Proficiencies.Instances.Expert.ID, Skills.Instances.Perception.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9aae1155-42b0-45c4-9406-ef790d87f59a"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
