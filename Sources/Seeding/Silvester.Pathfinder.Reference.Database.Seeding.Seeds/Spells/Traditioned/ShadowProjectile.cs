using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class ShadowProjectile : Template
    {
        public static readonly Guid ID = Guid.Parse("9a47f04c-8a9b-4a5b-847b-68256d87e3f9");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Shadow Projectile",
                Level = 3,
                Trigger = "An ally within 20 feet of you makes a ranged attack roll.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                MagicSchoolId = MagicSchools.Instances.Illusion.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6a391df8-24ab-46a0-a1a2-53d38ad30b16"), Type = TextBlockType.Text, Text = "You create an illusory duplicate of your ally's ranged attack to confuse your opponents. You launch an illusory double of your ally's projectile or spell at the same target, leaving the enemy unsure which attack to avoid. The target takes 3d8 mental damage, depending on its Will save. Regardless of the result of its save, it's temporarily immune to shadow projectile spells for 1 hour." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("23c51c88-0c8b-4f6f-bf39-47b721f53bc1"),
                Level = "+2",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("b070ab24-6e96-4950-baff-9391fb902c3d"), Type = TextBlockType.Text, Text = "The damage increases by 1d8." }
                }
            };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("ae098eae-8645-4b91-b9fc-798206a99411"),
                CriticalSuccess = "The creature is unaffected.",
                Success = "The creature is flat-footed against the triggering attack.",
                Failure = "The creature is flat-footed against the triggering attack and takes full damage from your illusory projectile.",
                CriticalFailure = "As failure, but double damage."
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Arcane.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("9aeaab45-5c61-4ed1-9eb7-0bc7e96ec7a9"), Traits.Instances.Illusion.ID);
            builder.Add(Guid.Parse("5a110c9d-579c-44a2-8747-b4f9556b1c20"), Traits.Instances.Shadow.ID);
            builder.Add(Guid.Parse("770b18b6-98c5-458a-a01a-29e2d5933378"), Traits.Instances.Visual.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4c7783ac-37f7-45fc-b2c4-41494daef938"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 128
            };
        }
    }
}
