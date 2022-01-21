using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.WeaponPropertyRunes.Instances
{
    public class Disrupting : Template
    {
        public static readonly Guid ID = Guid.Parse("28896ad6-948f-4a6d-943d-40daa0d11b80");

        public static readonly Guid STANDARD_ID = Guid.Parse("aec8ff2c-14fc-4cc8-81af-3cd75de33eb4");
        public static readonly Guid GREATER_ID = Guid.Parse("76aadc75-c6fe-4a63-9fce-78bc73f54dd2");

        protected override WeaponPropertyRune GetWeaponPropertyRune()
        {
            return new WeaponPropertyRune
            {
                Id = ID,
                Name = "Disrupting",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("a85cc247-1c72-4c15-9e45-a5216ca4c938"), "A disrupting weapon pulses with positive energy.The weapon deals an extra 1d6 positive damage to undead. On a critical hit, the undead is also enfeebled 1 until the end of your next turn.");
        }

        protected override IEnumerable<WeaponPropertyRuneVariant> GetWeaponPropertyRuneVariants()
        {
            yield return new WeaponPropertyRuneVariant
            {
                Id = Guid.Parse("6c4f2367-3da3-4fdd-a414-8b306a0b2fbd"),
                Name = "Disrupting",
                Usage = "Etched onto a melee weapon.",
                Level = 5,
                Price = 15000,
                PotencyId = Potencies.Instances.Standard.ID,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
            
           yield return new WeaponPropertyRuneVariant
            {
                Id = Guid.Parse("ad037171-6710-4f3c-a2d3-5bb8bed2abd4"),
                Name = "Disrupting (Greater)",
                Usage = "Etched onto a melee weapon.",
                Level = 14,
                Price = 430000,
                PotencyId = Potencies.Instances.Greater.ID,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("d153920f-4c9c-4a88-a3a8-6a1a3c54ecf4"), "Increase the extra damage to 2d6. On a critical hit, instead of being enfeebled 1, the undead creature must attempt a DC 34 Fortitude save with the following effects. This is an incapacitation effect.")
                    .Build(),
                RollableEffect = new RollableEffect
                {
                    Id = Guid.Parse("ad329a6e-7b83-49d8-8df6-2f29902844aa"),
                    CriticalSuccess = "It's enfeebled 1 until the end of your next turn.",
                    Success = "It's enfeebled 2 until the end of your next turn.",
                    Failure = "It's enfeebled 3 until the end of your next turn.",
                    CriticalFailure = "It's destroyed."
                }
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("c70b4ff8-4a0a-4b56-9673-190814972c8a"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("feaa19ac-473c-48b9-b7ce-71d145c3089e"), Traits.Instances.Necromancy.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f46eeebe-1fa9-444b-8878-db7ed8c47bde"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 584
            };
        }
    }
}
