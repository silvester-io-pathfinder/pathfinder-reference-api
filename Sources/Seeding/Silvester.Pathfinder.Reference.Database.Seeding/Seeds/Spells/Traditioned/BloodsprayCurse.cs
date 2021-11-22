using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class BloodsprayCurse : Template
    {
        public static readonly Guid ID = Guid.Parse("6e6af5ca-6247-43be-8c86-95e3dbe1df95");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Bloodspray Curse",
                Level = 4,
                Range = "30 feet.",
                Duration = "Varies.",
                Targets = "1 creature.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("33039dfa-df1d-4096-902d-8e2ee27635b6"), Type = TextBlockType.Text, Text = "You inflict a curse upon the target that causes any wound to gush blood. The target must attempt a Fortitude save." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("c613de78-fbb8-4c71-85ad-4170453a85d5"),
                Level = "+2",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("833caf09-7048-4c7c-8662-f9c7d661ce07"), Type = TextBlockType.Text, Text = "The additional damage increases by 1d6 and the persistent bleed damage increases by 1d6." }
                }
            };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("8571e3b4-89df-4ec5-8094-d51bc5af6dc7"),
                CriticalSuccess = "The target is unaffected.",
                Success = "For 1 minute, the first time each round that the target takes at least 10 piercing or slashing damage from a single Strike, it takes 2d6 additional damage of the same type.",
                Failure = "As success, but when it takes the additional damage, it also takes 2d6 persistent bleed damage.",
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Occult.ID;
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Curse.ID;
            yield return Traits.Instances.Necromancy.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d28ec5be-303b-4f7e-a6c5-6fe87590b70b"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 92
            };
        }
    }
}
