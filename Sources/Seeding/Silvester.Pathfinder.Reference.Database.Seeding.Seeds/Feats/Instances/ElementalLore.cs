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
            builder.Add(Guid.Parse(""), Traits.Instances.Ifrit.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Oread.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Suli.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Sylph.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Undine.ID);

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
