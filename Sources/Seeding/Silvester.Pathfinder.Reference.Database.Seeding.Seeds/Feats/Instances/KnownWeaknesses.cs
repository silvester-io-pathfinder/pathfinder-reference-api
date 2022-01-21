using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class KnownWeaknesses : Template
    {
        public static readonly Guid ID = Guid.Parse("d290d6da-0e6a-41ba-92e7-33da06e54979");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Known Weaknesses",
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
            yield return new TextBlock { Id = Guid.Parse("f18a92a7-f049-41ce-969e-43e06c11c83a"), Type = TextBlockType.Text, Text = "Whenever you (feat: Devise a Stratagem), you can also attempt a check to (action: Recall Knowledge) as part of that action. If you critically succeed at the (action: Recall Knowledge) check, you notice a weakness and gain a +1 circumstance bonus to your attack roll from (feat: Devise a Stratagem). If you immediately convey this information to your allies as part of the check, each ally gains a +1 circumstance bonus to their next attack roll against the subject, as long as their attack is made before the beginning of your next turn." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cbd7fd23-9ce9-4fe5-8dac-e6156e7c7aad"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
