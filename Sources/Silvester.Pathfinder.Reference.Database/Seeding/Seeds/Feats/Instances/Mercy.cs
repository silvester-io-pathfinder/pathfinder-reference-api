using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Mercy : Template
    {
        public static readonly Guid ID = Guid.Parse("8402ab66-8463-45d4-a1f0-75feba4ba35a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Mercy",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a97d3c99-69c1-4fce-8022-91067f5b39da"), Type = TextBlockType.Text, Text = "Your touch relieves fear and restores movement. If the next action you use is to cast (spell: lay on hands), you can attempt to counteract a (spell: fear) effect or an effect imposing the paralyzed condition on the target, in addition to the other benefits of (spell: lay on hands)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("ce6598d2-58b8-4b64-a12a-d247018d4148"), Feats.Instances.BlessedOneDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a211731c-308f-4b5d-8475-7986484c8e13"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
