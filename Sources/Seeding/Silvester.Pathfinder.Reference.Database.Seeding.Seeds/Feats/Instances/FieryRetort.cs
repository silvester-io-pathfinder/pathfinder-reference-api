using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FieryRetort : Template
    {
        public static readonly Guid ID = Guid.Parse("e207c9bd-3d54-48d4-8598-86192283236c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Fiery Retort",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "An opponent adjacent to you hits you with a melee weapon or a melee unarmed attack.",
                Frequency = "once per minute"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5a9d2b2f-bfe7-44e7-84d6-0af48deb9101"), Type = TextBlockType.Text, Text = $"Ignoring your pain, you sear your attacker with a wave of flame. The triggering opponent takes fire damage equal to your level." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificDruidicOrder(Guid.Parse("f3adea84-8a72-4ed9-9213-57eb04c24209"), DruidicOrders.Instances.Flame.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("7079efe0-f2e2-4c46-8668-ef9a587b4f01"), Traits.Instances.Druid.ID);
            builder.Add(Guid.Parse("d3de4d32-43f3-49b3-96e1-71b75c500a04"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("ad7fd89b-7b04-49f2-a6c0-aad60078c013"), Traits.Instances.Fire.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a79113d9-e375-4519-b1a3-e63e57aa2013"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
