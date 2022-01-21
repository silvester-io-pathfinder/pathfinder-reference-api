using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Ancestries.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Heritages.Instances
{
    public class Aasimar : Template
    {
        public static readonly Guid ID = Guid.Parse("552b3bc3-c40c-42b6-a13b-436ba14e7c1e");

        protected override Heritage GetHeritage()
        {
           return new Heritage 
           {
               Id = ID, 
               RarityId = Rarities.Instances.Uncommon.ID, 
               Name = "Aasimar"
           };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("ee8afd02-f985-4965-b9b2-6eb566c7d608"), Type = TextBlockType.Text, Text = "You descend from celestials or were touched by the celestial realms, gaining an air of awe and grace, as well as features distinctive to your celestial forebears. You gain the aasimar trait, in addition to the traits from your ancestry. You also gain low-light vision, or you gain darkvision if your ancestry already has low-light vision. You can choose from aasimar feats and feats from your ancestry whenever you gain an ancestry feat." };    
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificTrait(Guid.Parse("096c1321-0c89-4911-9b29-77c12f216908"), Traits.Instances.Aasimar.ID);
            builder.AddOr(Guid.Parse("90ae4b29-de5c-4751-acf8-b1274eaa539d"), or =>
            {
                builder.GainSpecificSense(Guid.Parse("a14b155c-d18f-47da-8103-674fbc65419b"), Senses.Instances.LowLightVision.ID, SenseAccuracies.Instances.Precise.ID);
                builder.GainSpecificSense(Guid.Parse("b9d898c4-8ab2-473b-a944-2ba28510fde7"), Senses.Instances.Darkvision.ID, SenseAccuracies.Instances.Precise.ID)
                    .AddPrerequisites(Guid.Parse("6e4e1b62-e88c-496a-95ad-7b25e591a498"), prerequisites => 
                    {
                        prerequisites.HaveSpecificSense(Guid.Parse("ee8c0141-6c28-400d-8ba2-6afff6244d8e"), Senses.Instances.LowLightVision.ID);
                    });
            });
            builder.UnlockSpecificTraitAncestryFeats(Guid.Parse("2a48b277-4d0a-459e-b941-ff0d24f04989"), Traits.Instances.Aasimar.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a3889398-d7e9-4a99-bf0c-7c0b5fc8dfee"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 34
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
