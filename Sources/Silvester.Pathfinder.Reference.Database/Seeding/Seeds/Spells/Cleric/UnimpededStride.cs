using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class UnimpededStride : Template
    {
        public static readonly Guid ID = Guid.Parse("09c0cd36-f201-4891-8de5-6cfc6cc063df");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Unimpeded Stride",
                Level = 1,
                DomainId = Domains.Instances.Freedom.ID,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                ClassId = Classes.Instances.Cleric.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("92d6b0c4-24b5-4578-8e1a-688109ff834f"), Type = TextBlockType.Text, Text = "Nothing can hold you in place. You immediately escape from every magical effect that has you immobilized or grabbed unless the effect is of a higher level than your unimpeded stride spell. You then Stride. During this movement, you ignore difficult terrain and any circumstance or status penalties to your Speed." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Cleric.ID;
            yield return Traits.Instances.Transmutation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8ac00fb4-21e1-4998-b975-5fe34c7dff67"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 398
            };
        }
    }
}
