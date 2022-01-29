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
    public class QuickReversal : Template
    {
        public static readonly Guid ID = Guid.Parse("3255f708-fe74-4393-95f4-9397030d2969");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Quick Reversal",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1eee637d-b25b-4dfb-974d-f1ded38c497c"), Type = TextBlockType.Text, Text = $"You turn your foes' flanking against them with a quick reverse. Make a melee {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} against one of the flanking enemies and make a second {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} with the same weapon or unarmed attack against a different enemy that is flanking you. This second {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} has the same multiple attack penalty of the initial attack and doesn't count toward your multiple attack penalty." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("959b8984-60ba-4c1a-b486-463acc5c3cbb"), Traits.Instances.Fighter.ID);
            builder.Add(Guid.Parse("4b2e3bb9-fcf7-4bc0-8896-479f01aed1af"), Traits.Instances.Flourish.ID);
            builder.Add(Guid.Parse("bfdd082f-3a27-47bb-8026-f555f5a3c5fc"), Traits.Instances.Press.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d890f439-091e-431d-8e11-c290da7734bb"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
