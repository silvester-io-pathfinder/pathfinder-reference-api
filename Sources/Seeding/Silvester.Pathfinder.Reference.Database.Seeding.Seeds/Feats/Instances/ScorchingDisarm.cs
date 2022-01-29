using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ScorchingDisarm : Template
    {
        public static readonly Guid ID = Guid.Parse("569a5919-9ee1-4c3b-afb3-ee55f16fd736");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Scorching Disarm",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("cf5e5cf8-c7fa-4623-ba92-f70fe8cbe8b1"), Type = TextBlockType.Text, Text = $"You make a weapon unbearable to hold. Attempt an Athletics check to {ToMarkdownLink<Models.Entities.SkillAction>("Disarm", SkillActions.Instances.Disarm.ID)} a target creature. You don't need to have a hand free to make this {ToMarkdownLink<Models.Entities.SkillAction>("Disarm", SkillActions.Instances.Disarm.ID)} attempt. If the {ToMarkdownLink<Models.Entities.SkillAction>("Disarm", SkillActions.Instances.Disarm.ID)} attempt succeeds, the target takes 4d6 fire damage unless it drops the weapon, and on a critical success, it takes 4d6 fire damage and drops the weapon. If you're legendary in Athletics, this increases to 8d6 fire damage." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ef987db9-768e-4738-9490-884d0682765f"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
