using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AvatarsAudience : Template
    {
        public static readonly Guid ID = Guid.Parse("9c1df1b7-bc68-4bc2-8550-f558f06934f6");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Avatar's Audience",
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
            yield return new TextBlock { Id = Guid.Parse("f46711fc-e95b-43f4-93d9-da6212fa353e"), Type = TextBlockType.Text, Text = "Your extensive service has made you a lesser herald of your deity, which affords you certain privileges." };
            yield return new TextBlock { Id = Guid.Parse("1d0be92f-0553-431a-8641-39df36c8f595"), Type = TextBlockType.Text, Text = "First, any creature you encounter knows instinctively that you speak for your deity." };
            yield return new TextBlock { Id = Guid.Parse("bce50da7-54ea-43bb-9c45-7b417d8dbbe6"), Type = TextBlockType.Text, Text = "Second, if you conduct the commune ritual to contact your deity, you don’t have to pay any cost and you automatically get a critical success." };
            yield return new TextBlock { Id = Guid.Parse("de47ca39-b325-49b7-bc08-dd780a9e9512"), Type = TextBlockType.Text, Text = "Third, once per day, you can cast (spell: plane shift) as a divine innate spell, but only to travel to the realm of your deity. When you cast it this way, its casting time is 1 minute, your religious symbol is a sufficient tuning fork for this spell, and you appear exactly where you want to be. If you’re in your deity’s realm due to this spell, you can return to the point you left when you cast it by spending a single action, which has the (trait: concentrate) and (trait: divine) traits." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("881272c1-4e9f-491a-bafa-bbac9d2619e7"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
