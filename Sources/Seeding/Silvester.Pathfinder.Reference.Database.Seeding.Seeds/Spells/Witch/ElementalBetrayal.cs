using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class ElementalBetrayal : Template
    {
        public static readonly Guid ID = Guid.Parse("a8e86e86-6313-4f24-b0ca-97b3992a3965");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Elemental Betrayal",
                Level = 1,
                Range = "30 feet.",
                Targets = "1 creature.",
                IsDismissable = true,
                Duration = "Sustained up to 1 minute.",
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                ClassId = Classes.Instances.Witch.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("362fb7fc-fd58-4fdb-8e7f-e61a7e9a715d"), Type = TextBlockType.Text, Text = "You call upon the elements to undermine your foe. When you Cast this Spell, choose air, earth, fire, or water. Each time the target takes damage from a spell or effect with the chosen trait, it takes an additional 2 damage of one damage type dealt by the spell or effect. If you chose fire or water, the target also takes this additional damage when taking fire or cold damage, respectively, from effects or spells without the chosen trait." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("3770c43a-edc5-4da3-b2a8-d21ac728729a"),
                Level = "+2",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("e64c40be-8bb8-4ca0-a08a-0106cec7ca78"), Type = TextBlockType.Text, Text = "Increase the additional damage by 1." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("29308810-663c-460d-a929-39e4d748cb1b"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("e09a5832-a4a3-49c0-97fc-00ad8d0d76ba"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("8913b6e6-1085-41f4-abe3-8335f049d066"), Traits.Instances.Hex.ID);
            builder.Add(Guid.Parse("d680c3a5-4cce-4125-a3f2-04ae787bc864"), Traits.Instances.Witch.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b0fc48f3-e63d-498e-8592-b5a9c33a3e49"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 238
            };
        }
    }
}
