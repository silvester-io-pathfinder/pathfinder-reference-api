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
    public class Sylph : Template
    {
        public static readonly Guid ID = Guid.Parse("4577dc53-0e2d-45ae-9642-af121af88dd8");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Uncommon.ID, 
                Name = "Sylph"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("2d7cda6d-816b-4b3a-9cc4-4e34c5eb9af4"), Type = TextBlockType.Text, Text = "You are descended from air elementals or were born under the element's influence. You gain the sylph trait, in addition to the traits from your ancestry. You also gain low-light vision or darkvision if your ancestry already has low-light vision. You can choose from sylph feats and feats from your ancestry whenever you gain an ancestry feat." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificTrait(Guid.Parse("c745b2ad-ba4e-40c7-aa44-2431de8fb318"), Traits.Instances.Sylph.ID);
            builder.AddOr(Guid.Parse("9c402430-3586-42bb-b223-c900b2ca84b2"), or =>
            {
                builder.GainSpecificSense(Guid.Parse("730ea672-11a3-43f5-b5fa-9e7388c272c8"), Senses.Instances.LowLightVision.ID, SenseAccuracies.Instances.Precise.ID);
                builder.GainSpecificSense(Guid.Parse("44137376-f050-40f0-a29d-330544170598"), Senses.Instances.Darkvision.ID, SenseAccuracies.Instances.Precise.ID)
                    .AddPrerequisites(Guid.Parse("d544a033-7c5c-4e6d-8bd6-e7007ec02aa4"), prerequisites =>
                    {
                        prerequisites.HaveSpecificSense(Guid.Parse("1e4df229-249a-48de-8905-4e283aae5001"), Senses.Instances.LowLightVision.ID);
                    });
            });
            builder.UnlockSpecificTraitAncestryFeats(Guid.Parse("f009909e-b32a-4d27-be0b-78d52ca8d81a"), Traits.Instances.Sylph.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("68de6e5a-c608-4497-9536-9c5d922170c5"),
                SourceId = Sources.Instances.AncestryGuide.ID,
                Page = 114
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
