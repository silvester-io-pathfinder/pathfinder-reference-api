using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HerosWings : Template
    {
        public static readonly Guid ID = Guid.Parse("4f4613ab-7f79-438a-a4f6-cfc541a24ac0");

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
            yield return new TextBlock { Id = Guid.Parse("c7a5a1a8-e5cb-409b-ba97-5fab85165230"), Type = TextBlockType.Text, Text = "You have begun the final steps to reaching your full potential. Your wings are always in their majestic form without you needing to use (feat: Energize Wings), granting you a permanent fly Speed. Furthermore, sprites recognize you as a powerful hero (or villain) by your unique wings and are appropriately impressed. You gain a +2 circumstance bonus on all Diplomacy and Intimidation checks against sprites and gain the benefits of the (feat: Glad-Hand) skill feat against other sprites, without taking a -5 penalty to your Diplomacy check." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("3a19168a-2dcb-4170-a7fc-1762c54a68fd"), Feats.Instances.EnergizeWings.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("70e43ecb-5f97-4670-9d98-4cc60e7fc3cd"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
