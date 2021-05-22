using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class ScholarlyRecollection : Template
    {
        public static readonly Guid ID = Guid.Parse("c81d5fbd-890c-4bd8-97a6-d94e210229af");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Scholarly Recollection",
                Level = 1,
                Trigger = "You attempt a Perception check to Seek, or you attempt a skill check to Recall Knowledge with a skill you’re trained in.",
                DomainId = Domains.Instances.Knowledge.ID,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                ClassId = Classes.Instances.Cleric.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Divination.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("39f32fbc-fb17-45d3-bbda-9eb51e7ca2f4"), Type = TextBlockType.Text, Text = "Speaking a short prayer as you gather your thoughts, you’re blessed to find that your deity gave you just the right bit of information for your situation. Roll the triggering check twice and use the better result." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Cleric.ID;
            yield return Traits.Instances.Divination.ID;
            yield return Traits.Instances.Fortune.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0528e539-9c82-4dcd-b529-94f829fe08c2"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 396
            };
        }
    }
}
