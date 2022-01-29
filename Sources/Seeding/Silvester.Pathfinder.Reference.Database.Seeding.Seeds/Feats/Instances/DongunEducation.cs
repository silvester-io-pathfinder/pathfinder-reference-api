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
    public class DongunEducation : Template
    {
        public static readonly Guid ID = Guid.Parse("24d90ca5-e919-4239-87a1-7d31cfe69865");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Dongun Education",
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
            yield return new TextBlock { Id = Guid.Parse("58b03a91-8503-4540-a5f3-f33a7abc69fb"), Type = TextBlockType.Text, Text = $"~ Access: You are from Dongun Hold or Alkenstar." };
            yield return new TextBlock { Id = Guid.Parse("777c4447-5477-41a1-9fce-af58b7eb626a"), Type = TextBlockType.Text, Text = $"You're knowledgeable in trades that are important to your people's survival and commercial interests. Pick two of the following Lore skills: Engineering Lore, Explosive Lore, or Firearm Lore. At 2nd level, you gain expert proficiency in these Lore skills; at 7th level, you gain master proficiency in these Lore skills; and at 15th level, you gain legendary proficiency in them." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bba60dde-123d-481a-a98e-dd858e52169e"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
