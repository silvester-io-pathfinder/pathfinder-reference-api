using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CrushingGrab : Template
    {
        public static readonly Guid ID = Guid.Parse("1459f65f-abf8-4646-add9-00289b029527");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Crushing Grab",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3aca1206-5ed0-46be-82ef-45fed439755e"), Type = TextBlockType.Text, Text = "Like a powerful constrictor, you crush targets in your unyielding grasp. When you successfully (action: Grapple) a creature, you can deal bludgeoning damage to that creature equal to your Strength modifier. You can make this attack (trait: nonlethal) with no penalty." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cbea5bb3-f055-43a8-8f1b-4c1b4bd2493c"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
