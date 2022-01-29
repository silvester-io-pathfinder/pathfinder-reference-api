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
    public class AcuteScent : Template
    {
        public static readonly Guid ID = Guid.Parse("5f0c44d4-1852-4b1c-87f7-2edfbe73f595");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Acute Scent",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6e3ceb37-f3e4-46a3-8723-2cc810e2fc1b"), Type = TextBlockType.Text, Text = $"When you {ToMarkdownLink<Models.Entities.Feat>("Rage", Feats.Instances.Rage.ID)}, your sense of smell improves. You gain imprecise scent with a range of 30 feet." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("83c6ad6f-7e2d-4bce-af13-cfebeebd6b8b"), or => 
            {
                or.HaveSpecificFeat(Guid.Parse("fa5ce1d3-a738-4fac-b249-8949511424a5"), Feats.Instances.AcuteVision.ID);
                or.HaveSpecificSense(Guid.Parse("9bb2263d-0342-468f-bd8c-66a4e6906521"), Senses.Instances.Darkvision.ID);
            });
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("444a184f-28a6-4a47-be32-b888712ba80f"), Traits.Instances.Barbarian.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e66dc4a5-4719-41a6-a3eb-56e92f63f468"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
