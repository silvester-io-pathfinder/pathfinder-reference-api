using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FindFlaws : Template
    {
        public static readonly Guid ID = Guid.Parse("d1107867-f5ae-424a-ba6a-578822c16dec");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Find Flaws",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per round"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("32d7d528-bb9e-47b9-be4a-d0c392eb2e64"), Type = TextBlockType.Text, Text = "You determine a creature’s weaknesses, whether a literal weakness or a metaphysical one. (action: Recall Knowledge) about a creature, using your Charisma modifier instead of the usual ability modifier for the skill you’re using to (action: Recall Knowledge). The creature must be either one you can see or one you’re specifically Investigating in advance during exploration. The result depends on your (action: Recall Knowledge) check, which has the following additional effects as well as the usual effects of (action: Recall Knowledge)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("37f99608-7a53-4661-8e3e-0b30991daefc"),
                CriticalSuccess = "You learn all of the creature’s resistances, weaknesses, and immunities. If you would have learned any of them already from (action: Recall Knowledge), you learn different information instead. You can then use (feat: Esoteric Antithesis) without spending an additional action.",
                Success = "You learn the creature’s highest weakness, if any. If you would have learned it already from (action: Recall Knowledge), you learn different information instead. You can then use (feat: Esoteric Antithesis) without spending an additional action.",
                Failure = "You couldn’t quite figure it out, so you decide to invoke a wide range of superstitions and narrow it down from there. You can use (feat: Esoteric Antithesis) as your next action.",
                CriticalFailure = "You came up with the wrong information and nearly made a critical mistake, distracting yourself. You become flat-footed until the beginning of your next turn and can’t use (feat: Esoteric Antithesis) this round.", 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("014b5f3d-d470-42be-9fb4-350c5c502d8f"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
