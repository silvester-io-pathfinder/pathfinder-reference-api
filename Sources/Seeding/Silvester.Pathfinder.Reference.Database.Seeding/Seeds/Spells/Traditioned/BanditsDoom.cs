using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class BanditsDoom : Template
    {
        public static readonly Guid ID = Guid.Parse("2c4f6eee-df2e-471a-9346-d564e2514d19");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Bandit's Doom",
                Level = 5,
                Duration = "1 month.",
                Targets = "1 item of 2 Bulk or less.",
                CastTime = "30 minutes.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                MagicSchoolId = MagicSchools.Instances.Abjuration.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2b1470c6-e810-4092-bafd-485b64c3cb8d"), Type = TextBlockType.Text, Text = "You ward the target item against those who would steal it. When a creature attempts to take the target into its possession, it takes 8d8 mental damage and is doomed, depending on the result of its Will save. The spell then ends. You can choose up to 10 creatures when you cast this spell; if you do, those creatures can take the target item without triggering the ward. You can only have one bandit�s doom active at a time. If you cast the spell again, the newer casting supersedes the older." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("ddce139c-3621-4fcd-8196-55217c320e7f"),
                Level = "+2",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("8b2b64a0-f98c-4ba8-a5e2-d5bd868a604e"), Type = TextBlockType.Text, Text = "The damage increases by 2d8." }
                }
            };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("de83b2f1-8a78-48bf-b44c-76b7ae77484e"),
                CriticalSuccess = "The creature is unaffected.",
                Success = "The creature takes half damage and is doomed 1.",
                Failure = "The creature takes full damage and is doomed 2.",
                CriticalFailure = "The creature takes double damage and is doomed 3."
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Material.ID;
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Arcane.ID;
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Abjuration.ID;
            yield return Traits.Instances.Curse.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d7bb08e6-c3d8-43af-9679-befa3007294e"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 90
            };
        }
    }
}
