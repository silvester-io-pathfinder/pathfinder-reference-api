using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class IronLung : Template
    {
        public static readonly Guid ID = Guid.Parse("9046b10e-f012-456d-b0cd-3a03ad66f09f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Iron Lung",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("bd5682e2-26ae-4e12-b428-141225157cd1"), Type = TextBlockType.Text, Text = "Your lungs are infused with the resilience of iron. Treat the result of your save against an (trait: inhaled) poison as one degree of success better than you rolled. Additionally, you gain the (feat: Exhale Poison) ability." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("3808d6c7-4d3a-490b-90c5-e3fcc1033fd3"), Feats.Instances.GolemGrafterDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ba7c2923-dacc-4d73-bd7c-f1ba4b3d7dd2"),
                SourceId = Sources.Instances.ExtinctionCurse.ID,
                Page = -1
            };
        }
    }
}
