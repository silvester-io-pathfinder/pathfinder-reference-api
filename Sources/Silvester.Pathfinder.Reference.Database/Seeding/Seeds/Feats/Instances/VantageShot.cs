using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class VantageShot : Template
    {
        public static readonly Guid ID = Guid.Parse("f9221d88-863b-47c9-98b6-666a381aa6aa");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Vantage Shot",
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
            yield return new TextBlock { Id = Guid.Parse("0cc179f1-6c33-4854-9b69-748527426875"), Type = TextBlockType.Text, Text = "You and your spotter take advantage of each other’s attacks to momentarily hide and throw your foes off-balance against your follow-up attack. When you successfully make a ranged (action: Strike) against a foe, your spotter can use a reaction to attempt a Stealth check against the foe’s Perception DC. On a success, the foe is flat-footed against the spotter’s next attack before the end of your spotter’s next turn. Similarly, when your spotter successfully makes a ranged (action: Strike) against a foe, you can use a reaction to attempt a Stealth check against the foe’s Perception DC. On a success, the foe is flat-footed against your next attack against them before the end of your next turn." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("2a7327aa-d4a1-4ee3-bb0b-5567d21d4df6"), Feats.Instances.SnipingDuoDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c745b591-6ef4-446d-aa11-9e5923fcc4ff"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
