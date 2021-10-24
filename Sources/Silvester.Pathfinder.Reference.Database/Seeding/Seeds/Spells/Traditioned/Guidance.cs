using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class Guidance : Template
    {
        public static readonly Guid ID = Guid.Parse("0793bce3-602c-4176-b4ff-31471af78ed9");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Guidance",
                Level = 1,
                Range = "30 feet.",
                Duration = "Until the start of your next turn.",
                Targets = "1 creature.",
                SpellTypeId = SpellTypes.Instances.Cantrip.ID,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                MagicSchoolId = MagicSchools.Instances.Divination.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4352ca51-487b-48b8-83dd-26bd7cd31b5d"), Type = TextBlockType.Text, Text = "You ask for divine guidance, granting the target a +1 status bonus to one attack roll, Perception check, saving throw, or skill check the target attempts before the duration ends. The target chooses which roll to use the bonus on before rolling. If the target uses the bonus, the spell ends. Either way, the target is then temporarily immune for 1 hour." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Primal.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Cantrip.ID;
            yield return Traits.Instances.Divination.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("28725de0-1602-423b-a333-801cb4526f3d"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 342
            };
        }
    }
}
