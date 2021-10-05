using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class LightningBolt : Template
    {
        public static readonly Guid ID = Guid.Parse("c6a647e0-e06b-4a5d-a91a-5efb18b9e159");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Lightning Bolt",
                Level = 3,
                Area = "120-foot line.",
                IsSavingThrowBasic = true,
                SavingThrowStatId = SavingThrowStats.Instances.Reflex.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("44293f2b-0eb5-4909-83a9-f6e92a950803"), Type = TextBlockType.Text, Text = "A bolt of lightning strikes outward from your hand, dealing 4d12 electricity damage." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("2385abb6-3bd4-4622-8df6-e8357d96ebfd"), 
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("ecf5488a-4483-4541-941c-7bb5e3c80645"), Type = TextBlockType.Text, Text = "The damage increases by 1d12." }
                }
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
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Electricity.ID;
            yield return Traits.Instances.Evocation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b504ad02-e277-4327-b0b5-1679cf70149a"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 348
            };
        }
    }
}
