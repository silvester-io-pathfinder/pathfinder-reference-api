using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class InvokeCelestialPrivilege : Template
    {
        public static readonly Guid ID = Guid.Parse("6dfe90ca-f659-4c1e-8101-6401c7d52176");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Invoke Celestial Privilege",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You attempt a saving throw against a divine effect, but you haven't rolled yet.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("80f5439a-3530-4678-bf1e-0fa8841cd485"), Type = TextBlockType.Text, Text = "You rise above the triggering effect refusing to be harmed by it. You gain a +1 circumstance bonus to the triggering saving throw and to any other saving throws you attempt against (trait: divine) effects until the start of your next turn." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d524f63c-cd86-4804-acfc-276cca874bef"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
