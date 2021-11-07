using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class QuickenedCasting : Template
    {
        public static readonly Guid ID = Guid.Parse("9c96cf56-2b59-4074-8eb3-6555399cdfc9");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Quickened Casting",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("179abf0c-df2a-4865-9185-f249e9609d0b"), Type = TextBlockType.Text, Text = "In a mentally strenuous process, you modify your casting of a spell to take less time. If your next action is to cast a witch cantrip or a spell that is at least 2 levels lower than the highest-level witch spell slot you have, reduce the number of actions to cast it by 1 (minimum 1 action)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bd3247c8-bb76-4743-bcde-36c8ff91d45c"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
