using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ExpandAura : Template
    {
        public static readonly Guid ID = Guid.Parse("9d6dab3b-39db-4c19-9d5a-63043327157f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Expand Aura",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("80627a66-e2a3-4a4a-8de1-a782e4e835e1"), Type = TextBlockType.Text, Text = "You focus your divine power to extend your influence. Select one aura you have from a champion feat or feature, such as (feat: Aura of Courage) or (feat: Aura of Life). The radius of the aura is doubled until the start of your next turn." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            //TODO: Add prerequisites.
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7398c2af-33ef-44cf-8b60-c317e34e9885"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
