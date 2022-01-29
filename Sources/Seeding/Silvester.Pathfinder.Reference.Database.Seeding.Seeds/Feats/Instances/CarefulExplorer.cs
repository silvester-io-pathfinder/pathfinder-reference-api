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
    public class CarefulExplorer : Template
    {
        public static readonly Guid ID = Guid.Parse("681f7585-65dc-4699-b190-5b8815304d30");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Careful Explorer",
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
            yield return new TextBlock { Id = Guid.Parse("7e80ad7b-a0fc-4e8c-b84f-e77f14e424a5"), Type = TextBlockType.Text, Text = $"You've explored enough dusty tombs and hidden vaults to gain a sixth sense about traps, and you sometimes notice them even when you're not trying to. Even if you aren't {ToMarkdownLink<Models.Entities.Activity>("Searching", Activities.Instances.Search.ID)} in exploration mode, you get a check to find traps that normally require you to {ToMarkdownLink<Models.Entities.Activity>("Search", Activities.Instances.Search.ID)} for them. You still need to meet any other requirements to find the trap." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("084d5a34-5b3a-4447-9f97-dea4f159b9e2"), Feats.Instances.PathfinderAgentDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2e135bd8-c62b-4eaf-bfaf-659601fb7ef1"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
