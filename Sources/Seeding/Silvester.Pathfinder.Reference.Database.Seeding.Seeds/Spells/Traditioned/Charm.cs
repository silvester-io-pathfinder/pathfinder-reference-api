using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class Charm : Template
    {
        public static readonly Guid ID = Guid.Parse("41b3515e-c59f-4ac6-92a2-ef16195cd647");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Charm",
                Level = 1,
                Range = "30 feet.",
                Targets = "1 creature.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b0627230-1b6f-41fa-b385-e9315448ce04"), Type = Utilities.Text.TextBlockType.Text, Text = "To the target, your words are honey and your visage seems bathed in a dreamy haze. It must attempt a Will save, with a +4 circumstance bonus if you or your allies recently threatened it or used hostile actions against it." };
            yield return new TextBlock { Id = Guid.Parse("1d038912-70a4-45ee-aa4b-c9b2cae4f931"), Type = Utilities.Text.TextBlockType.Text, Text = "You can Dismiss the spell. If you use hostile actions against the target, the spell ends. When the spell ends, the target doesn't necessarily realize it was charmed unless its friendship with you or the actions you convinced it to take clash with its expectations, meaning you could potentially convince the target to continue being your friend via mundane means." };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect 
            {
                Id = Guid.Parse("ace65902-0a3b-4cec-acb6-6f8282687977"),
                CriticalSuccess = "The target is unaffected and aware you tried to charm it.",
                Success = "The target is unaffected but thinks your spell was something harmless instead of charm, unless it identifies the spell (see Identifying Spells on page 305).",
                Failure = "The target's attitude becomes friendly toward you. If it was friendly, it becomes helpful. It can't use hostile actions against you.",
                CriticalFailure = "The target's attitude becomes helpful toward you, and it can't use hostile actions against you."
            };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            { 
                Id = Guid.Parse("8fad2d3e-740c-4f51-bb8d-8abe84a24783"),
                Level = "4th", 
                Details =
                {
                    new TextBlock { Id = Guid.Parse("02e87545-e884-4321-8b76-fc41fbb44bd2"), Type = Utilities.Text.TextBlockType.Text, Text = "The duration lasts until the next time you make your daily preparations." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("99a5bbf6-51c5-4e42-ba6b-e1155c40d500"),
                Level = "8th", 
                Details =
                {
                    new TextBlock { Id = Guid.Parse("470cd40d-caa3-4188-8862-a59f41eff543"), Type = Utilities.Text.TextBlockType.Text, Text = "The duration lasts until the next time you make your daily preparations, and you can target up to 10 creatures." }
                }
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
            yield return MagicTraditions.Instances.Occult.ID;
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("e303ec88-ecd2-4959-b22e-74a1db79df59"), Traits.Instances.Emotion.ID);
            builder.Add(Guid.Parse("357b7c3d-6536-4d3b-8e38-7bc2460788ac"), Traits.Instances.Enchantment.ID);
            builder.Add(Guid.Parse("b32b8764-d6a3-44c0-b04b-b81211088a5b"), Traits.Instances.Incapacitation.ID);
            builder.Add(Guid.Parse("056f6074-8b57-4246-83db-2bde010c8c2b"), Traits.Instances.Mental.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("79a820ba-59c1-4faa-a60b-8a872fd374d7"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 322
            };
        }
    }
}
