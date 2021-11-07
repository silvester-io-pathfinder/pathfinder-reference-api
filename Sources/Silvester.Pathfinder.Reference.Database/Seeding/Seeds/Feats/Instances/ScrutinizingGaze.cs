using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ScrutinizingGaze : Template
    {
        public static readonly Guid ID = Guid.Parse("235bdeba-a78e-4196-b77c-520593bbbef5");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Scrutinizing Gaze",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("696fe909-eb5d-47c0-a0c0-0a18bf5cb28c"), Type = TextBlockType.Text, Text = "~ Access: You are from Dongun Hold or Alkenstar." };
            yield return new TextBlock { Id = Guid.Parse("73da68d7-389a-4842-861e-e0a19c6f899a"), Type = TextBlockType.Text, Text = "Your family’s traditions of defending against Geb’s undead have granted you a sixth sense for detecting spirits, haunts, and other restless dead, no matter their form or the strength of their presence. You gain a +2 circumstance bonus to Perception checks to (action: Sense Motive) when trying to determine if a creature is possessed or under the influence of an effect that would make them controlled, a +2 circumstance bonus to Perception checks made to see through disguises worn by undead, and a +2 circumstance bonus when using the (action: Seek) action to find hidden or undetected haunts or undead within 30 feet of you." };
            yield return new TextBlock { Id = Guid.Parse("776c944a-41ba-475d-bbc4-56da8ba6ba10"), Type = TextBlockType.Text, Text = "If you aren’t using the (action: Seek) action or searching, the GM automatically rolls a secret check for you to notice haunts or undead within 30 feet anyway. This check doesn’t gain the usual +2 circumstance bonus, and instead takes a –2 circumstance penalty." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("344f93a3-311e-47e0-b873-fed6903114c1"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
