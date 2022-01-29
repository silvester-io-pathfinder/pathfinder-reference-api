using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RopeRunner : Template
    {
        public static readonly Guid ID = Guid.Parse("46211019-8335-47f7-8cc5-1b60df453118");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Rope Runner",
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
            yield return new TextBlock { Id = Guid.Parse("950addd0-7ca9-4efb-a086-83373648f95f"), Type = TextBlockType.Text, Text = $"You run and climb across ropes and rigging almost as easily as on the ground. You gain a climb Speed of 15 feet, but only on ship's rigging or similar ropes. Whenever you succeed at an Athletics check to {ToMarkdownLink<Models.Entities.SkillAction>("Climb", SkillActions.Instances.Climb.ID)} a rope or an Acrobatics check to {ToMarkdownLink<Models.Entities.SkillAction>("Balance", SkillActions.Instances.Balance.ID)} on a rope, you get a critical success instead. You aren't flat-footed while {ToMarkdownLink<Models.Entities.SkillAction>("Climbing", SkillActions.Instances.Climb.ID)} or {ToMarkdownLink<Models.Entities.SkillAction>("Balancing", SkillActions.Instances.Balance.ID)} on a rope." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("b1f6eca3-ef78-4f37-bdd6-7e8a2b4e8c62"), Proficiencies.Instances.Trained.ID, Skills.Instances.Acrobatics.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("0b646108-2b61-4e60-a873-220379e91352"), Proficiencies.Instances.Trained.ID, Skills.Instances.Athletics.ID);
            builder.HaveSpecificFeat(Guid.Parse("32559151-64c6-4da3-a995-ceb503666006"), Feats.Instances.PirateDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f8e62f91-a95a-401e-b820-bffe4a779397"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
