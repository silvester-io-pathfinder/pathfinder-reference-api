using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FanesFourberie : Template
    {
        public static readonly Guid ID = Guid.Parse("a9eaec17-9f47-4f83-8c23-1f60c374ed19");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Fane's Fourberie",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("796bd02c-333c-4ebf-ad50-7873de40a332"), Type = TextBlockType.Text, Text = "~ Access: Member of the Pathfinder Society." };
            yield return new TextBlock { Id = Guid.Parse("f33cd352-0c24-4524-8958-dbfb1951e855"), Type = TextBlockType.Text, Text = "Stella Fane has perfected a technique for using (item: playing cards) as weapons that&#39;s one part sleight of hand and one part magic. When you enter this stance, choose whether to treat (item: playing cards) in your possession as (item: daggers | dagger) or (item: darts | dart); you can wield a playing card in all ways as the chosen weapon until the stance ends. As long as the majority of the deck remains in your possession, any cards that are lost or thrown can be found after 1 minute. Otherwise, the remaining cards are likely lost or destroyed." };
            yield return new TextBlock { Id = Guid.Parse("b03a6088-1044-4b47-8595-a24f66c2fede"), Type = TextBlockType.Text, Text = "A character who has this feat can enchant a single deck of playing cards as a magic weapon, etching fundamental and property runes directly onto the deck of cards." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8b746bd2-cefd-4d98-8cf6-3ec9ecb6b6e5"),
                SourceId = Sources.Instances.LostOmensSocietyGuide.ID,
                Page = -1
            };
        }
    }
}
