using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Beastbrood : Template
    {
        public static readonly Guid ID = Guid.Parse("d86c4ecf-2ea1-45df-8f02-6348d7383cba");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Beastbrood",
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
            yield return new TextBlock { Id = Guid.Parse("d56667a3-1cdb-483b-96c4-0ee0969af22c"), Type = TextBlockType.Text, Text = "One of your ancestors was a rakshasa, the corrupt and aristocratic reincarnated souls that call Golarion home. You have some dim echo of your ancestor’s memories— enough to play the role of noble as needed, no matter your origins. You’re trained in Society. If you’re already trained in Society (from your background or class, for example), you instead become trained in a skill of your choice. You also gain the (feat: Courtly Graces) skill feat." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8a5ff92a-46f3-498d-9180-02559c7fa2a8"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
