using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WildbornMagic : Template
    {
        public static readonly Guid ID = Guid.Parse("9c9db4cb-b283-4be4-a69d-a75e461b1868");

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
            yield return new TextBlock { Id = Guid.Parse("5773af2b-378f-45dc-9d20-1e4d2a72122a"), Type = TextBlockType.Text, Text = $"~ Access: Mualijae ethnicity" };
            yield return new TextBlock { Id = Guid.Parse("bb73a9ab-17dd-4365-a58d-df0de130a671"), Type = TextBlockType.Text, Text = $"You have learned to access the old magic of wild places. Choose one cantrip from the primal spell list. You can cast this cantrip as an innate primal spell at will. A cantrip is heightened to a spell level equal to half your level rounded up." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b4afba99-5390-4bbe-a746-a441e3e87a6e"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
