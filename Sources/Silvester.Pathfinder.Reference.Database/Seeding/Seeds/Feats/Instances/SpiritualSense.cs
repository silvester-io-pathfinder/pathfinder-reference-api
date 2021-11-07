using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SpiritualSense : Template
    {
        public static readonly Guid ID = Guid.Parse("fc1c523b-da9f-4ba1-97a4-55220342d129");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Spiritual Sense",
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
            yield return new TextBlock { Id = Guid.Parse("d9ae86dc-d9a7-49cc-9dd7-cbd8f8c6e1ce"), Type = TextBlockType.Text, Text = "You have a vague connection to the Ethereal Plane that enables you to notice spirits. While you’re exploring but not (action: Searching | Search), the GM rolls a secret check for you to find haunts that usually require (action: Searching | Search), as well as spirits, creatures on the Ethereal Plane, and beings made entirely of spiritual essence such as celestials, fiends, and monitors." };
            yield return new TextBlock { Id = Guid.Parse("37ae2bf0-1311-427f-b9dc-756ea2cc56f2"), Type = TextBlockType.Text, Text = "You can also potentially notice ethereal creatures and spirits inside solid objects, provided they are within 30 feet of you. This applies while (action: Searching | Search), while (action: Seeking | Seek), and on the automatic secret check you gain while exploring even if you aren’t (action: Searching | Search). You can still notice spirits only on a successful check, and you can’t see them if they’re more than 5 feet inside an object." };
            yield return new TextBlock { Id = Guid.Parse("31d0a3b7-544b-48b0-a0b9-e05a4e948a12"), Type = TextBlockType.Text, Text = "When you notice a creature with your Spiritual Sense, you also learn its location, making it hidden to you if it had been undetected." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8078b312-d5be-4a4e-806d-394665d39656"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
