using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class MedusasWrath : Template
    {
        public static readonly Guid ID = Guid.Parse("a5609f28-d70a-4ee1-a530-dfbd26dd4102");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Medusa's Wrath",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                ClassId = Classes.Instances.Monk.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("dd628605-b20e-4f1a-8e3b-eeae23e07f95"), Type = TextBlockType.Text, Text = "You make an attack filled with a medusa’s petrifying power. Make an unarmed Strike with the following additional effects." };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("17932042-701a-4d9e-a3f9-951982d7c114"),
                CriticalSuccess = "The target is slowed 2 and must attempt a Fortitude save at the end of each of its turns; this ongoing save has the incapacitation trait. On a failed save, the slowed condition increases by 1 (2 on a critical failure). A successful save reduces the slowed condition by 1. When a creature is unable to act due to the slowed condition from medusa’s wrath, it is petrified permanently. The spell ends if the creature is petrified or the slowed condition is removed.",
                Success = "As critical success, but the target is initially slowed 1.",
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Transmutation.ID;
            yield return Traits.Instances.Monk.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("32745f92-06f3-46d7-9873-934bd796d376"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 229
            };
        }
    }
}
