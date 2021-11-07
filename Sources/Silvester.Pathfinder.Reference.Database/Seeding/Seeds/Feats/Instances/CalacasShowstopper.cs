using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CalacasShowstopper : Template
    {
        public static readonly Guid ID = Guid.Parse("ec1632b8-04ed-4ff3-9a06-24761087d67d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Calaca's Showstopper",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("593bf0c8-87d6-4dc0-8e2d-a3ef9e486ced"), Type = TextBlockType.Text, Text = "You’ve spent many an evening learning songs and tales featuring calacas, death’s wandering minstrels. You dramatically unleash a stunning blast of sound by smashing an instrument you hold or belting out a discordant note. This has the effects of (spell: synaptic pulse), but the effect is (trait: auditory) rather than (trait: mental). The DC is either your class DC or spell DC, whichever is higher." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("a9d72a55-2a4a-4013-8f03-cbcdb1055328"), Proficiencies.Instances.Expert.ID, Skills.Instances.Performance.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("160c1dae-a875-4071-897e-d757f17a591b"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
