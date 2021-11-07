using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LaunchFireworksDisplay : Template
    {
        public static readonly Guid ID = Guid.Parse("7eb78351-b60d-44f4-891c-d54c35dd50f4");

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
            yield return new TextBlock { Id = Guid.Parse("ee9de196-cd78-43b4-b864-3d2746e14690"), Type = TextBlockType.Text, Text = "You set off a fireworks display. You can launch a normal firework to simply create a visual or audible signal within 20 feet or you can choose one of the following special effects. A firework display has the listed traits, and if it costs more than 1 batch of infused reagents, it is noted in its Cost entry." };
            yield return new TextBlock { Id = Guid.Parse("35273d06-71cf-4cc3-8ef9-451fd5f5434d"), Type = TextBlockType.Text, Text = "~ Comet: ONE-ACTION ((trait: visual) You shoot a streak of shining light in a 60-foot line. All spaces in that line are lit with bright light until the start of your next turn. As part of this action, you can also (action: Point Out) a single creature in the line, and your allies do not need to hear or understand you." };
            yield return new TextBlock { Id = Guid.Parse("ebc402e4-f72a-4e69-b9e1-049abeb536f4"), Type = TextBlockType.Text, Text = "~ Flower: ONE-ACTION ((trait: visual) You ignite a ring of sparks, creating a shape that might be reminiscent of a flower blooming in the sky. Each enemy with 20 feet of you must attempt a Fortitude save. On a failure, the enemy is dazzled for 1 round, and on a critical failure they are dazzled for 2 rounds." };
            yield return new TextBlock { Id = Guid.Parse("602f66ad-9cd0-46bb-97c0-cb8bf26f5182"), Type = TextBlockType.Text, Text = "~ Salute: ONE-ACTION ((trait: auditory) You create a startling bang or whistle, adding an auditory component to your fireworks display. When you launch a salute display, you can choose a confused or fascinated ally within 60 feet. If the ally you chose is fascinated, the noise is so violent that it acts as a hostile effect for the purpose of their fascinated condition (though it has no negative repercussions) automatically ending most applications of the fascinated condition. If they’re confused, the sound is so loud and violent that it might snap the ally out of confusion. They can immediately attempt the flat check to remove the confused condition which normally occurs when a creature is damaged. If the confused condition has special rules that remove the flat check when taking damage or make the flat check harder, those rules also apply to the salute." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("37e597c8-8cc5-4ea7-8378-16823b355351"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
