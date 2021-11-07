using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SwashbucklerDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("ada48401-abe1-4adc-a136-253f7370c1c3");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Swashbuckler Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can't select another dedication feat until you have gained two other feats from the swashbuckler archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("83dfb18f-af01-4e9d-8673-a6017bec21c7"), Type = TextBlockType.Text, Text = "Choose a swashbuckler style (APG pg. 84). You gain the panache class feature, and you can gain panache in all the ways a swashbuckler of your style can. You become trained in Acrobatics or the skill associated with your style. If you were already trained in both skills, you instead become trained in a skill of your choice. You also become trained in swashbuckler class DC. You don’t gain any other effects of your chosen style." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificStat(Guid.Parse("b342a540-1a3c-45be-aa4a-d4e2f312104d"), requiredStatValue: 14, Stats.Instances.Charisma.ID);
            builder.HaveSpecificStat(Guid.Parse("55ac767b-16ec-421e-9faf-8cbe4ad0f7f2"), requiredStatValue: 14, Stats.Instances.Dexterity.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c9106af6-5000-439f-8a67-b23f9e4143ed"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
