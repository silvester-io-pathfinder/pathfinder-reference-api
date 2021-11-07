using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FellingShot : Template
    {
        public static readonly Guid ID = Guid.Parse("0adaec57-924c-4f4a-85bb-ba3e4f5b5a2d");

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
            yield return new TextBlock { Id = Guid.Parse("427def41-eb2c-4b5a-90f4-0be38724c96e"), Type = TextBlockType.Text, Text = "Your ranged attacks can shoot an unprepared foe right out of the air. Make a (action: Strike) with a ranged weapon or a thrown weapon against a flat-footed creature. If the (action: Strike) is a success and deals damage, the target must attempt a Reflex save against your class DC with the following effects." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("3f4b0b0c-fe81-489f-8784-aeed2f687fdb"),
                
                Success = "The target is unaffected.",
                Failure = "The target falls up to 120 feet. If it hits the ground, it takes no damage from the fall.",
                CriticalFailure = "As failure, and the target can’t fly, jump, levitate, or otherwise leave the ground until the end of your next turn.", 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ab2014a9-422d-4ae3-bcf0-81177e179dad"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
