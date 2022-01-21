using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class FeralShades : Template
    {
        public static readonly Guid ID = Guid.Parse("e3846a96-bbd6-4312-a045-6b7f7ca5786c");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Feral Shades",
                Level = 2,
                Area = "30-foot cone.",
                IsSavingThrowBasic = true,
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("17ae1033-9348-4e27-98f9-f85106eb5f45"), Type = TextBlockType.Text, Text = "A wave of gray mist formed of negative energy spills out from your outstretched hand, briefly taking the shape of a pack of predatory animals that set viciously on your foes. You deal 2d4 slashing damage and 2d4 negative damage to creatures in the area. The shades set upon the vulnerable with greater ferocity: prone creatures or those taking persistent bleed damage take a �2 status penalty to the save." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("e1b4b8ef-10ca-4290-b422-346e14cc68f6"),
                Level = "+1",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("c655efe8-424b-414d-adcc-79bb3b74c292"), Type = TextBlockType.Text, Text = "The slashing damage and the negative damage each increase by 1d4." }
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
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("e5e4a7ab-41df-4d77-aa5f-772d44f961c9"), Traits.Instances.Necromancy.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("010c5cec-0f62-4a59-b5ad-601204f4d459"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 105
            };
        }
    }
}
