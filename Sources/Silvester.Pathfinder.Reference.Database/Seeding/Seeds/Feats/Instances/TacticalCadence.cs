using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TacticalCadence : Template
    {
        public static readonly Guid ID = Guid.Parse("3384a294-c280-4712-9895-91c163fc67ff");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Tactical Cadence",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("76ca8c2d-5abc-4526-a8e6-2688fd964dd5"), Type = TextBlockType.Text, Text = "Your remarkable breath control and concise instructions allow you to coordinate your allies more effectively. When you grant allies the quickened condition using (feat: Cadence Call), they can use the extra action to either (action: Stride) or (action: Strike), and they aren’t slowed 1 on their following turn if they use the extra action." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("3175ed59-8384-4485-8e36-2ca668cb6077"), Feats.Instances.CadenceCall.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("95900380-c766-4f80-876b-6bc2e8616e8f"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
