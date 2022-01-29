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
    public class StabAndBlast : Template
    {
        public static readonly Guid ID = Guid.Parse("ede82cb8-edbb-485f-b942-ec28cc3911f0");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Stab and Blast",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6b1ecd7d-a6e8-4334-8746-02c6430d4fcf"), Type = TextBlockType.Text, Text = $"You slice or smash your opponent with the melee portion of your weapon before pulling the trigger at point-blank range. Make a melee {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} with the required weapon. If the {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} is successful, you can immediately make a ranged {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} against the same target with a +2 circumstance bonus to the attack roll. This counts as two attacks toward your multiple attack penalty, but you don't apply the multiple attack penalty until after making both attacks." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Flourish.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Gunslinger.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9734e024-e7c6-44f4-af46-286658a87fa8"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
