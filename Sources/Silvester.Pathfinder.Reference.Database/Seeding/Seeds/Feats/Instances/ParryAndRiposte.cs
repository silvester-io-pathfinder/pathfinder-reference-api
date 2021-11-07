using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ParryAndRiposte : Template
    {
        public static readonly Guid ID = Guid.Parse("e78b919a-6b5b-406c-bc41-0e21ca29fd7c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Parry and Riposte",
                Level = 18,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9fe11f1d-fb3c-445c-9729-be60784d2708"), Type = TextBlockType.Text, Text = "Your parries and finishers allow you to riposte with the slightest provocation. You can use (feat: Opportune Riposte) against an enemy who fails at a (action: Strike) against you (not just critically fails), provided you have both damaged that creature with a (trait: finisher) on your last turn and currently have a circumstance bonus to AC from the (trait: parry) weapon trait, (feat: Dueling Parry), or (feat: Twin Parry)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("dc39299a-a8d9-4ddb-8861-5eabee213bc3"), Feats.Instances.OpportuneRiposte.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0305a6ff-f1f3-4d2f-a062-a0585820931c"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
