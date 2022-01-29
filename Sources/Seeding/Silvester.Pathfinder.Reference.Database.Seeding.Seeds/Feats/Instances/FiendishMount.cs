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
    public class FiendishMount : Template
    {
        public static readonly Guid ID = Guid.Parse("7a31517d-6267-458c-9733-89d4385bbf4b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Fiendish Mount",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1e9f665b-9902-469f-bfe4-4b6313c30cfd"), Type = TextBlockType.Text, Text = $"Your steed ally manifests a suite of powerful and sinister gifts granted to it by your deity. It gains darkvision, its maximum Hit Points increase by 40, and it gains weakness 10 to good damage." };
            yield return new TextBlock { Id = Guid.Parse("18807d8c-1a53-40ad-8d1a-d024de98b62b"), Type = TextBlockType.Text, Text = $"Additionally, it grows wings appropriate for a servitor of your deity (such as bat wings for a devil), granting it a fly Speed equal to its Speed. It gains the fiend trait and the trait appropriate to the type of servitor it has become (such as daemon, demon, or devil)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificDivineAlly(Guid.Parse("8bfc0927-0da5-4704-9977-b9072faba1ee"), DivineAllies.Instances.Steed.ID);
            builder.HaveSpecificTenet(Guid.Parse("ede1d933-ce57-476b-bb94-5ecf19e7e27d"), Tenets.Instances.Evil.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Champion.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7db2932e-4788-4ba1-a6b7-5542bdd73fd2"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
