using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GracefulLeaper : Template
    {
        public static readonly Guid ID = Guid.Parse("89e90bbe-5789-405c-97be-37e2848024ba");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Graceful Leaper",
                Level = 7,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1988f918-b17d-4728-a7b2-01fedb6f3735"), Type = TextBlockType.Text, Text = "Mass and muscle are meaningless when you leap; only grace and balance matter. You can roll an Acrobatics check instead of an Athletics check when making a (action: High Jump) or (action: Long Jump)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("e06d7757-1a36-4c67-a8e9-c6a7239ead22"), Feats.Instances.AcrobatDedication.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("e707ea77-ad79-43c4-91ef-d47e9b732259"), Proficiencies.Instances.Master.ID, Skills.Instances.Acrobatics.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("63d058c4-2679-49f5-8e31-f2232e857351"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
