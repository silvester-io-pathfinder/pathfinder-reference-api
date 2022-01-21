using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class VisionsOfSin : Template
    {
        public static readonly Guid ID = Guid.Parse("7e1152cc-d116-48f1-acf8-e3324cab2768");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Visions of Sin",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per 10 minutes"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("715da03c-96f7-4f95-a6c7-4d70f45d62ae"), Type = TextBlockType.Text, Text = "Your eidolon summons images of its sin into the mind of a target creature within 30 feet, tormenting and confusing the target. The target must attempt a Will save against your spell DC with the following effects. The effects last until the end of your next turn, but your eidolon can use a single action, which has the (trait: concentrate) trait, to extend the effects until the end of your next turn (like (action: Sustaining a Spell | Sustain a Spell)), to a maximum duration of 1 minute. If the target is evil, it takes a –2 circumstance penalty to its save. Regardless of whether it succeeds, the target becomes temporarily immune for 1 day." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("b0161b02-f9cb-4e17-af42-1467d7035892"),
                CriticalSuccess = "The target is unaffected.",
                Success = "The target can't use reactions.",
                Failure = "The target is slowed 1 and can't use reactions.",
                CriticalFailure = "As failure, and the target is also confused for 1 round. The confusion can't be extended, but the other effects can.", 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("dcccf1f9-c9f2-4857-89b0-b6f1375b70ec"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
