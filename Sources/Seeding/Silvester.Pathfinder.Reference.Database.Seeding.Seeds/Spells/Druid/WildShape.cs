using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class WildShape : Template
    {
        public static readonly Guid ID = Guid.Parse("bd42cf13-9815-4ae6-bc48-9697640bd2cd");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Wild Shape",
                Level = 1,
                Duration = "1 minute (or longer).",
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                ClassId = Classes.Instances.Druid.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("de2d7f60-60db-417a-a990-a994d71e1c9c"), Type = TextBlockType.Text, Text = "You infuse yourself with primal essence and transform into another form. You can polymorph into any form listed in pest form, which lasts 10 minutes. All other wild shape forms last 1 minute. You can add more forms to your wild shape list with druid feats; your feat might grant you some or all of the forms from a given polymorph spell. When you transform into a form granted by a spell, you gain all the effects of the form you chose from a version of the spell heightened to wild shape's level. Wild shape allows you to use your own shapeshifting training more easily than most polymorph spells. When you choose to use your own attack modifier while polymorphed instead of the form's default attack modifier, you gain a +2 status bonus to your attack rolls." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("115a84a3-2c4b-4369-9dfb-f9d22da3fa95"),
                Level = "2nd",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("ce529000-04c0-4fa6-8bd6-e4cc41a0578e"), Type = TextBlockType.Text, Text = "You can also wild shape into the forms listed in animal form." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("f54eb89d-2ab6-4511-8c68-1434d5d96467"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("4394c2a4-215a-48ae-bd13-ddcd19428991"), Traits.Instances.Druid.ID);
            builder.Add(Guid.Parse("4562790f-d14d-440d-b8ab-93c8320321f3"), Traits.Instances.Polymorph.ID);
            builder.Add(Guid.Parse("a6a752d6-904f-4145-b8f8-d75593efa66c"), Traits.Instances.Transmutation.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bf1f9f75-0926-471f-9662-9f69bf852c1f"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 401
            };
        }
    }
}
