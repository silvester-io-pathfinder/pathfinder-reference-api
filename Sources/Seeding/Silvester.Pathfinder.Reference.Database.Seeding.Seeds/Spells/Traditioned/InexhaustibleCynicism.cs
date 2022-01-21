using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class InexhaustibleCynicism : Template
    {
        public static readonly Guid ID = Guid.Parse("c26b545d-22a5-41cd-b263-75078cc28a5d");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Inexhaustible Cynicism",
                Level = 7,
                Range = "30 feet.",
                Targets = "Up to 5 creatures.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("603c4b1c-cf24-471b-b71c-88d2c8e3f897"), Type = TextBlockType.Text, Text = "You inflict your targets with a crushing doubt about everyone and everything around them. For the duration, each target is unwilling to receive any effects that require a willing target (in case the effect was secretly an attack), refuse to ingest anything (in case the substances have been replaced with poisons and cursed duplicates), doesn�t treat anyone as an ally (in case its friends were replaced by an impostor), and doesn�t believe anything it�s told (in case of lies, though this doesn�t mean the creature automatically believes the opposite either). It doesn�t even fully trust its own ability to Recall Knowledge, as it becomes convinced it most likely remembered false information, as from a critical failure on a check to Recall Knowledge." };
            yield return new TextBlock { Id = Guid.Parse("a6c9b890-c882-416a-b153-4d6f166163fd"), Type = TextBlockType.Text, Text = "Finally, the creature takes 6d6 mental damage at the end of each of its turns (with no save) unless it spent at least 1 action that turn Seeking or otherwise interacting with its surroundings in an attempt to disbelieve the illusions that it feels are obviously surrounding it." };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("1bd50042-7a28-4c88-ab89-bd3099a293c9"),
                CriticalSuccess = "The creature is unaffected.",
                Success = "The creature is affected for 1 round.",
                Failure = "The creature is affected for 1 minute.",
                CriticalFailure = "The creature is affected for 1 hour."
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
            builder.Add(Guid.Parse("e86c2781-f23d-4ff4-b70d-b5755fba10be"), Traits.Instances.Emotion.ID);
            builder.Add(Guid.Parse("70ab9c9c-e268-46b6-b481-1b1f1298712c"), Traits.Instances.Enchantment.ID);
            builder.Add(Guid.Parse("6fc47143-b18d-48a4-b8e7-fe94af9d2044"), Traits.Instances.Mental.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("62926642-70c9-45ff-8043-40304fa0dc70"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 111
            };
        }
    }
}
