using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class InternalCompartment : Template
    {
        public static readonly Guid ID = Guid.Parse("d3e4669a-8c17-42ab-afa5-ca71eed281fb");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Internal Compartment",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("24c1af4c-7244-41d5-979a-47f46bf7a340"), Type = TextBlockType.Text, Text = "You can hide a small object of up to light Bulk inside a hollow cavity on one of your forearms. It takes three (action: Interact) actions to store an object in this way. You gain a +4 circumstance bonus to the DCs of checks for others to (action: Seek) or (action: Steal) objects stored inside your arm. If you store a weapon in your arm, you can use a single action to (action: Interact) to draw the weapon into the hand corresponding to your internal cavity, then (action: Strike) with the weapon." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a3265311-164a-4aee-bb34-766bfd4601fe"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
