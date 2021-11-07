using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GreaterCruelty : Template
    {
        public static readonly Guid ID = Guid.Parse("e793d4b2-4f3c-4f13-a215-2e7f163d0133");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Greater Cruelty",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c8c72ce8-aa8e-494e-a46f-829d2d53539c"), Type = TextBlockType.Text, Text = "The extent of the corruption within you does more than simply sap your foes’ strength, it devastates their minds and reflexes. When you use (feat: Cruelty), choose whether you want to make the creature enfeebled as normal, to make it clumsy 1 on a failed save (clumsy 2 on a critical failure), or to make it stupefied 1 on a failed save (stupefied 2 on a critical failure)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("bd932b05-e740-4af2-8571-9991a02fb23a"), Feats.Instances.Cruelty.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("439278de-f440-4820-95b9-41e609da0d1d"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
