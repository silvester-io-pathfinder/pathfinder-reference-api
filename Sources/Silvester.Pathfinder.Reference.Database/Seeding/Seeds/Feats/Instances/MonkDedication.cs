using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MonkDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("1a03bb06-8495-4c53-acae-dd83c144a4e0");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Monk Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can't select another dedication feat until you have gained two other feats from the monk archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f24bc2de-c796-4859-96a5-49d32e931aa4"), Type = TextBlockType.Text, Text = "You become trained in unarmed attacks and gain the powerful fist class feature (page 156). You become trained in your choice of Acrobatics or Athletics; if you are already trained in both of these skills, you become trained in a skill of your choice. You become trained in monk class DC." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificStat(Guid.Parse("9d5297ad-14cd-422d-856a-9a1ee6303021"), requiredStatValue: 14, Stats.Instances.Strength.ID);
            builder.HaveSpecificStat(Guid.Parse("3e8167b7-e91f-4faf-97ef-1e4cee750877"), requiredStatValue: 14, Stats.Instances.Dexterity.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ee009573-9e23-4e39-b634-e0c4f51f2455"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
