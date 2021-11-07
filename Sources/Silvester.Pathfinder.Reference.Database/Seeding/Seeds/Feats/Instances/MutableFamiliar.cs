using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MutableFamiliar : Template
    {
        public static readonly Guid ID = Guid.Parse("aa86feeb-eb8a-49ef-8fa9-d7a266b5eb65");

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
            yield return new TextBlock { Id = Guid.Parse("7311734a-6b91-47cd-ae69-e3771f340a57"), Type = TextBlockType.Text, Text = "Your familiar’s supernatural spirit has outgrown its corporeal body. You can conduct a special 10-minute activity to reselect certain familiar abilities, switching one or more of the following abilities for other abilities on this list: amphibious, burrower, climber, darkvision, fast movement, manual dexterity, resistance, and scent. You can reselect only familiar abilities you would normally be able to reselect each day, not required familiar abilities for your familiar. You can’t remove an ability that is required for another ability your familiar has (for instance, you can’t remove manual dexterity if the familiar has lab assistant)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("4061e0cd-19cf-426c-bc33-d36129af3124"), Feats.Instances.FamiliarMasterDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1d42ff38-381a-489b-ac6f-33351e0c7d21"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
