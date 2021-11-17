using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class InternalCompartment : Template
    {
        public static readonly Guid ID = Guid.Parse("77adfda0-4f2a-486d-9fa0-2032ae36d3bb");

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
            yield return new TextBlock { Id = Guid.Parse("36f40fd4-c12a-43a9-a47f-7f01c4c674e2"), Type = TextBlockType.Text, Text = "You can hide a small object of up to light Bulk inside a hollow cavity on one of your forearms. It takes three (action: Interact) actions to store an object in this way. You gain a +4 circumstance bonus to the DCs of checks for others to (action: Seek) or (action: Steal) objects stored inside your arm. If you store a weapon in your arm, you can use a single action to (action: Interact) to draw the weapon into the hand corresponding to your internal cavity, then (action: Strike) with the weapon." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f047c88a-13dd-45ac-a2ee-5d52bce7a73e"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
