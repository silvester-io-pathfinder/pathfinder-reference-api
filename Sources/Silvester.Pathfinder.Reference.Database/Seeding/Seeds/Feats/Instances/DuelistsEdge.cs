using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DuelistsEdge : Template
    {
        public static readonly Guid ID = Guid.Parse("3a0d3394-ab09-433b-9e55-e7084609dcd6");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Duelist's Edge",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You roll initiative, and you can observe at least one opponent.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("18f02ac1-e2f3-4b72-9f9b-a2823b35ba09"), Type = TextBlockType.Text, Text = "You hone your reaction time through duels and learn to draw your weapon seamlessly as you begin a fight. You gain a +2 circumstance bonus to the triggering initiative roll, and you can immediately (action: Interact) to draw your Aldori dueling sword." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("9f740c02-ec04-48b5-8c4d-b49b7d82f1d6"), Feats.Instances.AldoriDuelistDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f6fcf451-330f-4db6-b196-ceb8be05a8d0"),
                SourceId = Sources.Instances.LostOmensWorldGuide.ID,
                Page = -1
            };
        }
    }
}
