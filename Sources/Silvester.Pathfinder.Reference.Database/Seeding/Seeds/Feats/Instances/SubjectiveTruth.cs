using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SubjectiveTruth : Template
    {
        public static readonly Guid ID = Guid.Parse("dc21dc2c-c217-4dd7-9ce1-31d01c0023ce");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Subjective Truth",
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
            yield return new TextBlock { Id = Guid.Parse("1e20fe5f-4e09-4f93-8cfe-5bffda300d20"), Type = TextBlockType.Text, Text = "Your disparate identities allow you to defeat magic that detects lies. As long as what you say is true from the point of view of your current identity, you can say it even under effects like (spell: zone of truth) that force you to speak the truth." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("32fc99ac-947b-45ac-8abd-5321e7fc4350"), Proficiencies.Instances.Master.ID, Skills.Instances.Deception.ID);
            builder.HaveSpecificFeat(Guid.Parse("0cd09de7-8043-49db-904f-ee81af4bcd81"), Feats.Instances.VigilanteDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2ec79c5b-d20d-49bb-a638-3dc19430806d"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
