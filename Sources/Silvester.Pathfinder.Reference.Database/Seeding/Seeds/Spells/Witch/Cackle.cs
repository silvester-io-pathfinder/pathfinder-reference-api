using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class Cackle : Template
    {
        public static readonly Guid ID = Guid.Parse("21c06ba3-1e8b-4b82-a6d7-da1251d311af");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Cackle",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                ClassId = Classes.Instances.Witch.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("458b21d7-e634-4698-bee9-d61c834d4218"), Type = TextBlockType.Text, Text = "With a quick burst of laughter, you prolong a magical effect you created. You Sustain a Spell." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Enchantment.ID;
            yield return Traits.Instances.Hex.ID;
            yield return Traits.Instances.Witch.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d3b6b0aa-a26f-488c-a8ea-5fa57a68296d"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 237
            };
        }
    }
}
