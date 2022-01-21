using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class NymphsToken : Template
    {
        public static readonly Guid ID = Guid.Parse("3001e7d6-960a-4118-9d3b-a971b83c51cb");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Nymph's Token",
                Level = 1,
                IsDismissable = true,
                Duration = "1 minute.",
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                ClassId = Classes.Instances.Sorcerer.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e9d3392d-696b-4ea4-b87a-69dc6847621b"), Type = TextBlockType.Text, Text = "You grant an ally a token of favor. You create a token, such as a lock of your hair or a flower, that persists for the spell's duration; as part of Casting the Spell, you can Interact to pass the token to an ally within your reach. As long as the ally has the token on their person, they gain a +1 status bonus to Performance checks and Will saves. You can Dismiss the spell as a free action." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("e0672c57-4f38-48fb-9edd-a43b55521784"),
                Level = "4th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("bab1a703-8566-416b-84c9-ae98b25bf743"), Type = TextBlockType.Text, Text = "As long as the ally has the token on their person, you can cast spells that have a range of touch on them at a range of 30 feet." }
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
            builder.Add(Guid.Parse("bbdc7ac7-812d-4dc1-ab36-c967791e4567"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("d337675a-8886-4853-8c57-5845ce780b01"), Traits.Instances.Enchantment.ID);
            builder.Add(Guid.Parse("6846c983-df6d-4fdc-b8ea-448f893faeaf"), Traits.Instances.Sorcerer.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("884c811f-6c7f-469b-8fa9-d4d9ca7c7a85"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 236
            };
        }
    }
}
