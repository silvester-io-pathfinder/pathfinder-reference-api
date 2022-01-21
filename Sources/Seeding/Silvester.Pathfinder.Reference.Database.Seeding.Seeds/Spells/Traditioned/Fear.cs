using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class Fear : Template
    {
        public static readonly Guid ID = Guid.Parse("eee187bd-5654-4215-b042-56e537a49410");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Fear",
                Level = 1,
                Range = "30 feet.",
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
            yield return new TextBlock { Id = Guid.Parse("31029dc9-cb07-4824-acf9-861da965e686"), Type = TextBlockType.Text, Text = "You plant fear in the target; it must attempt a Will save." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("ab0fa2d7-a13a-42ff-b1e2-ea4448e5b713"), 
                Level = "3rd",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("44d15387-bd49-4fbb-8b5e-1b93a8223ec6"), Type = TextBlockType.Text, Text = "You can target up to five creatures." }
                }
            };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("197e6d0c-3dfe-49bb-8dd2-a570a3bf405b"),
                CriticalSuccess = "The target is unaffected.",
                Success = "The target is frightened 1.",
                Failure = "The target is frightened 2.",
                CriticalFailure = "The target is frightened 3 and fleeing for 1 round."
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
            yield return MagicTraditions.Instances.Primal.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("1df53e4c-de85-4734-9149-fe5af411486f"), Traits.Instances.Emotion.ID);
            builder.Add(Guid.Parse("9a8b47d1-59b8-4bc2-9854-220f88940d2b"), Traits.Instances.Enchantment.ID);
            builder.Add(Guid.Parse("b6f3dfac-52a2-4905-b0ad-3d77248ee7a5"), Traits.Instances.Fear.ID);
            builder.Add(Guid.Parse("eebe7b52-2248-4de5-900b-720c896a2993"), Traits.Instances.Mental.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("75551e45-fad3-43fd-b8f2-c913a75c163e"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 337
            };
        }
    }
}