using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ReactiveShield : Template
    {
        public static readonly Guid ID = Guid.Parse("b4eb746f-75ce-4da0-8c4f-3b3c1cd7f5f9");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Reactive Shield",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "An enemy hits you with a melee Strike.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("98a1b130-0c47-4f4b-a460-55f06bf39ee4"), Type = TextBlockType.Text, Text = "You can snap your shield into place just as you would take a blow, avoiding the hit at the last second. You immediately use the (action: Raise a Shield) action and gain your shield’s bonus to AC. The circumstance bonus from the shield applies to your AC when you’re determining the outcome of the triggering attack." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("91693230-1621-4fa7-80ba-2ba2d9ecad8a"), Feats.Instances.VikingDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0996658b-4679-4d75-928f-b7049ea5ce26"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
