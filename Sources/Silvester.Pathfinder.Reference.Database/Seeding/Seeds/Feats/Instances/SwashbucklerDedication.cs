using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SwashbucklerDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("519e0d6e-8b0c-4d1d-ba65-91dba28d3cd8");

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
            yield return new TextBlock { Id = Guid.Parse("52ff680d-2531-47e1-9bf4-a4116488c9e3"), Type = TextBlockType.Text, Text = "Choose a swashbuckler style (APG pg. 84). You gain the panache class feature, and you can gain panache in all the ways a swashbuckler of your style can. You become trained in Acrobatics or the skill associated with your style. If you were already trained in both skills, you instead become trained in a skill of your choice. You also become trained in swashbuckler class DC. You don’t gain any other effects of your chosen style." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificStat(Guid.Parse("8bffb1c4-dcc2-4c3f-b1ca-96bcc0b15803"), requiredStatValue: 14, Stats.Instances.Charisma.ID);
            builder.HaveSpecificStat(Guid.Parse("cc43afd6-57ca-4276-afc6-8c533e94ade6"), requiredStatValue: 14, Stats.Instances.Dexterity.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2bc51297-ec6b-441e-8fc2-785aad1c0c7f"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
