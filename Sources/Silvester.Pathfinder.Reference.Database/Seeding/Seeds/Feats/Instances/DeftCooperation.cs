using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DeftCooperation : Template
    {
        public static readonly Guid ID = Guid.Parse("7115f80d-b804-4acc-bb27-6060c1bbb41c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Deft Cooperation",
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
            yield return new TextBlock { Id = Guid.Parse("d347a54f-fda8-4247-aaa4-8ce7e823ca33"), Type = TextBlockType.Text, Text = "When you set things up to help your allies, you also gain some of the fruits of your labors. When you successfully (action: Aid) an attack roll or AC, you gain a +1 circumstance bonus to attack rolls or AC against that enemy until the end of your next turn, whichever you granted to your ally. When you successfully (action: Aid) a skill check, if you attempt the exact same skill check (not just using the same skill, but using it for the same purpose, for instance a check to (action: Climb) the same wall) on your next turn, you gain a +1 circumstance bonus to your skill check." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("5a7818e5-77e3-46c9-99e2-713cb3289de4"), Feats.Instances.PathfinderAgentDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("abfb575c-97d3-4384-9a23-2aa40beb42cd"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
