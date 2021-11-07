using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AlignArmament : Template
    {
        public static readonly Guid ID = Guid.Parse("9f44007a-08f7-434d-a2cd-ef2cccf76d0e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Align Armament",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = true,
                Special = "You can select this feat a second time, choosing your deity's other alignment component. When you Align an Armament, you can choose either alignment component.",
                Trigger = null,
                Frequency = "once per round"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("acca407a-d696-4c49-9705-2f7c319670bc"), Type = TextBlockType.Text, Text = "You bring a weapon into metaphysical concordance with your deity’s beliefs. When you select this feat, choose chaotic, evil, good, or lawful. Your choice must match one of your deity’s alignment components. This action has the trait corresponding to the chosen alignment component." };
            yield return new TextBlock { Id = Guid.Parse("66ed961a-5827-4ca5-9c6c-2f02a0040989"), Type = TextBlockType.Text, Text = "When you use this action, you touch a weapon. For 1 round, that weapon deals an additional 1d6 damage of the chosen type to creatures of the opposed alignment. For example, if you chose good, the weapon would deal an extra 1d6 good damage to evil creatures. If you Align an Armament again, any previously aligned armament loses its additional damage." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("87679645-d111-4ec4-8dd7-2a5eb6b6fc8a"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
