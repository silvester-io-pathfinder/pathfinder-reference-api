using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class MagneticAttraction : Template
    {
        public static readonly Guid ID = Guid.Parse("43651d54-b90b-42a0-a864-c6fa95f92b54");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "MagneticMagneticAttractionAttraction",
                Level = 2,
                Range = "60 feet.",
                Targets = "Up to 10 metal objects with a total Bulk of 1 or less.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d040e138-4410-481d-978a-6b0aee2aff84"), Type = TextBlockType.Text, Text = "You adjust your magnetic polarity, plucking daggers from hands and coins from belts. The targeted objects fly to your location, letting you catch them easily in your hands, or dropping to the ground at your position, at your discretion. Unattended objects fly to you automatically. If you target secured objects or those in another creature�s possession (such as sheathed weapons), you must attempt to Disarm the creature of the metal objects, making a spell attack roll instead of an Athletics check to do so." };
            yield return new TextBlock { Id = Guid.Parse("2a01657f-5013-48eb-8805-3a2631a43644"), Type = TextBlockType.Text, Text = "Instead of drawing the objects to yourself, you can polarize a single metal object within range, designating it as a lodestone and causing the metal objects to fly to it instead. The lodestone must be at least three times the total Bulk of the targeted metal objects. Objects will stick to the lodestone for 1 minute, though they can be wrenched away with an Interact action." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Arcane.ID;
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("0a349f5b-a983-4112-8cf8-bbcb80115182"), Traits.Instances.Evocation.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fdc1a74e-6831-4120-8a0c-646be8a2039d"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 114
            };
        }
    }
}
