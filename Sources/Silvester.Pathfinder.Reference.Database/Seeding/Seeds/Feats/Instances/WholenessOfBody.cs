using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WholenessOfBody : Template
    {
        public static readonly Guid ID = Guid.Parse("4015b1eb-c984-471d-810f-08aced83ee48");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Wholeness of Body",
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
            yield return new TextBlock { Id = Guid.Parse("e14b897b-981c-4726-9dfb-8113a7906061"), Type = TextBlockType.Text, Text = "You can restore your health by tapping into your ki. You gain the (spell: wholeness of body) ki spell. Increase the number of Focus Points in your focus pool by 1." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveAnyKiSpells(Guid.Parse("43cb49d7-6433-4691-9f2e-7719a4a0199c"));
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("41f0aac5-f69d-4224-be1d-92d474f51cb5"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
