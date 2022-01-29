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
    public class Transpose : Template
    {
        public static readonly Guid ID = Guid.Parse("ec648e82-2fd4-4050-8457-a8344a4ef50a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Transpose",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "This feat has the trait matching your eidolon's tradition ((trait: arcane), (trait: divine), (trait: occult), or (trait: primal)).",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("388caf62-1402-4fcc-8d7a-fb9b52cacb41"), Type = TextBlockType.Text, Text = $"You switch places with your eidolon. You each teleport to the other's position." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("26a412cc-cd78-4dfc-abe2-612a8aa9681b"), Traits.Instances.Concentrate.ID);
            builder.Add(Guid.Parse("eace8f2c-e1cd-41c2-bdf7-d0fdde2ffe7b"), Traits.Instances.Conjuration.ID);
            builder.Add(Guid.Parse("9d38391e-1b18-43a9-bfc9-a5741a56a885"), Traits.Instances.Manipulate.ID);
            builder.Add(Guid.Parse("f3481a4a-f5e8-4387-9b72-f498b1d6bcd6"), Traits.Instances.Summoner.ID);
            builder.Add(Guid.Parse("5f327a9a-1f73-44c2-a833-58b3e9c423fb"), Traits.Instances.Teleportation.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b3d94f80-8072-4b50-8643-7eb073e159ce"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
