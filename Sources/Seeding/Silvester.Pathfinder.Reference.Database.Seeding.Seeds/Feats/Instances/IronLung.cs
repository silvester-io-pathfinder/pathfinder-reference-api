using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class IronLung : Template
    {
        public static readonly Guid ID = Guid.Parse("8e83c83f-79e4-4d71-a37a-cf1b6cb71f44");

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
            yield return new TextBlock { Id = Guid.Parse("6dbcf317-2497-4a22-8fc8-574089c32cf8"), Type = TextBlockType.Text, Text = $"Your lungs are infused with the resilience of iron. Treat the result of your save against an {ToMarkdownLink<Models.Entities.Trait>("inhaled", Traits.Instances.Inhaled.ID)} poison as one degree of success better than you rolled. Additionally, you gain the {ToMarkdownLink<Models.Entities.Feat>("Exhale Poison", Feats.Instances.ExhalePoison.ID)} ability." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("1c28528f-72e9-490b-acf1-0e6e267057ed"), Feats.Instances.GolemGrafterDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("05db427d-b4c4-4ade-a2cd-cde02340336d"),
                SourceId = Sources.Instances.ExtinctionCurse.ID,
                Page = -1
            };
        }
    }
}
