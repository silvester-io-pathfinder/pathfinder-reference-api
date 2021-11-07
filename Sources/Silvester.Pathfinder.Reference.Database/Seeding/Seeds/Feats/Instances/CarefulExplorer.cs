using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CarefulExplorer : Template
    {
        public static readonly Guid ID = Guid.Parse("6ab5626f-a6d0-4b7d-9529-0b8b4231e981");

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
            yield return new TextBlock { Id = Guid.Parse("1a896827-c654-4c97-9f09-38ff9b9ba311"), Type = TextBlockType.Text, Text = "You’ve explored enough dusty tombs and hidden vaults to gain a sixth sense about traps, and you sometimes notice them even when you’re not trying to. Even if you aren’t (action: Searching | Search) in exploration mode, you get a check to find traps that normally require you to (action: Search) for them. You still need to meet any other requirements to find the trap." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("522cbbd5-5ad2-453a-b205-3cdbf6daff01"), Feats.Instances.PathfinderAgentDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("020abcc1-8a8f-40ca-8175-d9d8849b2c54"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
