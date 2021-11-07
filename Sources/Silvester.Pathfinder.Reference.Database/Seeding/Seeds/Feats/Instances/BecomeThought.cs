using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BecomeThought : Template
    {
        public static readonly Guid ID = Guid.Parse("71b3d0dd-528d-4700-a26f-bb87bdd3654f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Become Thought",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("86cf3246-e2f0-48d8-b5ee-8883c6ddc5ee"), Type = TextBlockType.Text, Text = "You shed some of your material form, becoming a being of pure thought. You gain resistance 10 to physical damage but weakness 5 to mental damage and weakness 10 to any effect that deals damage specifically by targeting the spirit, such as (spell: spirit blast). Once per century, when you die, you automatically return to life as long as one living sentient creature on your plane remembers you; the memories allow you to reconstruct yourself from their thoughts." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c5c60280-26b4-491c-ad71-7f367f6e737d"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
