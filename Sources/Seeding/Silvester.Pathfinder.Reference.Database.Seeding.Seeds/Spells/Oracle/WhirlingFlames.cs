using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
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

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("6cddd33c-875b-4030-993a-9b47498084fe"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("fa547bdb-6454-4577-ad9c-37bd46153d24"), Traits.Instances.Cursebound.ID);
            builder.Add(Guid.Parse("3c3b058d-f0b1-4246-83eb-96b26c94e646"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("e18ed29a-49f6-420c-969c-89cce289403a"), Traits.Instances.Fire.ID);
            builder.Add(Guid.Parse("7e97f4c0-f029-43f9-9ee1-6f3e55dbf0b6"), Traits.Instances.Oracle.ID);
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
