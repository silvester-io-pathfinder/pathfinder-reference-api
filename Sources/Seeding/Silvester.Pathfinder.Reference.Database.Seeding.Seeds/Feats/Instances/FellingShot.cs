using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FellingShot : Template
    {
        public static readonly Guid ID = Guid.Parse("2010383d-b9fe-449c-a3d0-0b5548b31c11");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Felling Shot",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7040a194-1413-4dc6-a499-b972da4ae778"), Type = TextBlockType.Text, Text = "Your ranged attacks can shoot an unprepared foe right out of the air. Make a (action: Strike) with a ranged weapon or a thrown weapon against a flat-footed creature. If the (action: Strike) is a success and deals damage, the target must attempt a Reflex save against your class DC with the following effects." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("24acbf05-58dd-4ef2-9a98-ccc6ef37a5bf"),
                
                Success = "The target is unaffected.",
                Failure = "The target falls up to 120 feet. If it hits the ground, it takes no damage from the fall.",
                CriticalFailure = "As failure, and the target can't fly, jump, levitate, or otherwise leave the ground until the end of your next turn.", 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7990d913-d632-45fa-9e89-50038e492e6d"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
