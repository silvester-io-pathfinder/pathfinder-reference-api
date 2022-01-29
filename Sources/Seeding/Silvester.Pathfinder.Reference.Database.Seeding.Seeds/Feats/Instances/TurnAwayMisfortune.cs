using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TurnAwayMisfortune : Template
    {
        public static readonly Guid ID = Guid.Parse("fe33bf27-0f9a-4183-82e1-c136cae40b33");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Turn Away Misfortune",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You would attempt a roll affected by a misfortune effect.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3ed140fb-ae97-4717-8e07-dc8f58c471f5"), Type = TextBlockType.Text, Text = $"You perform a superstition, such as casting salt over your shoulder to ward off bad luck. Turn Away Misfortune's {ToMarkdownLink<Models.Entities.Trait>("fortune", Traits.Instances.Fortune.ID)} trait cancels out the {ToMarkdownLink<Models.Entities.Trait>("misfortune", Traits.Instances.Misfortune.ID)} effect, causing you to roll normally" };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7021bbe2-5378-4f60-ac0f-10c6a2c97ad0"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
