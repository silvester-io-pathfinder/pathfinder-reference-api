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
    public class FearsomeBrute : Template
    {
        public static readonly Guid ID = Guid.Parse("14e6896e-75e2-4091-b5cc-d476dac6d2f1");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Fearsome Brute",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a5dc15f9-8199-49a6-b4b1-3f7f85cf051e"), Type = TextBlockType.Text, Text = $"Fear makes your foes weak and more vulnerable to your attacks. You gain a circumstance bonus to damage rolls for {ToMarkdownLink<Models.Entities.Action>("Strikes", Actions.Instances.Strike.ID)} against frightened creatures. The bonus is equal to double the target's frightened value." };
            yield return new TextBlock { Id = Guid.Parse("abd5912f-370a-4605-99d5-edb7b12b21b0"), Type = TextBlockType.Text, Text = $"If you have master proficiency in Intimidation, increase the bonus to triple the target's frightened value." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("204f255d-2cbc-4242-ac6e-5bf41553d69e"), Traits.Instances.Fighter.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c074a797-1f1c-47c4-a538-aaccbf789443"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
