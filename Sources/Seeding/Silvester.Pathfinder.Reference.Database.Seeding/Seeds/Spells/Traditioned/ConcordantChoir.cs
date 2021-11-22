using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class ConcordantChoir : Template
    {
        public static readonly Guid ID = Guid.Parse("49d7b0e3-388b-4ef4-a0ff-557fdd282b3f");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Concordant Choir",
                Level = 1,
                Range = "30 feet.",
                Targets = "Varies.",
                IsSavingThrowBasic = true,
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.OneToThreeActions.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("60cdce39-27b6-4230-a2e4-b81183544f29"), Type = TextBlockType.Text, Text = "You unleash a dangerous consonance of reverberating sound, focusing on a single target or spreading out to damage many foes. The number of actions you spend Casting this Spell determines its targets, range, area, and other parameters." };
            yield return new TextBlock { Id = Guid.Parse("db5e644d-240e-48cf-b36d-666961a309cc"), Type = TextBlockType.Enumeration, Text = "[one-action] (verbal) The spell deals 1d4 sonic damage to a single enemy, with a basic Fortitude save." };
            yield return new TextBlock { Id = Guid.Parse("1c2b6860-a337-4f3f-9b58-a47bcd2782cf"), Type = TextBlockType.Enumeration, Text = "[two-actions] (somatic, verbal) The spell deals 2d4 sonic damage to all creatures in a 10-foot burst, with a basic Fortitude save." };
            yield return new TextBlock { Id = Guid.Parse("f47024ab-a1f7-4100-bd99-48ac85920e5a"), Type = TextBlockType.Enumeration, Text = "[three-actions] (material, somatic, verbal) The spell deals 2d4 sonic damage to all creatures in a 30-foot emanation, with a basic Fortitude save." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("ac12b714-db2a-4663-8506-1b837286aaf2"),
                Level = "+1",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("1f632e8f-d639-47b9-8459-081d5292689b"), Type = TextBlockType.Text, Text = "The damage increases by 1d4 for the 1-action version, or 2d4 for the other versions." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Material.ID;
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Evocation.ID;
            yield return Traits.Instances.Sonic.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("688b78ec-f2e4-4a64-8498-1c0ffe855369"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 96
            };
        }
    }
}
