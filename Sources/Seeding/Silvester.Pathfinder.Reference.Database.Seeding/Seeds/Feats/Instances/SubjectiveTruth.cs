using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SubjectiveTruth : Template
    {
        public static readonly Guid ID = Guid.Parse("abfcd24d-c3b1-4df6-9144-de190bcae9f7");

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
            yield return new TextBlock { Id = Guid.Parse("27f80434-6683-418a-a7a7-543bf7f08c43"), Type = TextBlockType.Text, Text = "Your disparate identities allow you to defeat magic that detects lies. As long as what you say is true from the point of view of your current identity, you can say it even under effects like (spell: zone of truth) that force you to speak the truth." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("0a774120-8fc3-430c-8ceb-f2a97a9bd2b8"), Proficiencies.Instances.Master.ID, Skills.Instances.Deception.ID);
            builder.HaveSpecificFeat(Guid.Parse("325be708-122d-4c61-9f69-c205c705f045"), Feats.Instances.VigilanteDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ae288419-3827-4428-9b1b-08861b1814f1"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
