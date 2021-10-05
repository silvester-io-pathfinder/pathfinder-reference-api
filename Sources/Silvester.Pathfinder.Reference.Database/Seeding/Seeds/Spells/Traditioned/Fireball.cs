using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class Fireball : Template
    {
        public static readonly Guid ID = Guid.Parse("f2b268fd-8556-4ada-863e-4e078fb6e3a4");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Fireball",
                Level = 3,
                Range = "500 feet.",
                Area = "20-foot burst.",
                IsSavingThrowBasic = true,
                SavingThrowStatId = SavingThrowStats.Instances.Reflex.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a4b64034-31c8-440b-8370-64e81109ab66"), Type = TextBlockType.Text, Text = "A roaring blast of fire appears at a spot you designate, dealing 6d6 fire damage." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("ec044207-2766-4068-b989-bdc4b8a80add"), 
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("cc562a20-25bb-423e-9460-8da75972298d"), Type = TextBlockType.Text, Text = "The damage increases by 2d6." }
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
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Evocation.ID;
            yield return Traits.Instances.Fire.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("853afde4-6168-4297-a352-9e91e8a35066"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 338
            };
        }
    }
}
