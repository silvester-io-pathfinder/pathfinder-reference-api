using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AHomeInEveryPort : Template
    {
        public static readonly Guid ID = Guid.Parse("bd077b9b-20e8-492e-bb00-3e984a8ebc05");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "A Home in Every Port",
                Level = 11,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("237539a7-f402-4a3a-a9bd-7d1c5db7ed8b"), Type = TextBlockType.Text, Text = "You have a reputation in towns and villages you’ve visited, and residents are always willing to open their doors to you. When in a town or village, during downtime, you can spend 8 hours to locate a resident willing to provide lodging for you and up to six allies for up to 24 hours at no charge. The standard of living within the acquired lodging is comfortable, and square meals are provided at no cost. After 24 hours, you must pay standard prices for further lodging and meals or use this feat again to find a new resident willing to host you." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificStat(Guid.Parse("85985c4e-e60d-4f7f-8faa-19c31b841f22"), requiredStatValue: 16, Stats.Instances.Charisma.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("afd22c47-1606-4fa0-b18b-69cf9112416a"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
