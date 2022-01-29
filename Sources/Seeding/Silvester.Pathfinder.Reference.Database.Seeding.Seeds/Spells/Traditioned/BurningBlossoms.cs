using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class BurningBlossoms : Template
    {
        public static readonly Guid ID = Guid.Parse("55bae16a-d51a-4260-8f08-c384afa0088c");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Burning Blossoms",
                Level = 93,
                Range = "120 feet.",
                Duration = "1 minute.",
                Area = "30-foot radius, 100-foot tall cylinder.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("46eb7c7f-ebb3-4655-bdd7-6e1481b076e2"), Type = TextBlockType.Text, Text = "An intangible hollow tree sprouts from the ground and grows to towering height, radiating a fiery passion and fascinating viewers. The base of the tree takes up a single square and grows 100 feet upwards, while its branches extend outwards 30 feet, forming the spell's cylindrical area. The tree then blossoms, growing delicate white flowers that burn with white-hot fire. As the tree's branches gently rustle in the wind, flower petals drift to the ground in a shower of flame. Any creature that ends its turn under the tree's branches takes 6d6 fire damage from the burning petals." };
            yield return new TextBlock { Id = Guid.Parse("67409599-de21-4aa3-8731-18ccddc3adfa"), Type = TextBlockType.Text, Text = "Any enemy that can see the tree, even if the enemy is outside the spell's area, must attempt a Will save. This is an emotion, mental, and visual effect. Creatures fascinated with the tree must use at least one of their actions on each of their turns to move toward the tree." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("6ec2ff3e-b098-41b7-b777-859670d7042d"),
                Level = "+1",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("144e2f40-a9ab-4191-b87b-3fb63f3b6a0f"), Type = TextBlockType.Text, Text = "The damage increases by 1d6." }
                }
            };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("61bcd43d-be55-4261-aa7d-2882d25c0198"),
                CriticalSuccess = "The creature is unaffected and is temporarily immune for 24 hours.",
                Success = "The creature is unaffected, but it must attempt a new save at the end of its turn if it can still see the tree.",
                Failure = "The creature is fascinated with the tree until the end of its next turn.If it can still see the tree then, it must attempt a save again.",
                CriticalFailure = "The creature is fascinated with the tree until the spell ends.The tree's fire damage doesn't end the fascination; other hostile actions end it, as normal.If the fascination ends, the creature must attempt a new save at the end of its turn if it can still see the tree."
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
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("04913c23-6519-4e08-a347-eeb87ee5c50f"), Traits.Instances.Enchantment.ID);
            builder.Add(Guid.Parse("38549902-034b-4182-972f-adb9acef1dcf"), Traits.Instances.Fire.ID);
            builder.Add(Guid.Parse("0e02256b-5e78-4580-94ec-84fd0d4ea349"), Traits.Instances.Plant.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2873af33-efc4-470b-9e3f-2566517b4a24"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 93
            };
        }
    }
}
