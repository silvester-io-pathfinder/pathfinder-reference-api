using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class AgonizingDespair : Template
    {
        public static readonly Guid ID = Guid.Parse("28398964-187e-44ff-89e7-8d58042832c7");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Agonizing Despair",
                Level = 3,
                Range = "60 feet.",
                Targets = "1 creature",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3c6182fb-7575-4228-9ea3-e320836380f4"), Type = TextBlockType.Text, Text = "Your target’s mind tumbles down a deep well of dread, dwelling so intently on deep-seated fears that it’s painful. The target takes 4d6 mental damage with a Will saving throw." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("61539ddc-49b2-4fa4-a3b2-fb110f14983f"), 
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("6d6b8bb7-96f9-40c5-a06e-3ce7d351f6f2"), Type = TextBlockType.Text, Text = "Increase the damage by 2d6." }
                }
            };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("6b99906a-3610-4acc-8352-a9220d0ca336"),
                CriticalSuccess = "The target is unaffected.",
                Success = "The target takes half damage and becomes frightened 1.",
                Failure = "The target takes full damage and becomes frightened 2.",
                CriticalFailure = "The target takes double damage and becomes frightened 3."
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

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Emotion.ID;
            yield return Traits.Instances.Enchantment.ID;
            yield return Traits.Instances.Fear.ID;
            yield return Traits.Instances.Mental.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b26f5368-2e19-407a-8dcc-3d6b5e1e3dab"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 214
            };
        }
    }
}
