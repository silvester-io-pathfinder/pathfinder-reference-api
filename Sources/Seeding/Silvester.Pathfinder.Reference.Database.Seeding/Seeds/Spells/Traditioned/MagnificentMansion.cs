using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class MagnificentMansion : Template
    {
        public static readonly Guid ID = Guid.Parse("d3d0920b-9de1-4752-bf0a-dabdfc6671ee");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Magnificent Mansion",
                Level = 7,
                CastTime = "1 minute.",
                Range = "30 feet.",
                Duration = "24 hours.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.LongAction.ID,
                MagicSchoolId = MagicSchools.Instances.Conjuration.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6ff7411a-d558-4f8c-9a06-a559307fbf38"), Type = TextBlockType.Text, Text = "You conjure an extradimensional demiplane consisting of a spacious dwelling with a single entrance. The entrance connects to the plane where you Cast the Spell, appearing anywhere within the spell's range as a faint, shimmering, vertical rectangle 5 feet wide and 10 feet high. You designate who can enter when you cast the spell. Once inside, you can shut the entrance, making it invisible. You and the creatures you designated can reopen the door at will, just like opening a physical door." };
            yield return new TextBlock { Id = Guid.Parse("f0388a5a-9840-4cc2-afde-decf2089fdcd"), Type = TextBlockType.Text, Text = "Inside, the demiplane appears to be a mansion featuring a magnificent foyer and numerous opulent chambers. The mansion can have any floor plan you imagine as you Cast the Spell, provided it fits within a space 40 feet wide, 40 feet deep, and 30 feet tall. While the entrance to the mansion is closed, effects from outside the mansion fail to penetrate it, and vice versa, except for plane shift, which can be used to enter the mansion. You can use scrying magic and similar effects to observe the outside only if they're capable of crossing planes." };
            yield return new TextBlock { Id = Guid.Parse("53e43570-a5b5-46e3-b677-b9316f87fcaf"), Type = TextBlockType.Text, Text = "A staff of up to 24 servants attends to anyone within the mansion. These are like the servant created by the unseen servant spell, though they're visible, with an appearance you determine during casting. The mansion is stocked with enough food to serve a nine-course banquet to 150 people." };
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
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Conjuration.ID;
            yield return Traits.Instances.Extradimensional.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("689cf877-6de8-41f3-a568-f0c47d224a8f"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 349
            };
        }
    }
}
