using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class PassWithoutTrace : Template
    {
        public static readonly Guid ID = Guid.Parse("241077f3-8780-446d-83f7-b2ea3d8b92cc");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Pass Without Trace",
                Level = 1,
                Duration = "1 hour.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Abjuration.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("738f3b98-0304-4f08-84d5-0acf1fb12076"), Type = TextBlockType.Text, Text = "You obscure the tracks you leave behind and make it harder for others to find you. The DC of checks to Track you gains a +4 status bonus or is equal to your spell DC, whichever results in a higher DC. You can benefit from only one pass without trace spell at a time." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("a1ed4d85-a193-41f8-b48d-dc802b104908"),
                Level = "2nd",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("9dda5770-0483-4165-9f0c-f415b399f4fb"), Type = TextBlockType.Text, Text = "The duration increases to 8 hours." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("a9e8399a-6fd8-4323-80d4-143446720c5a"),
                Level = "4th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("9faececb-8353-4b8e-b748-94ce906a2095"), Type = TextBlockType.Text, Text = "The duration increases to 8 hours. The spell has a range of 20 feet and an area of a 20-foot-emanation, affecting up to 10 creatures of your choice within that area." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Abjuration.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c55f568f-8f7f-4bf6-a8e7-afb5ec4bfb5c"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 356
            };
        }
    }
}
