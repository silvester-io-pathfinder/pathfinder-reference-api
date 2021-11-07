using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TigerSlash : Template
    {
        public static readonly Guid ID = Guid.Parse("435607e4-17a8-4879-9694-45266c448f5e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Tiger Slash",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("20f4fac8-2fe2-416d-8ff2-2458f3a5959e"), Type = TextBlockType.Text, Text = "You make a fierce swipe with both hands. Make a tiger claw (action: Strike). It deals two extra weapon damage dice (three extra dice if you’re 14th level or higher), and you can push the target 5 feet away as if you had successfully (action: Shoved | Shove) them. If the attack is a critical success and deals damage, add your Strength modifier to the persistent bleed damage from your tiger claw." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("39d663b4-f826-4edf-b252-0b11238b13f7"), Feats.Instances.TigerStance.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("db3497e1-d235-4f27-948f-6498f4411b39"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
