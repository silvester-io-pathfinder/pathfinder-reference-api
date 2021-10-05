using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class Cloudkill : Template
    {
        public static readonly Guid ID = Guid.Parse("1030f973-aee2-4c2f-8cc5-a98aa4594de4");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Cloudkill",
                Level = 5,
                Range = "120 feet.",
                Area = "20-foot burst",
                Duration = "1 minute.",
                IsSavingThrowBasic = true,
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Illusion.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e7e7b126-33a9-4112-b380-f01b86254c61"), Type = Utilities.Text.TextBlockType.Text, Text = "You conjure a poisonous fog. This functions as obscuring mist (page 355), except the area moves 10 feet away from you each round. You deal 6d8 poison damage to each breathing creature that starts its turn in the spell’s area. You can Dismiss the spell." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Material.ID;
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Arcane.ID;
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Death.ID;
            yield return Traits.Instances.Necromancy.ID;
            yield return Traits.Instances.Poison.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5bd91074-8ca2-4e9c-8ae3-8b5c1576b7a2"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 324
            };
        }
    }
}
