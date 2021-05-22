using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class SummonInstrument : Template
    {
        public static readonly Guid ID = Guid.Parse("96d4f746-57f2-42dc-b5ae-6537e19ebc91");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Summon Instrument",
                Level = 1,
                Duration = "1 hour.",
                SpellTypeId = SpellTypes.Instances.Cantrip.ID,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                MagicSchoolId = MagicSchools.Instances.Conjuration.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("96d4f746-57f2-42dc-b5ae-6537e19ebc91"), Type = TextBlockType.Text, Text = "You materialize a handheld musical instrument in your grasp. The instrument is typical for its type, but it plays only for you. The instrument vanishes when the spell ends. If you cast summon instrument again, any instrument you previously summoned disappears." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("96d4f746-57f2-42dc-b5ae-6537e19ebc91"), 
                Level = "5th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("96d4f746-57f2-42dc-b5ae-6537e19ebc91"), Type = TextBlockType.Text, Text = "The instrument is instead a virtuoso handheld instrument." }
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
            yield return Traits.Instances.Cantrip.ID;
            yield return Traits.Instances.Conjuration.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("96d4f746-57f2-42dc-b5ae-6537e19ebc91"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 226
            };
        }
    }
}
