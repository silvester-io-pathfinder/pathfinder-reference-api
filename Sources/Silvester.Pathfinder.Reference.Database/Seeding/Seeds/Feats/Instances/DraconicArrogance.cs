using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DraconicArrogance : Template
    {
        public static readonly Guid ID = Guid.Parse("202610a2-92a5-4caf-bd8b-86813bbabe0d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Draconic Arrogance",
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
            yield return new TextBlock { Id = Guid.Parse("06f181ad-ad2c-4b48-89ee-4a4dd18e3117"), Type = TextBlockType.Text, Text = "Few can sway you from your goals while the fury of combat fills you. While raging, you gain a +2 status bonus to saving throws against (trait: emotion) effects." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificInstinct(Guid.Parse("6241baee-16f5-4b4f-b9ef-89794975918b"), Instincts.Instances.DragonInstinct.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b2e6359c-6132-4776-bd7f-e6a1f977910a"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
