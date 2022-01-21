using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
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

        protected override IEnumerable<InlineAction> GetInlineActions()
        {
            yield return new InlineAction
            {
                Id = Guid.Parse("1c1fff48-5447-4d97-a81f-566281bc5543"),
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                Name = "Fight with Fear",
                Trigger = "A creature that you can see uses a mental effect against you.",
                Traits = new[]
                {
                    new InlineActionTraitBinding { Id = Guid.Parse("0d76c1ea-ff97-4369-8a39-c7d716f069d4"), TraitId = Traits.Instances.Concentrate.ID },
                    new InlineActionTraitBinding { Id = Guid.Parse("42f6b04c-c7f2-4f3d-b715-94a11268e178"), TraitId = Traits.Instances.Emotion.ID },
                    new InlineActionTraitBinding { Id = Guid.Parse("4348e28d-fd84-4463-ac18-5014682e5e5a"), TraitId = Traits.Instances.Enchantment.ID },
                    new InlineActionTraitBinding { Id = Guid.Parse("f2122cc7-2c9c-4c22-971d-58ab7e6c7732"), TraitId = Traits.Instances.Fear.ID },
                    new InlineActionTraitBinding { Id = Guid.Parse("a38d4405-21ba-4f5a-bc6d-ce0b6a02ab74"), TraitId = Traits.Instances.Mental.ID },
                },
                Effect = new[]
                {
                    new TextBlock { Id = Guid.Parse("7dc0be10-1011-431d-b68c-83dc563cdd9a"), Type = TextBlockType.Text, Text = "The triggering creature must attempt a Will save, which has the following effects." },
                },
                RollableEffect = new RollableEffect
                {
                    Id = Guid.Parse("88b843ac-7867-4b57-83de-02e2cfbe40b0"),
                    Success = "The creature is unaffected.",
                    Failure = "The creature is frightened 2, and you gain a +2 status bonus to your saving throw or other defense against the triggering mental effect.",
                    CriticalFailure = "The creature is frightened 2, and you're unaffected by the triggering mental effect."
                }
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

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("ec8ceb66-edc2-4661-a00f-2b4cf6b4902d"), Traits.Instances.Contingency.ID);
            builder.Add(Guid.Parse("d84ed4fb-c911-45b8-bf3d-e524558e7b7a"), Traits.Instances.Emotion.ID);
            builder.Add(Guid.Parse("7d0aaf4d-40fa-4817-990d-410b0204dac1"), Traits.Instances.Enchantment.ID);
            builder.Add(Guid.Parse("624252eb-4ce5-4fb1-8ee7-89af8687483b"), Traits.Instances.Fear.ID);
            builder.Add(Guid.Parse("82355482-75ce-498a-a620-0912ef365179"), Traits.Instances.Mental.ID);
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
