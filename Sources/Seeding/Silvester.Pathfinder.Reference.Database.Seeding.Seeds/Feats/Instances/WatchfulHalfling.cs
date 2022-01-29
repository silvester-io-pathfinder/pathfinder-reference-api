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
    public class WatchfulHalfling : Template
    {
        public static readonly Guid ID = Guid.Parse("70b427b9-36ee-4c1e-bb29-316cc0801ec6");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Watchful Halfling",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b8e530cc-b602-422e-8712-3e625f850ce2"), Type = TextBlockType.Text, Text = $"Your communal lifestyle causes you to pay close attention to the people around you, allowing you to more easily notice when they act out of character. You gain a +2 circumstance bonus to Perception checks when using the {ToMarkdownLink<Models.Entities.Action>("Sense Motive", Actions.Instances.SenseMotive.ID)} basic action to notice enchanted or possessed characters. If you aren't actively using {ToMarkdownLink<Models.Entities.Action>("Sense Motive", Actions.Instances.SenseMotive.ID)} on an enchanted or possessed character, the GM rolls a secret check, without the usual circumstance and with a –2 circumstance penalty, for you to potentially notice the enchantment or possession anyway." };
            yield return new TextBlock { Id = Guid.Parse("a90c8f78-4f15-4351-b15a-2e304965b128"), Type = TextBlockType.Text, Text = $"In addition to using it for skill checks, you can use the {ToMarkdownLink<Models.Entities.Action>("Aid", Actions.Instances.Aid.ID)} basic action to grant a bonus to another creature's saving throw or other check to overcome enchantment or possession. As usual for {ToMarkdownLink<Models.Entities.Action>("Aid", Actions.Instances.Aid.ID)}, you need to prepare by using an action on your turn to encourage the creature to fight against the effect." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("7b994beb-6684-43ad-bd2c-cd37678c9318"), Traits.Instances.Halfling.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f2e41583-8960-4223-85b7-c7494a864545"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
