using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GraspingReach : Template
    {
        public static readonly Guid ID = Guid.Parse("559fa73d-0457-4d1e-a76d-95d3f62b1558");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Grasping Reach",
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
            yield return new TextBlock { Id = Guid.Parse("32361c43-1197-47a6-8fde-b45a0e10695b"), Type = TextBlockType.Text, Text = "You can extend a tangle of vines or tendrils to support your arms and extend your reach. When you wield a melee weapon that requires two hands, doesn’t have reach, and deals at least 1d6 damage, you can change between a typical two-handed grip and an extended two-handed grasp using an (action: Interact) action. Weapons wielded in your extended grasp gain reach of 10 feet. This grasp is less stable and powerful than a typical grip, reducing the weapon’s damage die by 1 step." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fda1e925-c658-4b9b-9b70-91d3f4d187bb"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
