using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class Approximate : Template
    {
        public static readonly Guid ID = Guid.Parse("92dc262b-6687-4b03-97a5-b05aad90f08f");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Approximate",
                Level = 1,
                Range = "10 feet.",
                Area = "1 cubic foot.",
                SpellTypeId = SpellTypes.Instances.Cantrip.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Divination.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5c64fcef-72d0-4d16-a059-5ad447714b6d"), Type = TextBlockType.Text, Text = "Your magic quickly flows over an area to help you count and catalog. Name a particular type of object you are looking for within the area. You gain an instant estimate of the quantity of the chosen objects that are clearly visible within the target area. The number is rounded to the largest digit. For example, you could look at a pile of 180 copper coins, and you would learn that it held about 200 coins, but you couldn't determine there were exactly 180 coins." };
            yield return new TextBlock { Id = Guid.Parse("15fd5a4b-726c-4584-b64e-9fd57de0d463"), Type = TextBlockType.Text, Text = "The type of object you name can be as specific or general as you like - 'dented copper coins' is as viable as 'coins' - but the distinguishing features must be obvious at a glance, and the spell is automatically fooled by objects disguised as other objects. For instance, the spell would register copper coins plated in gold as gold coins, not copper coins." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Arcane.ID;
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Occult.ID;
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("193b1e97-dbf2-439a-8746-049be414a5f5"), Traits.Instances.Cantrip.ID);
            builder.Add(Guid.Parse("3c42b91b-f3a5-4959-957d-369381d62699"), Traits.Instances.Detection.ID);
            builder.Add(Guid.Parse("996f605b-6c4c-481a-933d-637589f0f157"), Traits.Instances.Divination.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8b5d6f78-264c-49e7-b26f-f73e3cad42c7"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 90
            };
        }
    }
}
