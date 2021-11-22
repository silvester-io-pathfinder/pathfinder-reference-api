using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class NecromancersGenerosity : Template
    {
        public static readonly Guid ID = Guid.Parse("744396f3-39f2-4581-959e-1fa5868cdf91");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Necromancer's Generosity",
                Level = 1,
                Range = "30 feet.",
                Duration = "1 minute.",
                Targets = "1 undead minion you control.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("34d55bc8-bcba-4ace-b538-e55f4d225041"), Type = TextBlockType.Text, Text = "You channel negative energy through your magical connection to your undead minion to strengthen the creature. The target regains 1d8+4 Hit Points when you Cast the Spell, and it gains a +2 status bonus to saves against positive effects for the duration." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("c55be169-a763-4d5b-b150-9886c9316a76"),
                Level = "+1",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("54d914a6-1924-4cee-b02c-e04a9cf97d09"), Type = TextBlockType.Text, Text = "The amount of healing increases by 1d8+4." }
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
            yield return MagicTraditions.Instances.Divine.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Necromancy.ID;
            yield return Traits.Instances.Negative.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4ab853cd-76ea-417d-a077-928fd76b3ea5"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 117
            };
        }
    }
}
