using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class EmbraceThePit : Template
    {
        public static readonly Guid ID = Guid.Parse("c06f8857-f848-468d-a6db-5fc09d0db53d");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Embrace the Pit",
                Level = 3,
                Duration = "1 minute.",
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                ClassId = Classes.Instances.Sorcerer.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("77984545-797d-458c-88c2-38a0dce04535"), Type = TextBlockType.Text, Text = "Devil horns grow from your skull, and your skin takes on features of the devil responsible for your diabolic bloodline. You gain resistance 5 to evil, fire, and poison, and resistance 1 to physical damage (except silver). You can take good damage, even if you aren't evil, and you gain weakness 5 to good damage." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("ad4c8ce9-cfe4-4297-82ca-792fd556bdb6"),
                Level = "+2",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("2086573d-715a-481c-8d87-8978e439efa6"), Type = TextBlockType.Text, Text = "The resistance to evil, fire, and poison increases by 5, the resistance to physical damage (except silver) by 2, and the weakness to good damage by 5." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Evil.ID;
            yield return Traits.Instances.Morph.ID;
            yield return Traits.Instances.Sorcerer.ID;
            yield return Traits.Instances.Transmutation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9611a595-38b2-4266-95d2-21854ce646b5"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 404
            };
        }
    }
}
