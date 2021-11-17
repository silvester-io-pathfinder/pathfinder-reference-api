using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class WhirlingFlames : Template
    {
        public static readonly Guid ID = Guid.Parse("44b564a0-37be-4ef7-b8b5-cae2f9ae7d77");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Whirling Flames",
                Level = 3,
                Range = "30 feet.",
                Area = "Up to two 5-foot bursts that don't overlap.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Reflex.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                ClassId = Classes.Instances.Oracle.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("867a9083-044b-477e-b557-baa5f6c6f03d"), Type = TextBlockType.Text, Text = "You call forth a storm of whirling flames, engulfing all creatures in that area and dealing 5d6 fire damage with a basic Reflex save." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("d00fa612-b772-49fe-9406-4f27c4d82b5a"),
                Level = "+2",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("a4d6de97-7e51-41fb-b8c2-98703fded453"), Type = TextBlockType.Text, Text = "The damage increases by 3d6, and you can add another nonoverlapping 5-foot burst to the area." }
                }
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
            yield return Traits.Instances.Cursebound.ID;
            yield return Traits.Instances.Evocation.ID;
            yield return Traits.Instances.Fire.ID;
            yield return Traits.Instances.Oracle.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("19a180df-48cd-4f54-b617-3845b6cb79f1"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 234
            };
        }
    }
}
