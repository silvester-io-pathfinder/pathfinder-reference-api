using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AncestralLongevity : Template
    {
        public static readonly Guid ID = Guid.Parse("9000c755-2272-4318-af08-b517ed6574c2");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Ancestral Longevity",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("512a2bf1-bda1-49a7-b2fa-537c92f043df"), Type = TextBlockType.Text, Text = "You have accumulated a vast array of lived knowledge over the years. During your daily preparations, you can reflect upon your life experiences to gain the trained proficiency rank in one skill of your choice. This proficiency lasts until you prepare again. Since this proficiency is temporary, you can’t use it as a prerequisite for a skill increase or a permanent character option like a feat." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificAge(Guid.Parse("c8d4791f-d50e-43de-8e98-01d08ac84418"), Comparators.GreaterThanOrEqualTo, years: 100);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a865743b-15e6-4267-9a4a-617a69cc4808"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
