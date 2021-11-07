using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ScapegoatParallelSelf : Template
    {
        public static readonly Guid ID = Guid.Parse("8e250b10-c247-4cc8-bff1-5ccebdba8f7a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Scapegoat Parallel Self",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "Your turn starts or your oracular curse would advance.",
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a639150c-cb88-4ab4-b08d-387c50fa0c51"), Type = TextBlockType.Text, Text = "Seeing Syndara superimpose creatures with similar metaphysical properties, you&#39;ve realized a way to manipulate the effects of your oracular curse. You immediately change your curse to its minor, moderate, or major stage, or back to its mild form, exchanging the curse effect with that of a parallel version of yourself in another reality." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ce1a279b-867c-44b8-937a-8fc688704c05"),
                SourceId = Sources.Instances.FistOfTheRubyPhoenix.ID,
                Page = -1
            };
        }
    }
}
