using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class AccessLore : Template
    {
        public static readonly Guid ID = Guid.Parse("8dd7a3d1-736c-49fb-bf06-019fb7f530ca");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Access Lore",
                Level = 3,
                Duration = "1 minute.",
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                ClassId = Classes.Instances.Oracle.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Abjuration.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8bca2147-27ca-4e2c-9470-4bdd9f4446a1"), Type = TextBlockType.Text, Text = "You sift through the multiverse's divine knowledge, seeking out tidbits related to a particular subject. Choose one Lore skill. You temporarily gain the same proficiency rank in that Lore skill as your proficiency rank for your oracle spellcasting." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("3c641dd4-6f40-4a9f-84ce-35522bb2c67e"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("e6ccd133-fdf9-49c3-a50e-092ed4847e59"), Traits.Instances.Cursebound.ID);
            builder.Add(Guid.Parse("d4d9f90a-3864-4752-8157-2188a79c3dd7"), Traits.Instances.Divination.ID);
            builder.Add(Guid.Parse("9b8506fc-687a-4e9b-ad06-807a3c734975"), Traits.Instances.Fortune.ID);
            builder.Add(Guid.Parse("d8ae06d1-0937-49a3-b068-b9e307cf033c"), Traits.Instances.Oracle.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("aa500d31-86ac-4f15-84b5-e483c44158c4"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 229
            };
        }
    }
}
