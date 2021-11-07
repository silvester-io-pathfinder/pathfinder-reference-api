using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ShareThoughts : Template
    {
        public static readonly Guid ID = Guid.Parse("9cfd868b-31ba-488b-8383-2170f5a9dbc7");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Share Thoughts",
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
            yield return new TextBlock { Id = Guid.Parse("7b519272-808f-46b5-a006-2649b9c19513"), Type = TextBlockType.Text, Text = "~ Access: Mualijae, Ilverani, or Vourinoi ethnicity" };
            yield return new TextBlock { Id = Guid.Parse("0c9679c7-d0c9-4a60-84a3-5a76920538a9"), Type = TextBlockType.Text, Text = "You have an uncanny knack of communicating with other elves without speaking, though this habit that is often uncomfortable to observers. You can cast (spell: mindlink) as an innate occult spell once per day, but you can target only other elves or half-elves." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d95bd7eb-6c44-49b1-8ca2-f3d3513ee8d6"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
