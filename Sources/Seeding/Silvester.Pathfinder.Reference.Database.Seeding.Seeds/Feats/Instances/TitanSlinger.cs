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
    public class TitanSlinger : Template
    {
        public static readonly Guid ID = Guid.Parse("b9fffa3e-0586-4ee9-b35f-0c6654099f38");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Titan Slinger",
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
            yield return new TextBlock { Id = Guid.Parse("81f2c412-3aba-4909-b77f-4ed690f25498"), Type = TextBlockType.Text, Text = $"You have learned how to use your sling to fell enormous creatures. When you hit on an attack with a {ToMarkdownLink<Models.Items.Instances.RangedWeapon>("sling", Items.RangedWeapons.Instances.Sling.ID)} against a Large or larger creature, increase the size of the weapon damage die by one step (details on increasing weapon damage die sizes can be found on page 279)." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Halfling.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d5d0c682-22a2-4c4d-880f-244d7bf543d5"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
