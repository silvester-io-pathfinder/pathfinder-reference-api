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
    public class ElementalLore : Template
    {
        public static readonly Guid ID = Guid.Parse("054ddbde-cdf4-4d0d-a908-587be3483188");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Elemental Lore",
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
            yield return new TextBlock { Id = Guid.Parse("b71d200c-3d57-42e3-90a5-d5a884ccb7dc"), Type = TextBlockType.Text, Text = $"You've devoted yourself to researching the secrets of the Inner Sphere. You gain the trained proficiency in your choice of Survival and either Arcana or Nature. If you would automatically become trained in Survival (from your background or class, for example), you instead become trained in a skill of your choice. You also become trained in the Lore associated with your Elemental Plane of origin (such as Plane of Fire Lore)." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("39adc0f0-a857-4a7a-acb8-20489540cd53"), Traits.Instances.Ifrit.ID);
            builder.Add(Guid.Parse("6dc89fae-0ad8-45e0-a692-549859fdccae"), Traits.Instances.Oread.ID);
            builder.Add(Guid.Parse("af8ebcc1-096f-4bf7-9b9c-450967719428"), Traits.Instances.Suli.ID);
            builder.Add(Guid.Parse("ce0f6f7c-c7e3-48b8-89b1-9ef39ca80d7e"), Traits.Instances.Sylph.ID);
            builder.Add(Guid.Parse("6cbb3c77-c3c5-4996-9676-4febd5683e6f"), Traits.Instances.Undine.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("04bcd690-699d-44a1-907c-ec904a040e6d"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
