using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FinishingPrecision : Template
    {
        public static readonly Guid ID = Guid.Parse("17ba5c02-c444-4aaa-88a6-d341cbc752c5");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Finishing Precision",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c585a1d4-72f2-464e-afea-ecc366488594"), Type = TextBlockType.Text, Text = $"You've learned how to land daring blows when you have panache. You gain the precise strike class feature but you deal 1 additional damage on a hit and 1d6 damage on a finisher. This damage doesn't increase as you gain levels. In addition, you gain the {ToMarkdownLink<Models.Entities.Feat>("Basic Finisher", Feats.Instances.BasicFinisher.ID)} action." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("40e0d985-90ed-4202-8ca3-ea4425574f33"), Feats.Instances.SwashbucklerDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("116eea71-2389-4370-b33e-894212cb71fc"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
