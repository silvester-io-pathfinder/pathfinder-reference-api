using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SixthSense : Template
    {
        public static readonly Guid ID = Guid.Parse("fbb41825-e114-4410-bac5-9b94803f3579");

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
            yield return new TextBlock { Id = Guid.Parse("2f21575c-213f-467c-aa34-90c190792d97"), Type = TextBlockType.Text, Text = "You can detect the lingering thoughts of spirits and similar entities with your psychic abilities. While you’re exploring but not (action: Searching | Search), the GM rolls a secret check for you to find haunts that usually require (action: Searching | Search) as well as spirits, creatures on the Ethereal Plane, and beings made entirely of spiritual essence, such as celestials, fiends, and monitors." };
            yield return new TextBlock { Id = Guid.Parse("c3011420-1571-47df-acb2-7a970098d106"), Type = TextBlockType.Text, Text = "You can also potentially notice ethereal creatures and spirits inside solid objects, provided they’re within 30 feet of you. This applies while (action: Searching | Search), while (action: Seeking | Seek), and on the automatic secret check from Sixth Sense. You can still notice spirits only on a successful check, and you can’t see them if they’re more than 5 feet inside an object." };
            yield return new TextBlock { Id = Guid.Parse("e0a8fd43-be1f-4274-99f2-c5f047eda23a"), Type = TextBlockType.Text, Text = "When you notice a creature with your Sixth Sense, you also learn its location, making it hidden to you if it had been undetected." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e87e8ca7-0b91-46ec-9984-67e40d22d71f"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
