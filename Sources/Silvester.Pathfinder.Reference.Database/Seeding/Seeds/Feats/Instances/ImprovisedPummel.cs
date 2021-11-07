using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ImprovisedPummel : Template
    {
        public static readonly Guid ID = Guid.Parse("09d0ce00-3382-4fb3-a2d8-c05d2499d693");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Improvised Pummel",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("83d2c90e-a031-4baa-86fe-957794f92b7f"), Type = TextBlockType.Text, Text = "You make a (action: Strike) with your wielded improvised weapon. You gain a +1 item bonus to the attack roll, and the (action: Strike) deals two weapon damage dice if it would have dealt fewer. If the attack is a critical hit, in addition to the effect of the critical hit, the improvised weapon breaks. If the item has a Hardness greater than your level, or if it’s an artifact, cursed item, or other item that’s difficult to break or destroy, the item doesn’t break and the attack is a hit instead of a critical hit." };
            yield return new TextBlock { Id = Guid.Parse("db39e715-dae6-492b-87e2-318991e39555"), Type = TextBlockType.Text, Text = "At 12th level, your item bonus to the attack roll increases to +2 instead of +1, and at 16th level, the (action: Strike) deals three weapon damage dice if it would have dealt fewer, instead of two." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("a12b910a-2f29-4328-8bbd-27843780d9ef"), Feats.Instances.WeaponImproviserDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d5c498ae-2211-4fbf-8606-7c942a815bb8"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
