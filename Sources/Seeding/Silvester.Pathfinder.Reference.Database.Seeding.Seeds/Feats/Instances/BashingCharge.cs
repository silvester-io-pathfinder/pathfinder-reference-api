using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BashingCharge : Template
    {
        public static readonly Guid ID = Guid.Parse("f2d83740-2e74-44df-9542-058700baf7af");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Bashing Charge",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9553be44-1730-4b95-842e-e54f6886b7ac"), Type = TextBlockType.Text, Text = $"You smash, bust, and charge through solid obstacles without hesitation. {ToMarkdownLink<Models.Entities.Action>("Stride", Actions.Instances.Stride.ID)} twice. Once during your movement, if your movement passes through or ends adjacent to a door, window, fence, wall, or similar obstacle, you can attempt an Athletics check to {ToMarkdownLink<Models.Entities.SkillAction>("Force Open", SkillActions.Instances.ForceOpen.ID)} the obstacle with a +1 circumstance bonus to the roll; on a failure, your movement ends at that obstacle." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("6b781437-579e-453b-9e2d-f8f25a1e0735"), Proficiencies.Instances.Trained.ID, Skills.Instances.Athletics.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0ebe51b7-d09a-4057-ae8b-150c19f56b42"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
