using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class SearingLight : Template
    {
        public static readonly Guid ID = Guid.Parse("20b5399e-43d6-4d0b-8ab4-182f32d3b72b");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Searing Light",
                Level = 3,
                Range = "120 feet.",
                Targets = "1 creature",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("71bed422-4dcd-4443-a9f4-9ab968aed5ad"), Type = TextBlockType.Text, Text = "You shoot a blazing ray of light tinged with holy energy. Make a ranged spell attack. The ray deals 5d6 fire damage. If the target is a fiend or undead, you deal an extra 5d6 good damage." };
            yield return new TextBlock { Id = Guid.Parse("50d699d6-13f6-4c9c-a24c-0e07fb56485c"), Type = TextBlockType.Text, Text = "If the light passes through an area of magical darkness or targets a creature affected by magical darkness, searing light attempts to counteract the darkness. If you need to determine whether the light passes through an area of darkness, draw a line between yourself and the spell's target." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("5d970c2f-9ea4-4cf5-a2ca-7853f8fffad9"),
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("64603db1-9a93-457e-a344-a6924f77534e"), Type = TextBlockType.Text, Text = "The fire damage increases by 2d6, and the good damage against fiends and undead increases by 2d6." }
                }
            };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("43ac2ddb-19d1-4f13-8d5e-42a6da377e9e"),
                CriticalSuccess = "The target takes double fire damage, as well as double good damage if a fiend or undead.",
                Success = "The target takes full damage.",
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
            yield return Traits.Instances.Attack.ID;
            yield return Traits.Instances.Evocation.ID;
            yield return Traits.Instances.Fire.ID;
            yield return Traits.Instances.Good.ID;
            yield return Traits.Instances.Light.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("40af1c8b-ad56-4d08-9d70-9092095329b5"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 367
            };
        }
    }
}
