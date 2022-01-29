using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class BefittingAttire : Template
    {
        public static readonly Guid ID = Guid.Parse("f44797f1-5c62-4b72-ba64-d3a0a7eb2d55");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Befitting Attire",
                Level = 2,
                Range = "30 feet.",
                Duration = "1 hout.",
                Targets = "5 willing creatures.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Illusion.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d381046a-9457-4158-b80f-b35b69d0a3b0"), Type = TextBlockType.Text, Text = "You cloak the targets in an illusion, shaping their clothing and worn items into ones suitable for a particular occasion. You visualize the occasion, and the spell creates illusory attire customized to each target. For instance, if you visualized a noble ball, armor would appear to be fine clothing. This doesn't change identifying details of the targets' appearances other than their clothes." };
            yield return new TextBlock { Id = Guid.Parse("1bde25a4-3e11-4c10-b79f-e51ad66de146"), Type = TextBlockType.Text, Text = "Any creature that touches the attire, uses the Seek action to examine it, or otherwise interacts with it can attempt to disbelieve your illusion." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("dfc2b56f-476c-4c0d-8ec8-234e006d6a17"),
                Level = "4th",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("f22aa443-7308-474e-b0e8-4bd6ecc79f05"), Type = TextBlockType.Text, Text = "You can target up to 20 creatures." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("20cd9a06-737e-428b-a15f-5754bc6c6a83"),
                Level = "5th",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("8e400a2e-3eec-438f-af77-ace4eb164ca6"), Type = TextBlockType.Text, Text = "You can target up to 100 creatures." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Material.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Arcane.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("f65dbc3b-3df9-4817-a133-97b6c85cc60f"), Traits.Instances.Illusion.ID);
            builder.Add(Guid.Parse("d5de19c5-3cd2-42f3-831d-bfb1750a7905"), Traits.Instances.Visual.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ea9ac0c9-a40b-4eb4-97fa-0fe80ad52ce2"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 90
            };
        }
    }
}
