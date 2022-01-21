using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class PhantomPain : Template
    {
        public static readonly Guid ID = Guid.Parse("ece946f0-28b2-4b5c-a886-0bfd5d2e00b8");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Phantom Pain",
                Level = 1,
                Range = "30 feet.",
                Duration = "1 minute.",
                Targets = "1 creature.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Illusion.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ccd49ccb-de97-4605-a376-8af98bf20d5d"), Type = TextBlockType.Text, Text = "Illusory pain wracks the target, dealing 2d4 mental damage and 1d4 persistent mental damage. The target must attempt a Will save." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("2a8cc1d9-47e8-45e7-9943-ba8837f0f8cb"), 
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("4dc338ab-c027-44fd-89cf-12ecf19b55f3"), Type = TextBlockType.Text, Text = "The damage increases by 2d4 and the persistent damage by 1d4." }
                }
            };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("4849d02a-26d0-41f3-8828-2c33f84e4a05"),
                CriticalSuccess = "The target is unaffected.",
                Success = "The target takes full initial damage but no persistent damage, and the spell ends immediately.",
                Failure = "The target takes full initial and persistent damage, and the target is sickened 1. If the target recovers from being sickened, the persistent damage ends and the spell ends.",
                CriticalFailure = "As failure, but the target is sickened 2."
            };
        }


        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("13ffaf56-43fa-4c12-bb3a-e37c54a8dea0"), Traits.Instances.Illusion.ID);
            builder.Add(Guid.Parse("db38a689-8881-4d22-a465-e40f8cad6341"), Traits.Instances.Mental.ID);
            builder.Add(Guid.Parse("b60435a2-23cc-467e-b46a-b63c824090d2"), Traits.Instances.Nonlethal.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fc00c922-5f42-4b9d-a233-71330536d8a3"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 357
            };
        }
    }
}
