using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BlazeOfRevelation : Template
    {
        public static readonly Guid ID = Guid.Parse("ef9c8057-f0f0-4632-9737-c9ed24c090f6");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Blaze of Revelation",
                Level = 18,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("cdd7c0a7-6efe-4c4b-9aa7-97f61ccbeacc"), Type = TextBlockType.Text, Text = $"Your mind and body can, for a short time, withstand the devastation of overdrawing your curse. When you would become overwhelmed by your curse, you can forestall the effects for up to 1 minute. On each of your turns during that time, you can cast one revelation spell granted by your mystery (but not domain spells, spells from {ToMarkdownLink<Models.Entities.Feat>("Diverse Mystery", Feats.Instances.DiverseMystery.ID)}, or other revelation spells you gained from other abilities) without spending Focus Points or taking any further negative effects." };
            yield return new TextBlock { Id = Guid.Parse("3b14240e-1892-46c9-9f49-af68fc50bd45"), Type = TextBlockType.Text, Text = $"At the end of the minute, the durations of any revelation spells you cast during that time end, you take the normal effects from being overwhelmed by your curse, and you must attempt a DC 40 Fortitude save." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("c511408d-8155-40d1-bcad-2eb332861ee3"),
                CriticalSuccess = "You aren't otherwise affected.",
                Success = "You are drained 2 and can't reduce or remove this condition until your next preparations.",
                Failure = "You are drained 4 and can't reduce or remove this condition until your next preparations.",
                CriticalFailure = "You die.", 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fdb727ac-3c1c-4c31-a9c4-d6e1121eb8ca"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
