using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class Disintegrate : Template
    {
        public static readonly Guid ID = Guid.Parse("8280e542-c9e9-41d9-b152-aff2f054d447");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Disintegrate",
                Level = 6,
                Range = "120 feet.",
                Targets = "1 creature or unattended object.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID,
            };
        }


        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c8d1996c-4bea-42d7-b28a-754df9d5b744"), Type = Utilities.Text.TextBlockType.Text, Text = "You fire a green ray at your target. Make a spell attack. You deal 12d10 damage, and the target must attempt a basic Fortitude save. On a critical hit, treat the save result as one degree worse. A creature reduced to 0 HP is reduced to fine powder; its gear remains." };
            yield return new TextBlock { Id = Guid.Parse("a36f0b28-ae6d-43ea-8671-40f6db86733c"), Type = Utilities.Text.TextBlockType.Text, Text = "An object you hit is destroyed (no save), regardless of Hardness, unless it’s an artifact or similarly hard to destroy. A single casting can destroy no more than a 10-foot cube of matter. This automatically destroys any force construct, such as a wall of force." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            { 
                Id = Guid.Parse("3ce62722-4290-4b4b-949f-d0698ff70202"),
                Level = "+1", 
                Details =
                {
                    new TextBlock { Id = Guid.Parse("86437516-b358-41b6-81ff-63f6d142fae3"), Type = Utilities.Text.TextBlockType.Text, Text = "The damage increases by 2d10." }
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
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Attack.ID;
            yield return Traits.Instances.Evocation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d74ab844-89d6-4099-bd79-07f53313973b"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 330
            };
        }
    }
}
