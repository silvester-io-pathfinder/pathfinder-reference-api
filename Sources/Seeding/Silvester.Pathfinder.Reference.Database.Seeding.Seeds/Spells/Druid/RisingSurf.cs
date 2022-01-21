using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class RisingSurf : Template
    {
        public static readonly Guid ID = Guid.Parse("b7e9d482-d700-4207-9d06-74afc6121777");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Rising Surf",
                Level = 1,
                Range = "30 feet.",
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                ClassId = Classes.Instances.Druid.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Conjuration.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6faa0cf3-132c-44dc-ac9a-df928a7e3d06"), Type = TextBlockType.Text, Text = "You create a wave of water that you ride, banking around obstacles and surfing to higher ground. You move up to 35 feet, raising yourself up to 5 feet above the ground. (You can avoid many types of difficult terrain in this way.) You must end your movement on an unoccupied space where you have solid footing. This movement isn't a Stride, but you measure the distance in a similar way, and it still triggers reactions caused by movement. You can't transport anyone else with you." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("3f85c832-768a-4a34-85d5-8592dc4ca331"),
                Level = "+2",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("3fd81f50-eb0c-476a-847e-13af64d7898d"), Type = TextBlockType.Text, Text = "Increase the distance you move by 5 feet and the maximum height traveled above the ground by 5 feet." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("51f38398-2c01-40b1-ba0c-5293d6edb768"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("86d8b2b8-da4b-4325-8c91-901deaf9ad36"), Traits.Instances.Conjuration.ID);
            builder.Add(Guid.Parse("b8bf2776-19ef-434a-8404-8095119e83a6"), Traits.Instances.Druid.ID);
            builder.Add(Guid.Parse("15604ab8-601f-4372-a42d-292839e2b8e4"), Traits.Instances.Move.ID);
            builder.Add(Guid.Parse("d3311abf-d90b-4925-af2a-94cdfc114864"), Traits.Instances.Water.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("68f3de3c-4797-4db1-aaf5-2aaa7c73a082"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 201
            };
        }
    }
}
