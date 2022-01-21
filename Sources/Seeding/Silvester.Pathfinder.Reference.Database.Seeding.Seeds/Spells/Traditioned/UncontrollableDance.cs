using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class UncontrollableDance : Template
    {
        public static readonly Guid ID = Guid.Parse("4ee5fbc3-1c55-45fb-be27-97de76109c27");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Uncontrollable Dance",
                Level = 8,
                Range = "Touch.",
                Duration = "Varies.",
                Targets = "1 creature.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7dce0a95-c087-454b-a52a-3d6ffba0fe0e"), Type = TextBlockType.Text, Text = "The target is overcome with an all-consuming urge to dance. For the duration of the spell, the target is flat-footed and can't use reactions. While affected, the creature can't use actions with the move trait except to dance, using the Stride action to move up to half its Speed." };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("0a3edc60-9bad-48fd-9541-0be947aec7d6"),
                CriticalSuccess = "The target is unaffected.",
                Success = "The spell's duration is 3 rounds, and the target must spend at least 1 action each turn dancing.",
                Failure = "The spell's duration is 1 minute, and the target must spend at least 2 actions each turn dancing.",
                CriticalFailure = "The spell's duration is 1 minute, and the target must spend all its actions each turn dancing."
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
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("7611ba3a-98f7-42e0-90ef-b783d5dfe142"), Traits.Instances.Enchantment.ID);
            builder.Add(Guid.Parse("deb61818-67b3-428e-b4fc-a0e57dd3f732"), Traits.Instances.Incapacitation.ID);
            builder.Add(Guid.Parse("f9676ade-3341-4e7d-9752-caf92749f343"), Traits.Instances.Mental.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c89cb6d7-7035-4fec-a01f-a728d3c3bea2"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 379
            };
        }
    }
}
