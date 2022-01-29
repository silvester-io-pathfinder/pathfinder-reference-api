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
    public class HardenFlesh : Template
    {
        public static readonly Guid ID = Guid.Parse("59c5cb4b-d187-451c-8578-a0c43e45c714");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Harden Flesh",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("54e8f6e4-c085-486d-828c-3c5b956150f8"), Type = TextBlockType.Text, Text = $"You fortify your skin with minerals drawn from earth and stone. You gain resistance 3 to physical damage, except adamantine, until the beginning of your next turn. At 12th level, and every 4 levels thereafter, the resistance increases by 1, to a maximum of resistance 6 at 20th level." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificDruidicOrder(Guid.Parse("16fd943c-59ee-415a-996b-444b7da4a041"), DruidicOrders.Instances.Stone.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("1e0e2b1f-fe58-465a-8deb-e6cfedccd0d6"), Traits.Instances.Druid.ID);
            builder.Add(Guid.Parse("b284ab38-4300-4aaa-8501-fd40770dabee"), Traits.Instances.Earth.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("28d7d39e-bd55-4fc7-a404-7e8a4f67720f"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
