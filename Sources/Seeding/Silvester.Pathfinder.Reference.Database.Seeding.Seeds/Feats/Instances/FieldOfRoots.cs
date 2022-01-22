using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FieldOfRoots : Template
    {
        public static readonly Guid ID = Guid.Parse("a434d670-c843-4055-93c4-0ff342c33509");

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
            yield return new TextBlock { Id = Guid.Parse("9b193de9-40b1-49da-84aa-4283b3185f9f"), Type = TextBlockType.Text, Text = $"Your eidolon extends its roots underground to entangle and possibly damage all foes nearby. All enemies within your eidolon's reach take damage of the same type and amount as your eidolon's most damaging {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)}, depending on their Reflex saves. Any ongoing effects of the save last until the enemy either {ToMarkdownLink<Models.Entities.Action>("Escapes", Actions.Instances.Escape.ID)} or leaves your eidolon's reach. After using Field of Roots, your eidolon is immobilized until it takes a single action, which has the {ToMarkdownLink<Models.Entities.Trait>("manipulate", Traits.Instances.Manipulate.ID)} trait, to detach from the ground; this also ends any remaining effects on enemies from Field of Roots." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("0b84e88b-a21b-4fb2-8417-186258a74b3e"),
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
                Id = Guid.Parse("d0c54f4f-d457-4a2c-b08a-b4ffe667191f"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
