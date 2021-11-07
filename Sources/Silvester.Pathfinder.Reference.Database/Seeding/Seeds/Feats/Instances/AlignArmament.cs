using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AlignArmament : Template
    {
        public static readonly Guid ID = Guid.Parse("67de64c5-ac85-4982-a0ab-74a985202bc5");

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
            yield return new TextBlock { Id = Guid.Parse("c82b4451-bf02-458e-a9a9-0750e04c25c9"), Type = TextBlockType.Text, Text = "You bring a weapon into metaphysical concordance with your deity’s beliefs. When you select this feat, choose chaotic, evil, good, or lawful. Your choice must match one of your deity’s alignment components. This action has the trait corresponding to the chosen alignment component." };
            yield return new TextBlock { Id = Guid.Parse("9402b5f4-3ffc-48fe-8acc-d6689cd38468"), Type = TextBlockType.Text, Text = "When you use this action, you touch a weapon. For 1 round, that weapon deals an additional 1d6 damage of the chosen type to creatures of the opposed alignment. For example, if you chose good, the weapon would deal an extra 1d6 good damage to evil creatures. If you Align an Armament again, any previously aligned armament loses its additional damage." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8b658a12-8bd1-419f-80d8-7fcab81664b0"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
