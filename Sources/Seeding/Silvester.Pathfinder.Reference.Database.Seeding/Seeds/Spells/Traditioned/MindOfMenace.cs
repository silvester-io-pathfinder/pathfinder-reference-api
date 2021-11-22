using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class MindOfMenace : Template
    {
        public static readonly Guid ID = Guid.Parse("27b170f0-c95c-4957-a720-ee2c8d14e163");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Mind of Menace",
                Level = 3,
                Duration = "24 hours.",
                CastTime = "10 minutes.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a2605067-df2e-43c8-9f80-4edfc683cc2f"), Type = TextBlockType.Text, Text = "This spell wards against those who attempt to subvert your mind and turns mental magic back on them. When the spell is complete, you gain the Fight with Fear reaction; once you use the reaction, the spell ends." };
        }

        protected override IEnumerable<ActionEffect> GetActionEffects()
        {
            yield return new ActionEffect
            {
                Id = Guid.Parse("1c1fff48-5447-4d97-a81f-566281bc5543"),
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                Name = "Fight with Fear",
                Trigger = "A creature that you can see uses a mental effect against you.",
                Effects = new[]
                {
                    new TextBlock { Id = Guid.Parse("7dc0be10-1011-431d-b68c-83dc563cdd9a"), Type = TextBlockType.Text, Text = "The triggering creature must attempt a Will save, which has the following effects." },
                    new TextBlock { Id = Guid.Parse("a52cb9f0-61e0-4bf0-b654-19f01d3f093b"), Type = TextBlockType.Text, Text = "Success: The creature is unaffected." },
                    new TextBlock { Id = Guid.Parse("bcdad0da-2c65-47e9-ad56-effff3dd3b7b"), Type = TextBlockType.Text, Text = "Failure: The creature is frightened 2, and you gain a +2 status bonus to your saving throw or other defense against the triggering mental effect." },
                    new TextBlock { Id = Guid.Parse("183c6e7e-b363-4066-806c-3c756c107dd2"), Type = TextBlockType.Text, Text = "Critical Failure: The creature is frightened 2, and you�re unaffected by the triggering mental effect." }
                },
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
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Contingency.ID;
            yield return Traits.Instances.Emotion.ID;
            yield return Traits.Instances.Enchantment.ID;
            yield return Traits.Instances.Fear.ID;
            yield return Traits.Instances.Mental.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0303cb8e-e4f1-4d5b-a29a-b988da10ff6c"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 116
            };
        }
    }
}
