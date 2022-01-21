using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class PenumbralShroud : Template
    {
        public static readonly Guid ID = Guid.Parse("64e9555b-43aa-4bfa-bdb8-112794444a9d");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Penumbral Shroud",
                Level = 1,
                Range = "30 feet.",
                Duration = "10 minutes.",
                Targets = "1 creature.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Reflex.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("22d8363d-f2e5-4b02-86e2-b6cb7d2b2d20"), Type = TextBlockType.Text, Text = "You envelop the target in a shroud of shadow. The target perceives light as one step lower than it actually is (bright light becomes dim light, for example), affecting their ability to sense creatures and objects accordingly. The shroud also provides the target a +1 status bonus to saving throws against light effects. While this effect is helpful to creatures sensitive to light, if the creature is unwilling, it can attempt a Reflex save to avoid the shroud and reduce the effect." };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("e2d40e08-9c28-495f-b2a2-fb38e8817851"),
                CriticalSuccess = "The target is unaffected.",
                Success = "The effect lasts for 1 round",
                Failure = "The effect lasts its normal duration."
            };
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

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("78904e4d-946a-4d1d-929a-d80a950541ee"), Traits.Instances.Darkness.ID);
            builder.Add(Guid.Parse("f55679f1-ca8d-4a8c-8001-c0bf814a17d7"), Traits.Instances.Evocation.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5251d1b4-a2b7-4788-8b64-a20681fd18bc"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 109
            };
        }
    }
}
