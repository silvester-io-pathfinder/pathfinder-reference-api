using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class Sunburst : Template
    {
        public static readonly Guid ID = Guid.Parse("4c4f275c-b1e8-448b-a1aa-66bb2af4fe08");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Sunburst",
                Level = 7,
                Range = "500 feet.",
                Area = "60-foot burst.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Reflex.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3ce8a6b8-8691-4f26-ae41-70bd27381706"), Type = TextBlockType.Text, Text = "A powerful globe of searing sunlight explodes in the area, dealing 8d10 fire damage to all creatures in the area, plus 8d10 additional positive damage to undead creatures. Each creature in the area must attempt a Reflex save." };
            yield return new TextBlock { Id = Guid.Parse("30e0e59a-4535-44dc-8937-a7396ec7d822"), Type = TextBlockType.Text, Text = "If the globe overlaps with an area of magical darkness, sunburst attempts to counteract the darkness effect." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("dada4fcb-2fbd-4a14-ae8b-6382c37c9eda"), 
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("b4d4faef-d1d7-48f8-a7f2-6f75e00a9c71"), Type = TextBlockType.Text, Text = "The fire damage increases by 1d10, and the positive damage against undead increases by 1d10." }
                }
            };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("ed1eb2e5-9344-45c9-83b5-a79f13af9869"),
                CriticalSuccess = "The creature is unaffected.",
                Success = "The creature takes half damage.",
                Failure = "The creature takes full damage.",
                CriticalFailure = "The creature takes full damage and becomes blinded permanently.",
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Evocation.ID;
            yield return Traits.Instances.Fire.ID;
            yield return Traits.Instances.Light.ID;
            yield return Traits.Instances.Positive.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("653ac453-5164-40a0-aaad-a0910a7e10a8"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 376
            };
        }
    }
}
