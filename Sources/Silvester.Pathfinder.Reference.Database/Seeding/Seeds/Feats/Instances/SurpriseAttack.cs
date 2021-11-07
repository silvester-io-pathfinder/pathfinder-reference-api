using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SurpriseAttack : Template
    {
        public static readonly Guid ID = Guid.Parse("c6698ab2-dabd-4447-85da-892365caa626");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Surprise Attack",
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
            yield return new TextBlock { Id = Guid.Parse("033b6e0e-9299-4475-875c-a0eae2d220a3"), Type = TextBlockType.Text, Text = "You act before foes can react. On the first round of combat, if you roll Deception or Stealth for initiative, creatures that haven’t acted are flat-footed to you." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("7c67ee8b-d005-45cb-876e-5c5a75d2fe6f"), Feats.Instances.AssasinDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d73a5d79-b05a-4c6a-ada6-81534b2668d0"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
