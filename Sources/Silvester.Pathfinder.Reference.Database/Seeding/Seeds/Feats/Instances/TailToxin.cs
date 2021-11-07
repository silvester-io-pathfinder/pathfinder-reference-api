using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TailToxin : Template
    {
        public static readonly Guid ID = Guid.Parse("7dcc8ae7-abf9-4bbd-a6fd-bd23540d28df");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Tail Toxin",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5d176a79-e244-44cf-8c84-1efa328cfdea"), Type = TextBlockType.Text, Text = "You apply your tail&#39;s venom to a piercing or slashing weapon. If your next (action: Strike) with that weapon before the end of your next turn hits and deals damage, you deal persistent poison damage equal to your level to the target." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("31028004-56f3-4261-beb4-c06a5974f923"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
