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
    public class SummonersCall : Template
    {
        public static readonly Guid ID = Guid.Parse("ead9bec5-ae38-4ea0-a8b2-0846c186eeaf");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Summoner's Call",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "This feat has the trait matching your eidolon's tradition ((trait: arcane), (trait: divine), (trait: occult), or (trait: primal)).",
                Trigger = "You or your eidolon take damage from a foe or hazard.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("bbebcb38-f9ee-4841-a4e2-b513aa20088e"), Type = TextBlockType.Text, Text = $"In a moment of danger, you call your eidolon to your side. Your eidolon teleports to an open space adjacent to you." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("5e8c16e5-830a-4706-baad-82a1169c41ac"), Traits.Instances.Concentrate.ID);
            builder.Add(Guid.Parse("799ecc9a-4583-4da1-8101-6f077f1d2640"), Traits.Instances.Conjuration.ID);
            builder.Add(Guid.Parse("8545391e-1795-41c7-818d-f2d6a5a6f99f"), Traits.Instances.Summoner.ID);
            builder.Add(Guid.Parse("46ffb1c0-5811-40bc-9341-272e5069f0eb"), Traits.Instances.Teleportation.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0923fffa-b2d5-46be-a963-b49bcd5182f5"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
