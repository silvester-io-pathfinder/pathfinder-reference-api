using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EmbraceThePain : Template
    {
        public static readonly Guid ID = Guid.Parse("953d0fc7-e5c9-4b1d-af17-aa36fce4829a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Embrace the Pain",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "A creature damages you with a melee attack.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d1d11cfe-eeaf-40ea-919a-c95dc3d57365"), Type = TextBlockType.Text, Text = "Ignoring your pain, you reach out and grab the creature or weapon that caused you harm. Attempt an Athletics check to (action: Grapple) the triggering creature or to (action: Disarm) the creature of the triggering weapon." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8428636f-beb3-4d71-af0d-08a97bea8b08"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
