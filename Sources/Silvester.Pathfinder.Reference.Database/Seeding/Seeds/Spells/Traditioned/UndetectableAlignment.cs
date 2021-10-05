using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class UndetectableAlignment : Template
    {
        public static readonly Guid ID = Guid.Parse("c81cc083-9d1c-4e09-8777-ae07e067b3bd");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Undetectable Alignment",
                Level = 2,
                CastTime = "1 minute.",
                Range = "Touch.",
                Duration = "Until the next time you make your daily preparations.",
                Targets = "1 creature or object.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.LongAction.ID,
                MagicSchoolId = MagicSchools.Instances.Abjuration.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4ee4a1e5-a47c-49b2-a793-9e6a0044a8fa"), Type = TextBlockType.Text, Text = "You shroud a creature or object in wards that hide its alignment. The target appears to be neutral to all effects that would detect its alignment." };
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
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Abjuration.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("996ca873-ff17-47fd-a59c-f592baa5ac1c"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 379
            };
        }
    }
}
