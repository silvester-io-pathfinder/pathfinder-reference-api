using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LiberatingStride : Template
    {
        public static readonly Guid ID = Guid.Parse("6c9e1c61-2b7c-4633-afa3-f098b91d5cdd");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Liberating Stride",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("44ab93b7-1cb1-428e-826d-ec488c134bbb"), Type = TextBlockType.Text, Text = $"Instead of you taking a {ToMarkdownLink<Models.Entities.Action>("Step", Actions.Instances.Step.ID)} at the end of your {ToMarkdownLink<Models.Entities.Feat>("Liberating Step", Feats.Instances.LiberatingStep.ID)}, the triggering ally can {ToMarkdownLink<Models.Entities.Action>("Stride", Actions.Instances.Stride.ID)} up to half their Speed. Even if you have exalt, only the triggering ally gains this benefit." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificCause(Guid.Parse("34e34db3-e137-47ad-b91b-b9438b9d8166"), Causes.Instances.Liberator.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b5dc2e79-db6e-455a-a706-3caa885c73dd"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
