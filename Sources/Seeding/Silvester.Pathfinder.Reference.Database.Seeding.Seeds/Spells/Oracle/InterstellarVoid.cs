using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class InterstellarVoid : Template
    {
        public static readonly Guid ID = Guid.Parse("4e39b70b-f8b5-49b8-a73f-6b8c5e06a64b");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Interstellar Void",
                Level = 3,
                Range = "30 feet.",
                Targets = "1 creature.",
                IsDismissable = true,
                Duration = "Sustained up to 1 minute.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                ClassId = Classes.Instances.Oracle.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d43ae96b-8e79-428f-ab6c-8748347092d1"), Type = TextBlockType.Text, Text = "You call upon the frigid depths of outer space to bring a terrible chill to your enemy. The target is cloaked in the freezing void, which deals 3d6 cold damage immediately and when you Sustain the Spell on future turns, with a basic Fortitude save. The target is fatigued for as long as the effect persists." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("07846b9d-3c58-4785-bde2-532b07c398f5"),
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("17791204-050f-44d2-9827-dc643957d0b7"), Type = TextBlockType.Text, Text = "The cold damage increases by 1d6." }
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
            builder.Add(Guid.Parse("eccd2839-46e5-4fbb-9c7c-77a3986ffc39"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("5ba53435-2cd9-462a-8347-011670f0a2c4"), Traits.Instances.Cold.ID);
            builder.Add(Guid.Parse("78d4236d-1e6f-4bac-9e3d-4bf5d07573ed"), Traits.Instances.Cursebound.ID);
            builder.Add(Guid.Parse("d74d9f65-cff2-4984-bb5a-fa85bbcbfb0b"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("3214b84d-3c32-4db5-946c-d9a34c7b5a2f"), Traits.Instances.Oracle.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a69f67c2-76ea-4c24-a5bf-679d8278bbc5"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 232
            };
        }
    }
}
