using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Ancestries.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Heritages.Instances
{
    public class Oread : Template
    {
        public static readonly Guid ID = Guid.Parse("f3fec89d-6705-4e00-a844-9b42d97f0625");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Uncommon.ID, 
                Name = "Oread"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("3c7b2818-16b1-46ca-9a7b-e8dca3f13b07"), Type = TextBlockType.Text, Text = "An earth elemental ancestor has influenced your bloodline, and your features highlight this elemental planar connection. You might have a crystalline or metallic sheen to your skin or hair, rough and stony flesh, or glittering gemstone eyes. You gain the oread trait, in addition to the traits from your ancestry. You also gain low-light vision, or you gain darkvision if your ancestry already has low-light vision. You can choose from oread feats and feats from your ancestry whenever you gain an ancestry feat." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificTrait(Guid.Parse("8e4a428b-e5ca-4736-8f97-3b7bf77001e3"), Traits.Instances.Oread.ID);
            builder.AddOr(Guid.Parse("1020428c-3a9c-4409-98cf-3db5af1c1186"), or =>
            {
                builder.GainSpecificSense(Guid.Parse("632848a8-c271-42f7-b8ed-7a5cc5444328"), Senses.Instances.LowLightVision.ID, SenseAccuracies.Instances.Precise.ID);
                builder.GainSpecificSense(Guid.Parse("be02e86d-8258-4f0a-86e7-90cab3b647a4"), Senses.Instances.Darkvision.ID, SenseAccuracies.Instances.Precise.ID)
                    .AddPrerequisites(Guid.Parse("f21d62c1-71fc-4353-8fff-caf8726930af"), prerequisites =>
                    {
                        prerequisites.HaveSpecificSense(Guid.Parse("cf44e354-0222-47f5-91dd-160a89f58b06"), Senses.Instances.LowLightVision.ID);
                    });
            });
            builder.UnlockSpecificTraitAncestryFeats(Guid.Parse("a0390658-dcd1-444a-9d0f-7c276aa563c5"), Traits.Instances.Oread.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("84ff6f6b-8659-4aa8-b57f-95243a35e1ea"),
                SourceId = Sources.Instances.AncestryGuide.ID,
                Page = 105
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Catfolk.ID;
            yield return Gnome.ID;
            yield return Goblin.ID;
            yield return Human.ID;
            yield return Tengu.ID;
            yield return Orc.ID;
            yield return Dwarf.ID;
            yield return Kobold.ID;
            yield return Ratfolk.ID;
            yield return Elf.ID;
            yield return Halfling.ID;
        }
    }
}
