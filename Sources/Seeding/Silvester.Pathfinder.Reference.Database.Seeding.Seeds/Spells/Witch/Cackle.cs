using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class Cackle : Template
    {
        public static readonly Guid ID = Guid.Parse("21c06ba3-1e8b-4b82-a6d7-da1251d311af");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Cackle",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                ClassId = Classes.Instances.Witch.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("458b21d7-e634-4698-bee9-d61c834d4218"), Type = TextBlockType.Text, Text = "With a quick burst of laughter, you prolong a magical effect you created. You Sustain a Spell." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("54062bc6-06da-46bc-b51e-6c7d76ec33c6"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("db18261e-e32f-441e-abe1-e6b3dfa775bf"), Traits.Instances.Enchantment.ID);
            builder.Add(Guid.Parse("4ee05d7a-2887-475e-b0aa-c1effcfacecd"), Traits.Instances.Hex.ID);
            builder.Add(Guid.Parse("8dc9dfa8-32ab-43c5-be56-1ed17882b63c"), Traits.Instances.Witch.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d3b6b0aa-a26f-488c-a8ea-5fa57a68296d"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 237
            };
        }
    }
}
