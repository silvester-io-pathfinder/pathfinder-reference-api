using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class RejuvenatingFlames : Template
    {
        public static readonly Guid ID = Guid.Parse("40e2db98-951b-4a99-8c4c-c2fa9e203037");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Rejuvenating Flames",
                Level = 1,
                Area = "15-foot cone.",
                IsSavingThrowBasic = true,
                SavingThrowStatId = SavingThrowStats.Instances.Reflex.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                ClassId = Classes.Instances.Sorcerer.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8950b078-15dc-4dbd-99ac-22697e16171a"), Type = TextBlockType.Text, Text = "You create a gout of flame that both heals and burns. You restore 1d4 HP to all allies in the area, and those allies gain a +1 status bonus to Fortitude saves for 1 minute. Enemies in the area take 1d4 fire damage with a basic Reflex save." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("59c85aa5-07b6-4cf2-801e-7e9036d8cec1"),
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("2a460e00-1233-4ae2-bc51-63b92edfe6d7"), Type = TextBlockType.Text, Text = "You restore an additional 1d4 HP to your allies and deal an additional 1d4 fire damage to enemies." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("4350a5b7-40e4-4e30-a337-be117aa5fec4"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("43c38c96-fad0-4723-8f2e-c036e71bedaf"), Traits.Instances.Fire.ID);
            builder.Add(Guid.Parse("4fc673d6-8da9-4325-80da-2666b3fa5428"), Traits.Instances.Healing.ID);
            builder.Add(Guid.Parse("f422d22e-b97a-46e2-b99b-e1a3d64a6056"), Traits.Instances.Necromancy.ID);
            builder.Add(Guid.Parse("afc17077-ce9c-4aab-919a-2c8e198112f2"), Traits.Instances.Sorcerer.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fd72588b-3892-4276-a715-34a67297950d"),
                SourceId = Sources.Instances.Pathfinder168.ID,
                Page = 74
            };
        }
    }
}
