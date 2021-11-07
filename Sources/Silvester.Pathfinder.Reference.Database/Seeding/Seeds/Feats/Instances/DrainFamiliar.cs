using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DrainFamiliar : Template
    {
        public static readonly Guid ID = Guid.Parse("683e3ebd-f83d-4c0c-b8ad-9eedb7494f58");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Drain Familiar",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("70981385-c3cf-4acb-b9d5-b98b1ef921a1"), Type = TextBlockType.Text, Text = "You expend the power stored in your familiar. During your turn, you gain the ability to cast one spell you prepared today and already cast, without spending a spell slot. You must still (activity: Cast the Spell | Cast a Spell) and meet the spell’s other requirements." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5afa86a8-ce46-4f65-bcb0-5b161aea3d1a"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
