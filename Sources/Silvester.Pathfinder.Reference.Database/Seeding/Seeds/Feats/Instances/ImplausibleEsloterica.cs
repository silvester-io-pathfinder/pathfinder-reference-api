using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ImplausibleEsloterica : Template
    {
        public static readonly Guid ID = Guid.Parse("56987d85-601e-4f0f-850f-fa7b451cf672");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Implausible Esloterica",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7a4fd897-8306-41ed-960d-e43c526841c4"), Type = TextBlockType.Text, Text = "It seems impossible, but your esoterica are so eclectic and complete that you can keep pulling out exactly the item you need, even in far-flung locations. You can use (feat: Prescient Planner) even if you’ve already used it after purchasing goods, and you can use it as a single action instead of a 2-action activity, during which you (action: Interact) to draw the item." };
            yield return new TextBlock { Id = Guid.Parse("ccc5dab0-a596-4efa-987c-092ebfd3bdf2"), Type = TextBlockType.Text, Text = "In addition, five times per day, you can use (feat: Prescient Planner) to pull out a common consumable item of a level up to 6 levels lower than your level." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("21589ade-f20e-4e77-8847-484da7df761e"), Feats.Instances.HandyEsoterica.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0ecb2185-8fd0-4472-9932-f5756a012636"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
