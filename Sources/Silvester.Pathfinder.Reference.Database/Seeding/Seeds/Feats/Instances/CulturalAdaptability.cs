using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CulturalAdaptability : Template
    {
        public static readonly Guid ID = Guid.Parse("3681fb4d-28b1-4618-8bc6-ff10daa72dd7");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Cultural Adaptability",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8c7ef814-01f2-4e26-be03-7b1315da8805"), Type = TextBlockType.Text, Text = "During your adventures, you’ve honed your ability to adapt to the culture of the predominant ancestry around you. You gain the (Feat: Adopted Ancestry) general feat, and you also gain one 1st-level ancestry feat from the ancestry you chose for the (Feat: Adopted Ancestry) feat." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("aa3b4190-1aa8-4c19-a29d-a8f89c14ea74"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
