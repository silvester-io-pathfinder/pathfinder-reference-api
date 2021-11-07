using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MutableFamiliar : Template
    {
        public static readonly Guid ID = Guid.Parse("00061b6c-c86a-4ac2-a4ad-108445097cbb");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Mutable Familiar",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("91c8e2e7-995c-4cb2-9a04-ee45d19e38d3"), Type = TextBlockType.Text, Text = "Your familiar’s supernatural spirit has outgrown its corporeal body. You can conduct a special 10-minute activity to reselect certain familiar abilities, switching one or more of the following abilities for other abilities on this list: amphibious, burrower, climber, darkvision, fast movement, manual dexterity, resistance, and scent. You can reselect only familiar abilities you would normally be able to reselect each day, not required familiar abilities for your familiar. You can’t remove an ability that is required for another ability your familiar has (for instance, you can’t remove manual dexterity if the familiar has lab assistant)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("027a7384-ba54-4b7c-9ca4-25d98576ed59"), Feats.Instances.FamiliarMasterDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("29bc552c-8c44-4bd4-be43-e7e11ba5fc91"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
