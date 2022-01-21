using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class BloodVendetta : Template
    {
        public static readonly Guid ID = Guid.Parse("4857d481-64c1-48ab-a938-c879775e6904");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Blood Vendetta",
                Level = 2,
                Range = "30 feet.",
                Duration = "Varies.",
                Targets = "The triggering creature.",
                Trigger = "A creature deals piercing, slashing, or persistent bleed damage to you.",
                Requirements = "You can bleed.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9f40c16e-b4f5-4664-bd96-5d7ec3479bae"), Type = TextBlockType.Text, Text = "You curse the target, punishing it for having the audacity to spill your blood. The target takes 2d6 persistent bleed damage and must attempt a Will save." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("c123b77c-4b46-4a94-bee3-9b0c552d8411"), 
                Level = "+2",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("6472c6af-759e-4b26-84fb-aa4418ec2a19"), Type = TextBlockType.Text, Text = "The persistent bleed damage increases by 2d6." }
                }
            };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("63369615-2e19-41d2-9129-df4eb043120c"),
                CriticalSuccess = "The target is unaffected.",
                Success = "The target takes half the persistent bleed damage.",
                Failure = "The target takes the full persistent bleed damage. Until the bleeding stops, the target has weakness 1 to piercing and slashing damage.",
                CriticalFailure = "As failure, but the target takes double the persistent bleed damage."
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
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
            builder.Add(Guid.Parse("2ca2709f-7d18-48d4-9379-497187ff9e9f"), Traits.Instances.Curse.ID);
            builder.Add(Guid.Parse("066daf71-060a-4fcb-a88a-7f369f12d78c"), Traits.Instances.Necromancy.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e9a13606-6982-4445-b51b-18a851d744c9"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 216
            };
        }
    }
}
