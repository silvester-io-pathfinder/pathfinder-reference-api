using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FancyMoves : Template
    {
        public static readonly Guid ID = Guid.Parse("2c7b724f-d68f-477e-b6d3-8abab8e95051");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Fancy Moves",
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
            yield return new TextBlock { Id = Guid.Parse("22e3cef5-2f2f-46e0-b11c-8ae37a6cf33d"), Type = TextBlockType.Text, Text = $"You show off your fighting style to discourage your foes. You can use Performance to {ToMarkdownLink<Models.Entities.SkillAction>("Demoralize", SkillActions.Instances.Demoralize.ID)}." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("f4291b31-cc9b-4a4f-8033-30020bdf3b4d"), Feats.Instances.GladiatorDedication.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("750c29f4-01bc-4ccd-9e4d-3b5d446a44c8"), Proficiencies.Instances.Expert.ID, Skills.Instances.Performance.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5db80ec6-8345-4e12-a428-b08c3345e992"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
