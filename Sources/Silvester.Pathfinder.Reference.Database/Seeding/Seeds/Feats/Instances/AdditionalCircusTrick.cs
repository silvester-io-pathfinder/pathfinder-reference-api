using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AdditionalCircusTrick : Template
    {
        public static readonly Guid ID = Guid.Parse("f88bbf2d-8d11-4047-9260-11c7b139a258");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Additional Circus Trick",
                Level = 3,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f82c4334-4ff4-47f6-a13a-dbb170e7f3b2"), Type = TextBlockType.Text, Text = "Your signature trick can have one additional trait beyond the number provided in __Table 2: Trick Progression on page 63 of Pathfinder #151: The Show Must Go On__. If the trick trait has an associated skill (such as Intimidation with the (trait: fire) trait) and that skill is one of your trick checks, your checks with that skill to Perform a Trick aren’t penalized if you Perform a Trick using a different skill." };
            yield return new TextBlock { Id = Guid.Parse("c6c4b063-4bca-4561-96b1-ea58ba365291"), Type = TextBlockType.Text, Text = "For example, if your signature trick has Acrobatics and Intimidation as trick checks and you take this feat to add the (trait: fire) trait, you can Perform a Trick using Acrobatics (at no penalty), then Acrobatics again (at a -5 penalty), and then Intimidation (at no penalty)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.Manual(Guid.Parse("54e7ae6b-7730-4172-bc29-7b6dd78edc92"), "You must have a signature trick.");
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b44ffe78-aa84-44a6-ba42-298bed194920"),
                SourceId = Sources.Instances.ExtinctionCurse.ID,
                Page = -1
            };
        }
    }
}
