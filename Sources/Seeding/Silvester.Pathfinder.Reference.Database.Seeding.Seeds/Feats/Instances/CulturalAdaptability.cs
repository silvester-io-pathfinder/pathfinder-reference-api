using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CulturalAdaptability : Template
    {
        public static readonly Guid ID = Guid.Parse("11225e42-7fdd-4a15-8618-66a644db6732");

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
            yield return new TextBlock { Id = Guid.Parse("1d92a278-4924-47b1-9c79-f531c557a48f"), Type = TextBlockType.Text, Text = $"During your adventures, you've honed your ability to adapt to the culture of the predominant ancestry around you. You gain the {ToMarkdownLink<Models.Entities.Feat>("Adopted Ancestry", Feats.Instances.AdoptedAncestry.ID)} general feat, and you also gain one 1st-level ancestry feat from the ancestry you chose for the {ToMarkdownLink<Models.Entities.Feat>("Adopted Ancestry", Feats.Instances.AdoptedAncestry.ID)} feat." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cc9e8641-40ae-4a99-b556-8fca6fa617e2"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
