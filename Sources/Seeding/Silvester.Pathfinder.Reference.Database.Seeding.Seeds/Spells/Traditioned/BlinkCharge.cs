using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class BlinkCharge : Template
    {
        public static readonly Guid ID = Guid.Parse("dfa3df55-6088-4981-9dbf-f24d323ff86d");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Blink Charge",
                Level = 5,
                Range = "60 feet.",
                Targets = "1 creature.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Conjuration.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ab3a1740-054e-4f64-8269-f5e9a88b33d6"), Type = TextBlockType.Text, Text = "You propel yourself through the fabric of space to deal a blow carrying the momentum of your teleportation. You teleport to an empty space adjacent to a creature you can see within range, then make a Strike against the creature with a weapon you�re wielding. The Strike deals damage, plus an extra 2d8 force damage, depending on the result of your Strike." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("7f7aa036-ef32-4bc3-ba79-b5992de5164e"),
                Level = "+2",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("142d9504-2896-4d78-9fc9-43c5ed000ff4"), Type = TextBlockType.Text, Text = "The spell�s range increases by 60 feet, and any force damage the spell deals is increased by 1d8." }
                }
            };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("039acbc0-7c11-453c-92fe-86bb05e566a1"),
                CriticalSuccess = "Double damage, plus after the Strike, you can teleport the target into an empty space up to 5 feet away from its current position. The new space must be on the ground if it started on the ground, in the air if it was flying, and so on.",
                Success = "The Strike deals full damage.",
                Failure = "The Strike deals no damage, but the target takes 1d8 force damage.",
                CriticalFailure = "The Strike deals no damage, and you take 1d8 force damage."
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Arcane.ID;
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("0189b179-3563-4d77-9614-51cdb69cf6b2"), Traits.Instances.Conjuration.ID);
            builder.Add(Guid.Parse("3f9c61c3-142e-49de-a19f-84a3f0bdd1f2"), Traits.Instances.Force.ID);
            builder.Add(Guid.Parse("17802116-abfb-4205-b530-51faac952b1b"), Traits.Instances.Teleportation.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4432f48a-af13-4996-999a-80cf79925f1b"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 92
            };
        }
    }
}
