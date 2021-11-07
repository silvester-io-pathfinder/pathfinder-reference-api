using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FieldOfRoots : Template
    {
        public static readonly Guid ID = Guid.Parse("e45b0d2f-c832-4001-bec4-b7e265ded151");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Field of Roots",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f2b47a6c-158c-4ad0-a52a-25d75d3c34bf"), Type = TextBlockType.Text, Text = "Your eidolon extends its roots underground to entangle and possibly damage all foes nearby. All enemies within your eidolon’s reach take damage of the same type and amount as your eidolon’s most damaging (action: Strike), depending on their Reflex saves. Any ongoing effects of the save last until the enemy either (action: Escapes | Escape) or leaves your eidolon’s reach. After using Field of Roots, your eidolon is immobilized until it takes a single action, which has the (trait: manipulate) trait, to detach from the ground; this also ends any remaining effects on enemies from Field of Roots." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("2ec7c487-480d-4c71-9d88-ae4789d8eeb2"),
                CriticalSuccess = "The enemy is unaffected.",
                Success = "The enemy takes no damage, but takes a –10 foot circumstance penalty to its Speeds.",
                Failure = "The enemy takes half damage, takes a –10-foot circumstance penalty to its Speeds, and, at the end of each of its turns, takes half damage again.",
                CriticalFailure = "The enemy is immobilized, takes full damage, and, at the end of each of its turns, takes full damage again.", 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ba56fc79-2cce-4b0a-935f-32c3ce6f6cf1"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
