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
    public class Swipe : Template
    {
        public static readonly Guid ID = Guid.Parse("9acecaf3-7e6f-4f13-b973-38e56bdd54d2");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Swipe",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4d4aefe1-1690-416a-a6d0-8b96a43fc468"), Type = TextBlockType.Text, Text = $"You make a wide, arcing swing. Make a single melee {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} and compare the attack roll result to the ACs of up to two foes, each of whom must be within your melee reach and adjacent to the other." };
            yield return new TextBlock { Id = Guid.Parse("fb7a8c40-553e-4bd3-8e36-0adee675e054"), Type = TextBlockType.Text, Text = $"Roll damage only once and apply it to each creature you hit. A Swipe counts as two attacks for your multiple attack penalty." };
            yield return new TextBlock { Id = Guid.Parse("49280132-32ae-4034-8bea-754cef58cb2e"), Type = TextBlockType.Text, Text = $"If you're using a weapon with the {ToMarkdownLink<Models.Entities.Trait>("sweep", Traits.Instances.Sweep.ID)} trait, its modifier applies to all your Swipe attacks." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("69a4ce5c-c9a0-485a-81f5-33b62f9ff69a"), Traits.Instances.Barbarian.ID);
            builder.Add(Guid.Parse("c41cfc04-28fd-4aef-8e0d-657b38ef7e74"), Traits.Instances.Fighter.ID);
            builder.Add(Guid.Parse("7333ee2b-0203-43f5-bbe3-3bbc892a61f0"), Traits.Instances.Flourish.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8f08dd2b-9da5-4e8c-a114-5aa9eae229fe"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
