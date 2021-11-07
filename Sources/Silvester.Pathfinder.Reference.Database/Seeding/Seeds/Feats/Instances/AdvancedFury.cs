using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AdvancedFury : Template
    {
        public static readonly Guid ID = Guid.Parse("2ccb8ca7-19c8-42a6-be57-7d18fec293fc");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Advanced Fury",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = true,
                Special = "You can select this feat more than once. Each time you select it, you gain another barbarian feat.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c0ed3708-6fa4-449f-a5f3-e22ee42aa0c4"), Type = TextBlockType.Text, Text = "You gain one barbarian feat. For the purpose of meeting its prerequisites, your barbarian level is equal to half your character level." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("3d973dc7-49cf-4030-86ce-2809b9592f57"), Feats.Instances.BasicFury.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("81444765-7490-4e5b-aacb-aafdea9362f8"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
