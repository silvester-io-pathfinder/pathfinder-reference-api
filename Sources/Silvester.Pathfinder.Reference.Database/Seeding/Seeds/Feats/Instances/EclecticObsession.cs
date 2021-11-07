using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EclecticObsession : Template
    {
        public static readonly Guid ID = Guid.Parse("0f572680-4f39-49a7-aa51-b74b79d6b420");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Eclectic Obsession",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9dd9b26e-7855-4120-884f-dd524b64abc0"), Type = TextBlockType.Text, Text = "Your desire for stimulation has led you from one pursuit to another and granted you a smattering of expertise with myriad crafts and professions." };
            yield return new TextBlock { Id = Guid.Parse("ea7e17b3-062e-47fa-aa79-a70b2edfe7c4"), Type = TextBlockType.Text, Text = "You reflect on snippets you’ve learned to temporarily become trained in one Lore skill of your choice. This proficiency lasts for 10 minutes or until you critically fail a check with that skill. Since this training is temporary, you can’t use it as a prerequisite for a permanent character option like a feat or a skill increase." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("981fd87b-184b-46c4-83f9-8c72990b272d"), Feats.Instances.GnomeObsession.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3545c240-9e94-447c-a87b-b12311822acc"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
