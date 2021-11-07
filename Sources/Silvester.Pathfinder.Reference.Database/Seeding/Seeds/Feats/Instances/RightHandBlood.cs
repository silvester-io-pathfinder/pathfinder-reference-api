using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RightHandBlood : Template
    {
        public static readonly Guid ID = Guid.Parse("3d8c1fb5-7ee3-435a-8d2b-8ec361533076");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Right-Hand Blood",
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
            yield return new TextBlock { Id = Guid.Parse("6de43918-80ee-4ab0-b7cc-09d8ed0c4533"), Type = TextBlockType.Text, Text = "It’s said that the flesh of the right side of a hyena can heal diseases, but that of the left side is poisonous. You can take 1 damage to feed someone blood from your right side and (action: Administer First Aid) or take 2d8 damage to (action: Treat Disease) or (action: Treat Wounds); in either case, you don’t need (item: healer’s tools), and gain a +1 item bonus. Blood from your left side causes the check to critically fail automatically." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a6c2563a-92b5-49cf-9f35-e2a4bfc6c1b1"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
