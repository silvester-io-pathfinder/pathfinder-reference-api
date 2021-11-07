using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Skitter : Template
    {
        public static readonly Guid ID = Guid.Parse("6d375a59-3838-4c97-8657-7960586ff6b1");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Skitter",
                Level = 3,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("378b5a6a-678e-4e7b-ad9c-b96fc784b6ef"), Type = TextBlockType.Text, Text = "You can scoot swiftly across the ground. You can (action: Crawl) up to half your Speed." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificStat(Guid.Parse("c725ffce-abcd-489f-8d80-10143724f117"), requiredStatValue: 16, Stats.Instances.Dexterity.ID);
            builder.HaveSpecificFeat(Guid.Parse("474f74c1-c3f6-428c-a05b-0281e9db9ef6"), Feats.Instances.Fleet.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1620f9cf-76ec-4575-8e4b-5bb1eb7ab4f7"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
