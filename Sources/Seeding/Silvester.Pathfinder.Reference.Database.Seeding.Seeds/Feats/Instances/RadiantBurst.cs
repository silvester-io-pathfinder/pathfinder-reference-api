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
    public class RadiantBurst : Template
    {
        public static readonly Guid ID = Guid.Parse("2a157489-e8a3-4aca-8517-94879a390447");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Radiant Burst",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6d9a3074-9a88-4cd8-80dd-7b93f3c07f82"), Type = TextBlockType.Text, Text = $"Your skin glows with intensity. Creatures within 10 feet who can see you must succeed at a Fortitude save against your class DC or spell DC, whichever is higher." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("fd9e2298-f309-4806-a19d-5a8abc9b8502"), Traits.Instances.Fire.ID);
            builder.Add(Guid.Parse("559b78b4-f073-4885-af70-3e46fe3d3710"), Traits.Instances.Ifrit.ID);
            builder.Add(Guid.Parse("18629caa-6b39-498b-b9d0-1b158aa2204c"), Traits.Instances.Incapacitation.ID);
            builder.Add(Guid.Parse("483571c3-2c4d-497e-9bfa-d0e4e5556925"), Traits.Instances.Light.ID);
            builder.Add(Guid.Parse("ded79bf7-d37f-46a0-87cf-e741921e70cf"), Traits.Instances.Visual.ID);

        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("b70a3cb0-3884-4aa6-ada8-3f80973e5722"),
                CriticalSuccess = "The creature is unaffected.",
                Success = "The creature is dazzled for 1 round.",
                Failure = "The creature is blinded for 1 round and dazzled for 4 rounds.",
                CriticalFailure = "The creature is blinded for 4 rounds and dazzled for 10 minutes.", 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("08bd5788-ff18-4afe-b9b8-bfa2f3dd96d1"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
