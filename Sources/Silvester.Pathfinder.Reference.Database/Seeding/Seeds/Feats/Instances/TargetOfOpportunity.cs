using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TargetOfOpportunity : Template
    {
        public static readonly Guid ID = Guid.Parse("be4b50a9-479f-4776-97d1-93e78ef5fe84");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Target of Opportunity",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "An ally succeeds at a ranged Strike against an opponent within your weapon's first range increment.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("fbe88565-daaf-4a81-a48d-67c3a22e02d0"), Type = TextBlockType.Text, Text = "You capitalize on your ally’s attack to create a coordinated barrage. Make a ranged (action: Strike) with a -2 penalty against the opponent targeted by the triggering attack. This (action: Strike) doesn’t count toward your multiple attack penalty, and your multiple attack penalty doesn’t apply to this (action: Strike). If this (action: Strike) is successful, combine the damage from the attack with the damage from your ally’s attack for the purpose of resistances and weaknesses." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("fe45efff-fcb9-4797-a425-b0d152b71854"), Feats.Instances.MarshalDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("837636b6-3e38-4736-93ec-78270020e132"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
