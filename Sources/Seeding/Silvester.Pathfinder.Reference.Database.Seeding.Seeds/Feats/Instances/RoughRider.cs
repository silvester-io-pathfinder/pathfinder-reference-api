using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RoughRider : Template
    {
        public static readonly Guid ID = Guid.Parse("facbafec-42c4-498a-b4b1-55dd5e99b85a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Rough Rider",
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
            yield return new TextBlock { Id = Guid.Parse("1969af56-a7c9-4151-9c2a-db0d0db59dc4"), Type = TextBlockType.Text, Text = $"You are especially good at riding traditional goblin mounts. You gain the {ToMarkdownLink<Models.Entities.Feat>("Ride", Feats.Instances.Ride.ID)} feat, even if you don't meet the prerequisites. You gain a +1 circumstance bonus to Nature checks to use {ToMarkdownLink<Models.Entities.SkillAction>("Command an Animal", SkillActions.Instances.CommandAnAnimal.ID)} on a goblin dog or wolf mount. You can always select a wolf as your animal companion, even if you would usually select an animal companion with the mount special ability, such as for a champion's steed ally." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c21a6aa9-b766-47b3-97d4-3eeec4c68154"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
