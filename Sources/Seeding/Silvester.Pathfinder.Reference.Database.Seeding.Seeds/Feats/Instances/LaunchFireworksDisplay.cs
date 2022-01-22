using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LaunchFireworksDisplay : Template
    {
        public static readonly Guid ID = Guid.Parse("845b8504-d698-4b12-8a5a-a421907f1b91");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Launch Fireworks Display",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b5e25287-bfed-41b7-8244-466ef9cdd9db"), Type = TextBlockType.Text, Text = $"You set off a fireworks display. You can launch a normal firework to simply create a visual or audible signal within 20 feet or you can choose one of the following special effects. A firework display has the listed traits, and if it costs more than 1 batch of infused reagents, it is noted in its Cost entry." };
            yield return new TextBlock { Id = Guid.Parse("774a80c2-337a-4b31-8a4c-7991df8152fd"), Type = TextBlockType.Text, Text = $"~ Comet: ONE-ACTION ({ToMarkdownLink<Models.Entities.Trait>("visual", Traits.Instances.Visual.ID)} You shoot a streak of shining light in a 60-foot line. All spaces in that line are lit with bright light until the start of your next turn. As part of this action, you can also {ToMarkdownLink<Models.Entities.Action>("Point Out", Actions.Instances.PointOut.ID)} a single creature in the line, and your allies do not need to hear or understand you." };
            yield return new TextBlock { Id = Guid.Parse("9e3520d4-646c-4338-b7d7-af4b40d9a4ea"), Type = TextBlockType.Text, Text = $"~ Flower: ONE-ACTION ({ToMarkdownLink<Models.Entities.Trait>("visual", Traits.Instances.Visual.ID)} You ignite a ring of sparks, creating a shape that might be reminiscent of a flower blooming in the sky. Each enemy with 20 feet of you must attempt a Fortitude save. On a failure, the enemy is dazzled for 1 round, and on a critical failure they are dazzled for 2 rounds." };
            yield return new TextBlock { Id = Guid.Parse("5d0dcafd-30a7-4917-8764-90cfefc6693d"), Type = TextBlockType.Text, Text = $"~ Salute: ONE-ACTION ({ToMarkdownLink<Models.Entities.Trait>("auditory", Traits.Instances.Auditory.ID)} You create a startling bang or whistle, adding an auditory component to your fireworks display. When you launch a salute display, you can choose a confused or fascinated ally within 60 feet. If the ally you chose is fascinated, the noise is so violent that it acts as a hostile effect for the purpose of their fascinated condition (though it has no negative repercussions) automatically ending most applications of the fascinated condition. If they're confused, the sound is so loud and violent that it might snap the ally out of confusion. They can immediately attempt the flat check to remove the confused condition which normally occurs when a creature is damaged. If the confused condition has special rules that remove the flat check when taking damage or make the flat check harder, those rules also apply to the salute." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7d25419b-2fc2-403d-a071-202f55a2a4fc"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
