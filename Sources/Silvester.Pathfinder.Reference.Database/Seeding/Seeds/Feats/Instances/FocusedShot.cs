using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FocusedShot : Template
    {
        public static readonly Guid ID = Guid.Parse("e31f2230-8f4e-4cf7-99bf-337450ee3ea0");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Focused Shot",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e2855034-c908-4f72-9fb9-b61d64c9f4f8"), Type = TextBlockType.Text, Text = "You achieve a state of perfect calm before unleashing your attack, opening your mind to the minute movements of the world around you to increase your accuracy. Make a ranged weapon (action: Strike) against a target within your weapon’s first range increment. This (action: Strike) ignores the target’s concealed condition and all cover." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("bf3f34c8-e7c2-47a3-86d6-a0f953b98da4"), Feats.Instances.MonasticArcherStance.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("59a8d2fc-63f7-45ce-8cee-5e10adbd08e9"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
