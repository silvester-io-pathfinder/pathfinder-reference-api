using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AvalancheStrike : Template
    {
        public static readonly Guid ID = Guid.Parse("c6c77ffb-7951-413f-8047-bfd1db3909d5");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Avalanche Strike",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("afdc0b15-ac8e-4d3a-998e-22afc145aa94"), Type = TextBlockType.Text, Text = "You attack all nearby adversaries. Make a melee (action: Strike) with the required weapon against each enemy within your melee reach. Each attack counts toward your multiple attack penalty, but don’t increase your penalty until you have made all your attacks." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("dd2fef9d-4b87-4195-bb96-2581d8658932"), Feats.Instances.MaulerDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ae52132b-88ab-482e-a3cb-47a774b494aa"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
