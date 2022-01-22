using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GiantsStature : Template
    {
        public static readonly Guid ID = Guid.Parse("6fe29c74-d328-40ac-9c63-e732dce4332c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Giant's Stature",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7b21fd1a-03eb-4316-a779-3e47b9630433"), Type = TextBlockType.Text, Text = $"You grow to incredible size. You become Large, increasing your reach by 5 feet and gaining the clumsy 1 condition until you stop raging. Your equipment grows with you." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificInstinct(Guid.Parse("62312b27-a6ba-460d-97c3-16841dba060d"), Instincts.Instances.GiantInstinct.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bee9e741-813f-47d2-bb6b-ab72253e5011"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
