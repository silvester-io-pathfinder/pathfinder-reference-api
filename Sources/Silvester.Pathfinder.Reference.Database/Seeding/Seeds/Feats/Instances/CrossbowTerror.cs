using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CrossbowTerror : Template
    {
        public static readonly Guid ID = Guid.Parse("0a3704ef-8bf7-4b56-be97-63a2fc32cf7f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Crossbow Terror",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d1ca2d4c-736d-4fc1-a7b2-11ca4cbf572a"), Type = TextBlockType.Text, Text = "You are a dynamo with the crossbow. You gain a +2 circumstance bonus to damage with crossbows. If the crossbow is a simple weapon, also increase the damage die size for your attacks made with that crossbow by one step. As normal, this damage die increase can’t be combined with other abilities that alter the weapon damage die (such as the ranger feat (feat: Crossbow Ace))." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("ff6cbe1e-a815-4e29-8fa2-a3f96c3bcad1"), Feats.Instances.ArcherDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("81491a1f-581a-42d8-80ba-d1011c8f7cc2"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
