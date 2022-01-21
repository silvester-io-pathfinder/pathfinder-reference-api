using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class HastedAssault : Template
    {
        public static readonly Guid ID = Guid.Parse("24df773f-0556-4228-a691-3fd1b24ed47e");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Hasted Assault",
                Level = 7,
                Duration = "1 minute.",
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID,
                ClassId = Classes.Instances.Magus.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b77b8cc7-3daa-4a04-b2a3-4c204d996ffc"), Type = TextBlockType.Text, Text = "You call upon your magic to speed up your attacks. You gain the quickened condition and can use the extra action each round for only Strike actions." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("50a05f68-8cda-476a-a97f-a347520ea7aa"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("bf1ab62f-8605-4256-be81-712abdf14ee2"), Traits.Instances.Magus.ID);
            builder.Add(Guid.Parse("fae8e724-6479-4ee0-a8f7-64f38a580098"), Traits.Instances.Transmutation.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c40d819f-230a-4356-8781-7a57a5b7c8c2"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 143
            };
        }
    }
}
