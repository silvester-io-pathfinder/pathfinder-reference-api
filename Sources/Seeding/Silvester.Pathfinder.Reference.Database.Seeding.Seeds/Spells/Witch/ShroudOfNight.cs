using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class ShroudOfNight : Template
    {
        public static readonly Guid ID = Guid.Parse("5bc3a789-1e57-4e0a-b1a2-c495e1fa3942");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Shroud of Night",
                Level = 1,
                Range = "30 feet.",
                Targets = "1 creature.",
                IsDismissable = true,
                Duration = "Sustained up to 1 minute.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                ClassId = Classes.Instances.Witch.ID,
                SpellTypeId = SpellTypes.Instances.Cantrip.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d6317af0-9b81-4a27-b565-7f4359d70ab7"), Type = TextBlockType.Text, Text = "Drawing your hand in a sweeping gesture, you shroud the target in a veil of night. The target's eyes are blanketed in darkness. If you cast this hex on a willing ally (for instance, one with light blindness), the ally can choose which result it gets without rolling. Regardless of the outcome, the target is then temporarily immune for 1 minute." };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("a9cd0968-05e4-42d5-9f30-09abbdad067f"),
                Success = "The target is unaffected.",
                Failure = "The target is shrouded in murky darkness. Unless the target has darkvision, other creatures are concealed to it.",
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("f72fe03e-ab9d-4905-89ec-1a4d2387310d"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("e91f2e22-c5b0-4c24-861e-4b8eb503b2b1"), Traits.Instances.Cantrip.ID);
            builder.Add(Guid.Parse("c50ec25c-5002-4871-9c61-cb277edb390d"), Traits.Instances.Darkness.ID);
            builder.Add(Guid.Parse("a08a2f61-4c35-4bb0-87f9-abceb2a0e1b7"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("8ba05587-7e5d-4388-a451-7329f0323b67"), Traits.Instances.Hex.ID);
            builder.Add(Guid.Parse("ce22ef7c-f605-48bf-a41d-79895f75aa11"), Traits.Instances.Witch.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("122ab48e-954e-4ec3-8841-d292ba8ba655"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 239
            };
        }
    }
}
