using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BecomeThought : Template
    {
        public static readonly Guid ID = Guid.Parse("d5476144-e9f0-48d1-9ff6-b26a989a88b3");

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
            yield return new TextBlock { Id = Guid.Parse("f0edd693-1692-4b55-9d51-0f526704d54f"), Type = TextBlockType.Text, Text = "You shed some of your material form, becoming a being of pure thought. You gain resistance 10 to physical damage but weakness 5 to mental damage and weakness 10 to any effect that deals damage specifically by targeting the spirit, such as (spell: spirit blast). Once per century, when you die, you automatically return to life as long as one living sentient creature on your plane remembers you; the memories allow you to reconstruct yourself from their thoughts." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("28e4003d-5a87-4d07-a70d-e53142281042"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
