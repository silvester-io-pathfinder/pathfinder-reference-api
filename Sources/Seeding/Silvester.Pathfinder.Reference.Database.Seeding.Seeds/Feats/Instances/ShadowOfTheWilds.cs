using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ShadowOfTheWilds : Template
    {
        public static readonly Guid ID = Guid.Parse("5a1bb2ec-b23e-48f6-9e44-527f6773c880");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Shadow of the Wilds",
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
            yield return new TextBlock { Id = Guid.Parse("a62a1388-460f-419d-96ea-61e468e95a1f"), Type = TextBlockType.Text, Text = $"It's difficult to notice your passage through wild areas. As long as you're not in an urban environment, you're always considered to be {ToMarkdownLink<Models.Entities.SkillAction>("Covering Tracks", SkillActions.Instances.CoverTracks.ID)}, even if you chose a different activity in exploration mode." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("938b3183-75b3-4bd1-a672-21b9bddeace0"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
