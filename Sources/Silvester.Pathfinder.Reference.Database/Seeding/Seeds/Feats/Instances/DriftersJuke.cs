using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DriftersJuke : Template
    {
        public static readonly Guid ID = Guid.Parse("d639de98-27ce-42dd-8737-fdd2e7d43b79");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Drifter's Juke",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("04873dd6-e647-4c3c-a7d7-e0eb122a9c2c"), Type = TextBlockType.Text, Text = "You move in and out of range to complement your attacks. You (action: Step), make a (action: Strike), (action: Step), and make another (action: Strike). One (action: Strike) must be a ranged (action: Strike) using your firearm or crossbow, and the other must be a melee (action: Strike) using your melee weapon or unarmed attack. You can choose not to take one or both (action: Steps|Step)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificGunslingersWay(Guid.Parse("2a08fe68-677b-456f-99d9-8bbe6e93da20"), GunslingerWays.Instances.WayOfTheDrifter.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5b185f0b-0418-454f-bdb1-45dbaa26b2be"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
