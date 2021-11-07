using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DazingBlow : Template
    {
        public static readonly Guid ID = Guid.Parse("1c7f098e-63ef-41b5-ab62-34e9a4fa8d23");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Dazing Blow",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("79f80d25-2da5-423a-a030-206fcc519cd7"), Type = TextBlockType.Text, Text = "You pummel a held foe, hoping to stagger them. Make a melee (action: Strike) against a creature you have grabbed. The weapon damage from this (action: Strike) is bludgeoning damage. If the (action: Strike) hits, the creature must attempt a Fortitude save against your class DC; this is an (trait: incapacitation) effect." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("d6940cf0-87c0-43b6-a461-55a0856db1eb"),
                CriticalSuccess = "The creature is unaffected.",
                Success = "The creature is stunned 1.",
                Failure = "The creature is stunned 2.",
                CriticalFailure = "The creature is stunned 3.", 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f73804ff-2a02-4b62-a00c-56957f65f0f7"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
