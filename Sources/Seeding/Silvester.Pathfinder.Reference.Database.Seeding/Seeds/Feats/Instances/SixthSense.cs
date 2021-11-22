using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SixthSense : Template
    {
        public static readonly Guid ID = Guid.Parse("9e6d85fd-21c7-4371-ada2-2742f7ec8737");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Sixth Sense",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("13926e22-95f6-41bf-a99c-6b8b44ab4fa5"), Type = TextBlockType.Text, Text = "You can detect the lingering thoughts of spirits and similar entities with your psychic abilities. While you're exploring but not (action: Searching | Search), the GM rolls a secret check for you to find haunts that usually require (action: Searching | Search) as well as spirits, creatures on the Ethereal Plane, and beings made entirely of spiritual essence, such as celestials, fiends, and monitors." };
            yield return new TextBlock { Id = Guid.Parse("45a48281-ae1d-44a9-817d-0ff1fa3466cb"), Type = TextBlockType.Text, Text = "You can also potentially notice ethereal creatures and spirits inside solid objects, provided they're within 30 feet of you. This applies while (action: Searching | Search), while (action: Seeking | Seek), and on the automatic secret check from Sixth Sense. You can still notice spirits only on a successful check, and you can't see them if they're more than 5 feet inside an object." };
            yield return new TextBlock { Id = Guid.Parse("7b3f8af1-5eb3-4dd1-b83b-44500098564a"), Type = TextBlockType.Text, Text = "When you notice a creature with your Sixth Sense, you also learn its location, making it hidden to you if it had been undetected." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2d862e5e-1b15-4a60-a36a-fd6710cf4568"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
