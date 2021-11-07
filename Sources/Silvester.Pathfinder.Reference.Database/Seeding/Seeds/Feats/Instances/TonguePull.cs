using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TonguePull : Template
    {
        public static readonly Guid ID = Guid.Parse("3d30651c-6c69-46f7-8e3b-7ecfff7183ef");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Tongue Pull",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e36def27-4820-47c4-9d69-f8a84f3f0224"), Type = TextBlockType.Text, Text = "The cave gecko snaps out its tongue, attempting to pull a foe within 10 feet toward it. The gecko attempts an Athletics check against the foe’s Fortitude DC. On a success, the cave gecko pulls the foe next to it. This movement is forced movement. On a critical success, the foe is also grabbed until the beginning of your next turn." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("90cca6a5-aad7-4c56-b644-8df0f861c158"),
                SourceId = Sources.Instances.ExtinctionCurse.ID,
                Page = -1
            };
        }
    }
}
