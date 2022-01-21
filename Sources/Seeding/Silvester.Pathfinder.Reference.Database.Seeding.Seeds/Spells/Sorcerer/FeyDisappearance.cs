using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class FeyDisappearance : Template
    {
        public static readonly Guid ID = Guid.Parse("fb03cb86-9c97-4223-9f5b-ece6db58f301");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Fey Disappearance",
                Level = 3,
                Duration = "Until the end of your next turn.",
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                ClassId = Classes.Instances.Sorcerer.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("be79b667-af55-4eca-8557-c74e1175381e"), Type = TextBlockType.Text, Text = "You become invisible and ignore natural difficult terrain (such as underbrush). Any hostile action you use ends this invisibility, but you still ignore natural difficult terrain." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("f7a57f22-f916-48e6-a49d-9f53fc92cd80"),
                Level = "5th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("156b41ca-397e-444a-afaf-c114b321c2d6"), Type = TextBlockType.Text, Text = "If you use a hostile action, the invisibility doesn't end." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("a0745964-8491-4deb-8bd7-fc0efdbc50db"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("9bd8de2a-127c-4847-9694-775eda691913"), Traits.Instances.Enchantment.ID);
            builder.Add(Guid.Parse("2c2e9f2c-48b2-4500-9765-2b7d553e64d7"), Traits.Instances.Sorcerer.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e631e19c-d007-4e3f-8125-667854638a97"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 404
            };
        }
    }
}
