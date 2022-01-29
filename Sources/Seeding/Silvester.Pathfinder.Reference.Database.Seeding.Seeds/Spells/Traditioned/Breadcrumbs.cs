using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class Breadcrumbs : Template
    {
        public static readonly Guid ID = Guid.Parse("95c38b10-623f-4f49-a42d-93fd6e9c9016");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Breadcrumbs",
                Level = 1,
                Range = "Touch.",
                Duration = "1 hour.",
                Targets = "1 willing creature.",
                CastTime = "1 minute.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                MagicSchoolId = MagicSchools.Instances.Abjuration.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("39692ef1-ae99-455e-8002-1c34689c30b9"), Type = TextBlockType.Text, Text = "You protect your target from going astray in hostile territory by tracking where it's already been, helping it deduce where it still needs to go. The target leaves a glittering trail behind it that lasts for the spell's duration. This trail doesn't denote the direction or the order of its path - it merely indicates where the target has moved during the spell's duration." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("88387d8e-2abd-435a-be7f-0b972fa83526"),
                Level = "2nd",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("2f5298e3-5db8-4453-b76f-97e01b58c449"), Type = TextBlockType.Text, Text = "The duration increases to 8 hours." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("bdc6f55b-03e3-4b60-9b86-36538d4decca"),
                Level = "3rd",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("cd3175df-d92e-4a33-b683-4ce53fc86a25"), Type = TextBlockType.Text, Text = "The duration increases to last until your next daily preparations." }
                }
            };

        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Material.ID;
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
            builder.Add(Guid.Parse("16999617-4bf0-4b5d-9476-93c9fb12b8b4"), Traits.Instances.Abjuration.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("48998ff5-66d7-4c4d-a426-85bc8fc196e1"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 92
            };
        }
    }
}
