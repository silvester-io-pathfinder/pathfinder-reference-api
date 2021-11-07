using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BlastTackle : Template
    {
        public static readonly Guid ID = Guid.Parse("e327cfab-5153-4839-b413-a168779e5762");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Blast Tackle",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("14ee92fb-8539-4e1b-9ac0-b8b98ddff47c"), Type = TextBlockType.Text, Text = "You throw yourself at an enemy, bracing your weapon against it and pulling it close before releasing a destructive shot. Attempt to (action: Grapple); if you’re wielding your weapon in both hands, you (action: Release) one hand to do so. If your (action: Grapple) succeeds, you can immediately (action: Strike) the target of the (action: Grapple) with the required weapon, even if it’s a two-handed weapon you’re holding in one hand. This (action: Strike) deals an additional 3d6 precision damage." };
            yield return new TextBlock { Id = Guid.Parse("86037836-3584-46b0-990f-ffa149b147f7"), Type = TextBlockType.Text, Text = "As long the creature remains grabbed or restrained, you can use just one hand to reload the weapon and (action: Strike) that creature with it." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificGunslingersWay(Guid.Parse("c53d2385-e204-4096-b379-bf4fd28ddd8a"), GunslingersWays.Instances.WayOfTheVanguard.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ea69e0e8-5a39-4d17-a15d-c9da4de72baa"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
