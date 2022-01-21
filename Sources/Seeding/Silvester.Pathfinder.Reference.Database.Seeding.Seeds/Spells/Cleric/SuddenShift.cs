using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
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

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("009a3248-f811-47c2-947e-85d9d4ef78aa"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("f2f6a5bc-b543-4cbb-a0cc-2be84892bcd7"), Traits.Instances.Abjuration.ID);
            builder.Add(Guid.Parse("0e99eaf2-fd27-4a6a-8b4d-d72cfacf8941"), Traits.Instances.Cleric.ID);
            builder.Add(Guid.Parse("69a79d7f-daef-40ba-afa5-2874e677dd8d"), Traits.Instances.Illusion.ID);
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
