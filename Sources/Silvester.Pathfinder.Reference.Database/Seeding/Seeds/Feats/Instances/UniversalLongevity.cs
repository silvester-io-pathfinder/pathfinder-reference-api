using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class UniversalLongevity : Template
    {
        public static readonly Guid ID = Guid.Parse("a29f9acb-3f79-405e-a83f-2b32c68a50cf");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Universal Longevity",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b9ded671-3a41-4a0b-a21f-682aeaab22b4"), Type = TextBlockType.Text, Text = "You’ve perfected your ability to keep up with all the skills you’ve learned over your long life, so you’re almost never truly untrained at a skill. You reflect on your life experiences, changing the skills you selected with (Feat: Ancestral Longevity) and (Feat: Expert Longevity)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("077507d9-ceeb-492b-b9b6-df656d289545"), Feats.Instances.ExpertLongevity.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5fc5f389-6fda-46e6-aa3e-e60b300f962f"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
