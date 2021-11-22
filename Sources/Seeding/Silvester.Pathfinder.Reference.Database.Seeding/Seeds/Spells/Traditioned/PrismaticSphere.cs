using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class PrismaticSphere : Template
    {
        public static readonly Guid ID = Guid.Parse("3e624275-8104-4d82-922c-648e109f648a");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Prismatic Sphere",
                Level = 9,
                Range = "10 feet.",
                Duration = "1 hour.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Abjuration.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ada20c61-75c9-459c-bfe4-84506e0f7914"), Type = TextBlockType.Text, Text = "You create a seven-layered sphere to protect an area. This multicolored sphere functions like a prismatic wall but is shaped in a 10-foot burst centered on a corner of your space. You must form the sphere in an unbroken open space so its edges don't pass through any creatures or objects, or the spell is lost." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
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
            yield return Traits.Instances.Abjuration.ID;
            yield return Traits.Instances.Light.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("eec040e1-f5e7-416b-9087-97a6eed8d354"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 359
            };
        }
    }
}
