using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class NoEvidence : Template
    {
        public static readonly Guid ID = Guid.Parse("be23df4d-e3c7-4da3-be7a-4739c099928b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "No Evidence",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("fe5f4bb3-26cc-4f12-82b0-26920b51176a"), Type = TextBlockType.Text, Text = $"You leave little sign when attempting to remain unseen. When you {ToMarkdownLink<Models.Entities.Activity>("Avoid Notice", Activities.Instances.AvoidNotice.ID)}, you also gain the benefits of {ToMarkdownLink<Models.Entities.SkillAction>("Cover Tracks", SkillActions.Instances.CoverTracks.ID)} unless you choose not to." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("995892bf-0c55-496b-8db9-0c55b46c93e7"), Proficiencies.Instances.Expert.ID, Skills.Instances.Survival.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0ceae8dd-d9a5-4617-9cc5-0dfcd22e5fd2"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
