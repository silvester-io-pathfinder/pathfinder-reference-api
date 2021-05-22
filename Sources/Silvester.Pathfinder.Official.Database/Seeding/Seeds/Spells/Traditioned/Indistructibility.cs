using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class Indistructibility : Template
    {
        public static readonly Guid ID = Guid.Parse("ee670296-650a-47c6-bcab-801782182e05");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Indistructibility",
                Level = 10,
                Duration = "Until the start of your next turn.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Abjuration.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("03babf6a-179f-45a8-b511-7f2cae0b3e76"), Type = TextBlockType.Text, Text = "You can’t be affected by anything unless you choose to be. For the duration of the spell, you are immune to any effect or damage that would harm you, excluding effects caused by artifacts, deific power, and similarly powerful sources. You can still be affected by anything you’re willing to have affect you." };
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
            yield return MagicTraditions.Instances.Primal.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Abjuration.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7062c39b-a219-46d2-8391-b98153d0d94d"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 221
            };
        }
    }
}
