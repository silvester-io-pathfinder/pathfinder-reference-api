using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WildbornMagic : Template
    {
        public static readonly Guid ID = Guid.Parse("588ea451-b1eb-4315-823c-3975293e490d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Wildborn Magic",
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
            yield return new TextBlock { Id = Guid.Parse("737e6f36-3bb0-408c-9cf4-15b918b553bc"), Type = TextBlockType.Text, Text = "~ Access: Mualijae ethnicity" };
            yield return new TextBlock { Id = Guid.Parse("15d21cbf-1771-43ea-b921-4e256b36135d"), Type = TextBlockType.Text, Text = "You have learned to access the old magic of wild places. Choose one cantrip from the primal spell list. You can cast this cantrip as an innate primal spell at will. A cantrip is heightened to a spell level equal to half your level rounded up." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f00615d0-0c8a-4442-918b-65525c162d4e"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
