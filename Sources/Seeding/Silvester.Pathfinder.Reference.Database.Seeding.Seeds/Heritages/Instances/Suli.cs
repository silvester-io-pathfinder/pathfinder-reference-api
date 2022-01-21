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
    public class Suli : Template
    {
        public static readonly Guid ID = Guid.Parse("9a037584-e986-4112-b24b-272e11317e1c");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Uncommon.ID, 
                Name = "Suli"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("79f3506f-3ffa-448f-b816-42cb70bb7968"), Type = TextBlockType.Text, Text = "You are descended from a janni or otherwise embody a dichotomy of opposing elemental planar forces. You gain the suli trait, in addition to the traits from your ancestry. You also gain low-light vision, or you gain darkvision if your ancestry already has low-light vision. You can choose from suli feats and feats from your ancestry whenever you gain an ancestry feat." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificTrait(Guid.Parse("e85f8a98-c677-4f2d-885d-68a6788a057b"), Traits.Instances.Suli.ID);
            builder.AddOr(Guid.Parse("fcca97c7-057a-481a-8ba2-8b78a4bed90f"), or =>
            {
                builder.GainSpecificSense(Guid.Parse("26ee5301-8c9a-4de8-a22a-bcc0b00b80e6"), Senses.Instances.LowLightVision.ID, SenseAccuracies.Instances.Precise.ID);
                builder.GainSpecificSense(Guid.Parse("e08d7231-ce16-4572-86dd-0720f3687c10"), Senses.Instances.Darkvision.ID, SenseAccuracies.Instances.Precise.ID)
                    .AddPrerequisites(Guid.Parse("1e15b403-0b60-44fe-9cb2-62ef946de0d3"), prerequisites =>
                    {
                        prerequisites.HaveSpecificSense(Guid.Parse("22276109-67c2-4345-9179-972186e406c1"), Senses.Instances.LowLightVision.ID);
                    });
            });
            builder.UnlockSpecificTraitAncestryFeats(Guid.Parse("c0be13d8-092b-407c-8855-e95f3f3d5668"), Traits.Instances.Suli.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("abc1b24e-58dc-45f8-aedf-8867984580dc"),
                SourceId = Sources.Instances.AncestryGuide.ID,
                Page = 110
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
