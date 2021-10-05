using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class SuddenShift : Template
    {
        public static readonly Guid ID = Guid.Parse("bbc7ea5b-753a-45b4-86fa-be2a891a8b69");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Sudden Shift",
                Level = 1,
                Trigger = "An enemy misses you with a melee attack",
                Duration = "Until the end of your next turn.",
                DomainId = Domains.Instances.Trickery.ID,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                ClassId = Classes.Instances.Cleric.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Abjuration.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9053f612-071b-4d9e-97eb-3afac193e029"), Type = TextBlockType.Text, Text = "You swiftly move from a dangerous spot and veil yourself. You Step and become concealed." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Abjuration.ID;
            yield return Traits.Instances.Cleric.ID;
            yield return Traits.Instances.Illusion.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("35048ea3-a00a-4a14-b76f-9ef845d617d5"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 397
            };
        }
    }
}
