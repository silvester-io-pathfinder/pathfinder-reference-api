using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class NeedleOfVengeance : Template
    {
        public static readonly Guid ID = Guid.Parse("ad99267f-97a8-411d-8f85-898742a2975d");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Needle of Vengeance",
                Level = 1,
                Range = "30 feet.",
                Targets = "1 enemy.",
                IsDismissable = true,
                Duration = "Sustained up to 1 minute.",
                IsSavingThrowBasic = true,
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                ClassId = Classes.Instances.Witch.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8d7d06a2-8a79-4602-b894-1b919af6cb1a"), Type = TextBlockType.Text, Text = "A long, jagged needle jabs into the target foe's psyche whenever it tries to attack a specifically forbidden creature. Name yourself or one of your allies. The target takes 2 mental damage any time it uses a hostile action against the named creature." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("c38541d2-d2fc-4e2f-a223-37a614a2d01a"),
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("1cb8700d-7625-4ce1-92c2-7729809bbb10"), Type = TextBlockType.Text, Text = "Increase the damage by 2." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("c9ac9037-459a-46e3-80f3-79793e3a9545"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("c0e7ec9b-279c-45cc-99b2-828228b72e97"), Traits.Instances.Enchantment.ID);
            builder.Add(Guid.Parse("5ae06f25-a7f3-400f-a6d6-bc62e9d30aff"), Traits.Instances.Hex.ID);
            builder.Add(Guid.Parse("1872ca8f-9244-4caa-9d59-855caf0a9405"), Traits.Instances.Mental.ID);
            builder.Add(Guid.Parse("d26f4f4b-0193-4fd8-b463-2a955c51665c"), Traits.Instances.Witch.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3b0450e7-8bb6-43f5-b6bd-1127cc426db2"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 238
            };
        }
    }
}
