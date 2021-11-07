using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WellspringGnomeOccult : Template
    {
        public static readonly Guid ID = Guid.Parse("9b4fb3b6-0725-459e-864c-28a4f0361fc6");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Wellspring Gnome - Occult",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("07a908c4-559f-4ab7-a2c4-e59be540ed38"), Type = TextBlockType.Text, Text = "You gain one cantrip from the occult spell list. You can cast this spell as an innate spell at will." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4785c758-57fb-4308-b8dd-2ba1ca90f342"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
