using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HerosWings : Template
    {
        public static readonly Guid ID = Guid.Parse("bf2376e8-e814-4ef9-88fe-f64d6a7b54e7");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Hero's Wings",
                Level = 17,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ee1e9c2a-a3e0-4f0a-8851-55e2637612d5"), Type = TextBlockType.Text, Text = "You have begun the final steps to reaching your full potential. Your wings are always in their majestic form without you needing to use (feat: Energize Wings), granting you a permanent fly Speed. Furthermore, sprites recognize you as a powerful hero (or villain) by your unique wings and are appropriately impressed. You gain a +2 circumstance bonus on all Diplomacy and Intimidation checks against sprites and gain the benefits of the (feat: Glad-Hand) skill feat against other sprites, without taking a -5 penalty to your Diplomacy check." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("ad04c111-ccbe-4ffe-b388-3444b463175d"), Feats.Instances.EnergizeWings.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("db85fb83-6361-492c-b065-e398c712e7a6"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
