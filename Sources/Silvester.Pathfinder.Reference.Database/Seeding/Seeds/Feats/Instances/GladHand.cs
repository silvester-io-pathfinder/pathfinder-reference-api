using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GladHand : Template
    {
        public static readonly Guid ID = Guid.Parse("342ebaa3-3d4c-41bd-b42a-dc0d71bb20dc");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Glad-Hand",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("fce784f8-2a17-4fc2-b5db-9b86cfc627b9"), Type = TextBlockType.Text, Text = "First impressions are your strong suit. When you meet someone in a casual or social situation, you can immediately attempt a Diplomacy check to (action: Make an Impression) on that creature rather than needing to converse for 1 minute. You take a -5 penalty to the check. If you fail or critically fail, you can engage in 1 minute of conversation and attempt a new check at the end of that time rather than accepting the failure or critical failure result." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("7146f9ee-570b-440a-8be1-f46162058b15"), Proficiencies.Instances.Expert.ID, Skills.Instances.Diplomacy.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("79a04c9b-77af-4ddc-bc39-4897593b2997"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
