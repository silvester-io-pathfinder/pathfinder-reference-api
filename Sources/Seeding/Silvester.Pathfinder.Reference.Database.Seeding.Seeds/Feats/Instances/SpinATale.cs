using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SpinATale : Template
    {
        public static readonly Guid ID = Guid.Parse("409b1999-69e2-44e4-b8c2-cfd6c9fce8df");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Spin a Tale",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once every 10 minutes"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f63c7723-0d11-4b14-89ff-5a989c7f8009"), Type = TextBlockType.Text, Text = $"You tell a story, designating one of your allies (but not yourself) as the hero of the story, and one enemy as the villain; both must be within 60 feet. The hero gains a +1 status bonus to attack rolls and saving throws against the villain until the start of your next turn. If you Spin a Tale on your next turn, the story continues for another round, for a maximum of 10 rounds. While the tale continues, minor, crude illusions spring into being in your space; these are {ToMarkdownLink<Models.Entities.Trait>("arcane", Traits.Instances.Arcane.ID)} {ToMarkdownLink<Models.Entities.Trait>("illusion", Traits.Instances.Illusion.ID)} effects that have no mechanical impact other than illustrating your tale." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("30ea2bae-04b8-484c-ba38-5e457974a974"),
                SourceId = Sources.Instances.StrengthOfThousands.ID,
                Page = -1
            };
        }
    }
}
