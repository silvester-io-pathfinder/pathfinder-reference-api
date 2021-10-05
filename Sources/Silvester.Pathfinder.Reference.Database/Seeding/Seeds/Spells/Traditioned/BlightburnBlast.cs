using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class BlightburnBlast : Template
    {
        public static readonly Guid ID = Guid.Parse("bf2b8cba-4ec4-4e0e-909a-4271289b97d1");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Blightburn Blast",
                Level = 7,
                Area = "15-foot cone.",
                IsSavingThrowBasic = true,
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("09c36c38-903a-461e-84cb-7ca09fd03698"), Type = TextBlockType.Text, Text = "You channel a blast of powerful blightburn radiation from your hands. You deal 4d6 poison damage to creatures in the area. Creatures who fail their save are afflicted with stage 1 of blightburn sickness (on a critical failure, the creature moves immediately to stage 2). The level of blightburn sickness caused by this spell is equal to twice the spell's level, and the disease's save DC uses the caster's DC." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Arcane.ID;
            yield return MagicTraditions.Instances.Occult.ID;
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Disease.ID;
            yield return Traits.Instances.Evocation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9e09098c-01ff-437a-9db2-be7ddb0eabd0"),
                SourceId = Sources.Instances.Pathfinder155.ID,
                Page = 73
            };
        }
    }
}
