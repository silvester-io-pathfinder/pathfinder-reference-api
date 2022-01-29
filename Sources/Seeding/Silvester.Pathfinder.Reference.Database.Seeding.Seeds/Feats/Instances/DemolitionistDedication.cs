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
    public class DemolitionistDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("e06d5adb-3ffa-452b-a31a-faad229162df");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Demolitionist Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7deb2c64-b214-45a0-92cf-6770ac79fd3e"), Type = TextBlockType.Text, Text = $"You know how to set explosives to cause the maximum possible damage to buildings and other structures. You become trained in Engineering Lore or become an expert in it if you were already trained. You gain the {ToMarkdownLink<Models.Entities.Feat>("Set Explosives", Feats.Instances.SetExplosives.ID)} action." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Archetype.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Dedication.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e64ade35-d443-4616-8476-6f5888d57c21"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
