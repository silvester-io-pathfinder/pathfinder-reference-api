using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class WildingWord : Template
    {
        public static readonly Guid ID = Guid.Parse("629c7f74-0650-4646-8ff9-71e6fb5d4ec2");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Wilding Word",
                Level = 1,
                Range = "30 feet.",
                Targets = "1 animal, fungus or plant.",
                IsDismissable = true,
                Duration = "Sustained up to 1 minute.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                ClassId = Classes.Instances.Witch.ID,
                SpellTypeId = SpellTypes.Instances.Cantrip.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("dd28266f-ac02-48fa-b74c-ca3aa65efc48"), Type = TextBlockType.Text, Text = "With a few words, you convince a wild creature you are a kindred spirit, making it reluctant to harm you. The target must attempt a Will save. Regardless of the outcome, the target is then temporarily immune for 1 minute." };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("5bd3b44a-1c0d-47ac-9254-56f9c3434c8b"),
                CriticalSuccess = "The target is unaffected.",
                Success = "When the target attempts an attack roll or skill check that would harm you, it takes a –2 status penalty to its roll.",
                Failure = "As success, but the target also becomes sickened 1 each time it damages you.",
                CriticalFailure = "As success, but the target also becomes sickened 2 each time it damages you."
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("8d3b74d0-d859-43ea-8422-0139275a7e20"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("cca9220b-fac7-4d25-b291-09a459a56bdb"), Traits.Instances.Cantrip.ID);
            builder.Add(Guid.Parse("5de01943-8a00-482f-81f8-eed15b731032"), Traits.Instances.Enchantment.ID);
            builder.Add(Guid.Parse("dcdd1344-1bfa-4f93-ac4e-03e3102ec238"), Traits.Instances.Hex.ID);
            builder.Add(Guid.Parse("c49ed3f0-5d62-4467-974b-4c6c6a6a5ae1"), Traits.Instances.Witch.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("992385e4-8234-41a3-84c1-df0e1a2fe34c"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 239
            };
        }
    }
}
