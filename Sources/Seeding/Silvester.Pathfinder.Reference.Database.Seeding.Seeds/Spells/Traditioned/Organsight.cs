using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class Organsight : Template
    {
        public static readonly Guid ID = Guid.Parse("17a9bbf7-d7fe-4961-b00c-6a77d81a7bd4");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Organsight",
                Level = 3,
                Range = "30 feet.",
                Duration = "1 minute.",
                Targets = "1 living or undead creature that has organs.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Divination.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("26f766c7-3316-4a05-b3a9-86c7e6a90384"), Type = TextBlockType.Text, Text = "You see the target as though it's dissected and arrayed before you. For the duration, you gain a +2 circumstance bonus on Medicine checks against the target that depend on its organs, but a -2 circumstance penalty on Medicine checks depending on seeing its skin." };
            yield return new TextBlock { Id = Guid.Parse("94a04f87-f428-469e-bde7-6366a0300267"), Type = TextBlockType.Text, Text = "When you Cast the Spell, attempt a special Recall Knowledge check using Medicine to spot and discern a vital organ. If you have a Lore skill appropriate to the creature, you can use that skill instead of Medicine. If you succeed, the next time you deal piercing or slashing damage to the target with a Strike or spell, you deal 4d6 additional precision damage. Once on each of your subsequent turns, you can use a single action to attempt the special Recall Knowledge check again. The extra damage isn't cumulative, so making the check more than once before a Strike or spell has no extra benefit." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("56b55899-227a-47d0-a59d-f3e230b2c799"),
                Level = "+1",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("049aae71-459d-4400-9ca4-bdec32bde6e0"), Type = TextBlockType.Text, Text = "The precision damage increases by 1d6." }
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
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Occult.ID;
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("2176b197-ea01-4d14-8f95-45350deba8ac"), Traits.Instances.Divination.ID);
            builder.Add(Guid.Parse("68a0fab3-bcce-401d-b612-06d7a208e024"), Traits.Instances.Revelation.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("471e4f14-af84-415d-9b90-e4ae011c3fa4"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 120
            };
        }
    }
}
