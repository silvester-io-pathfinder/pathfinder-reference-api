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
    public class AquaticAdaptation : Template
    {
        public static readonly Guid ID = Guid.Parse("0e0530d9-cf6d-4e0a-bf77-338da500cf9f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Aquatic Adaptation",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("58d8e29d-9513-4998-9282-99829f882ee5"), Type = TextBlockType.Text, Text = $"If you and up to four other creatures are in contact with a body of water deep enough for you to fully submerge, you can spend 10 minutes adapting the creatures to that specific body of water. This allows them to breathe normally while within that body of water and protects them from deep ocean pressure. These effects last until the creatures are no longer in contact with that body of water or until you use this ability again, whichever comes first for each creature." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("17da866c-12e5-4ab0-897e-d93780467ec9"), Traits.Instances.Azarketi.ID);
            builder.Add(Guid.Parse("01090345-ecb2-4560-b966-bd41d37978fa"), Traits.Instances.Concentrate.ID);
            builder.Add(Guid.Parse("34f22336-4866-4472-8648-0013b22457d3"), Traits.Instances.Primal.ID);
            builder.Add(Guid.Parse("970ecd14-ad84-4533-8582-2b49b94a2d73"), Traits.Instances.Transmutation.ID);
            builder.Add(Guid.Parse("6b482c32-dc5b-4727-ac76-ea74e3a74e6a"), Traits.Instances.Water.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e98c3c11-eb27-469a-a3bb-1fc0b33e6048"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
