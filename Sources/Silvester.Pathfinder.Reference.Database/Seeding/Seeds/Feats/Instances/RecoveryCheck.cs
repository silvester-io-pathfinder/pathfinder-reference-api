using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RecoveryCheck : Template
    {
        public static readonly Guid ID = Guid.Parse("4d03cca2-5413-4b8f-9f9d-dbd470a80f72");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Recovery Check",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("65eab71b-a256-4850-a3bf-cc44a3055f23"), Type = TextBlockType.Text, Text = "When you’re dying, at the start of each of your turns, you must attempt a flat check with a DC equal to 10 + your current dying value to see if you get better or worse. The effects of this check are as follows." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("cb12102a-c04c-4bb0-8fcd-b04b064a43df"),
                CriticalSuccess = "Your dying value is reduced by 2.",
                Success = "Your dying value is reduced by 1.",
                Failure = "Your dying value increases by 1.",
                CriticalFailure = "Your dying value increases by 2.", 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a68e8dd3-4586-4ad8-80ea-2200c3cbc07b"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
