using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class FlamingSphere : Template
    {
        public static readonly Guid ID = Guid.Parse("9af2e49e-f7ff-4df5-9218-d68b57a7bd70");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Flaming Sphere",
                Level = 2,
                Range = "30 feet.",
                Area = "1 5-foot square.",
                IsDismissable = true,
                Duration = "Sustained up to 1 minute.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Reflex.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2b1fea4a-cb84-4261-ae81-a27a01bf5c07"), Type = TextBlockType.Text, Text = "You create a sphere of flame in a square within range. The sphere must be supported by a solid surface, such as a stone floor. The sphere deals 3d6 fire damage to each creature in the square where it first appears; each creature must attempt a basic Reflex save. On subsequent rounds, the first time you Sustain this Spell each round, you can leave the sphere in its square or roll it to another square within range. It deals 3d6 fire damage (basic Reflex save) to each creature in that square." };
            yield return new TextBlock { Id = Guid.Parse("91932a40-ad2c-48ee-93f3-9990a45df282"), Type = TextBlockType.Text, Text = "Creatures that succeed at their save take no damage (instead of half)." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("3578b116-0633-432a-a48a-a61ff31ff36b"), 
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("c2ab995a-952d-4812-9102-da5febafeea3"), Type = TextBlockType.Text, Text = "The damage increases by 1d6." }
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
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("873e3f57-14e3-4ec3-965e-ac170c062ae7"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("7bf326ba-4ec5-4643-889b-1fae0b09a8e3"), Traits.Instances.Fire.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("134f8826-e3e1-49fb-8760-b557f6bd0495"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 338
            };
        }
    }
}
