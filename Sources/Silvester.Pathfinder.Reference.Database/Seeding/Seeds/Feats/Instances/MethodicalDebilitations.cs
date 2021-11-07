using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MethodicalDebilitations : Template
    {
        public static readonly Guid ID = Guid.Parse("e6891712-1ee8-42dc-a637-22a232030332");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Methodical Debilitations",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("346f92f9-3ec4-4d7a-bd5b-bf857c1248a9"), Type = TextBlockType.Text, Text = "You strategically craft your debilitations to lessen or negate an enemy’s tactical advantages. Add the following debilitations to the list you can choose from when you use (feat: Debilitating Strike)." };
            yield return new TextBlock { Id = Guid.Parse("6439149e-3338-434f-b31f-0c2b963bf31f"), Type = TextBlockType.Enumeration, Text = " Debilitation: The target can’t flank other creatures, and it can’t provide flanking for its allies." };
            yield return new TextBlock { Id = Guid.Parse("4bc83881-003c-4e17-bee5-764c153db4af"), Type = TextBlockType.Enumeration, Text = " Debilitation: The target doesn’t gain a circumstance bonus to AC from Raising a Shield, lesser cover, or standard cover; it gains only a +2 circumstance bonus to AC from greater cover or (action: Taking Cover | Take Cover)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificRacket(Guid.Parse("b6012b1c-2d39-4eb5-808e-213afeb4971a"), Rackets.Instances.Mastermind.ID);
            builder.HaveSpecificFeat(Guid.Parse("5128ee8e-8478-40b1-a0cf-f375ec977d2d"), Feats.Instances.DebilitatingStrike.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("af2ef1e5-cada-4985-995d-2f3ec4a19953"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
