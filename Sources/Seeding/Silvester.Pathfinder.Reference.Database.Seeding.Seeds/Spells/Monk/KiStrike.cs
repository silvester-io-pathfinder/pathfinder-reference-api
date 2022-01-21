using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class KiStrike : Template
    {
        public static readonly Guid ID = Guid.Parse("ca078fe4-0c34-4343-9cd2-6d61eabb0a9b");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Ki Strike",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                ClassId = Classes.Instances.Monk.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("aa193a73-1625-432c-a26a-201458cd89a1"), Type = TextBlockType.Text, Text = "You focus your ki into magical attacks. Make an unarmed Strike or Flurry of Blows (this doesn't change the limit on using only one flourish per turn). You gain a +1 status bonus to your attack rolls with the Strikes, and the Strikes deal 1d6 extra damage. This damage can be any of the following types of your choice, chosen each time you Strike: force, lawful (only if you're lawful), negative, or positive." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("b1bd15c2-46d2-436a-acc8-cece1b824bb0"),
                Level = "+4",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("8f2cb8b4-6ef1-4dc1-9ae4-31519cb32fb1"), Type = TextBlockType.Text, Text = "The extra damage increases by 1d6." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("ed97e2a9-761c-4f56-afd9-82d6c523ba6a"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("de36d4e6-cef3-4d46-bf13-17b257e169e2"), Traits.Instances.Monk.ID);
            builder.Add(Guid.Parse("d67da63e-0bcb-4724-a08d-ccb9659ec69d"), Traits.Instances.Transmutation.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b749753d-d5bb-4d7b-97d4-3019a932fc53"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 401
            };
        }
    }
}
