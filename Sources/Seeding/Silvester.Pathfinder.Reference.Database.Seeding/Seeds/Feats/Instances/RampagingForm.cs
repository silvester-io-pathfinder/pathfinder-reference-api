using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RampagingForm : Template
    {
        public static readonly Guid ID = Guid.Parse("ad018001-b28d-439c-b47f-3fd12625e39d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Rampaging Form",
                Level = 17,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "If you are a frozen wind kitsune, your form is ice instead of fire. This changes the immunity and damage from the (spell: fiery body) effect to cold, changes the weakness to fire, and changes (spell: produce flame) to (spell: ray of frost).",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("fe03757c-66d1-4f0a-ad15-c90feb69e6cb"), Type = TextBlockType.Text, Text = "Once per day, when you (action: Change Shape | Change Shape - Kitsune) into a fox, you can instead gain the effects of both the canine form of 5th-level (spell: animal form) and 7th-level (spell: fiery body) for 1 minute or until you shift back, whichever comes first. You can cast (spell: produce flame) from the fiery body effect even though you're in a battle form." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.Manual(Guid.Parse("a5dcedda-98fa-40b6-9a35-5b849a64ffd5"), "Change Shape with a fox alternate form.");
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a020ff77-2009-4e7c-92aa-9661f3c76c6e"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
