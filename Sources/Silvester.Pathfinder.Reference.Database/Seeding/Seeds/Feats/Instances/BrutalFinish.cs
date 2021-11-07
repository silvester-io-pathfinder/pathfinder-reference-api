using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BrutalFinish : Template
    {
        public static readonly Guid ID = Guid.Parse("ad3e400d-1b02-4868-9c22-9cf1c9469518");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Brutal Finish",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("95d875b7-c201-421c-a5b3-36283c667cd3"), Type = TextBlockType.Text, Text = "Your final blow can make an impact even if it rebounds off a foe’s defenses. Make a (action: Strike) with the required weapon. After the (action: Strike), your turn ends. The (action: Strike) deals one extra weapon damage die, or two extra weapon damage dice if you’re at least 18th level. The (action: Strike) also gains the following failure effect." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("140313b9-9a61-4fcf-a306-509a0211af84"), Feats.Instances.MaulerDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("119ca366-d41b-419e-8392-60c22e7f0183"),
                
                
                Failure = "You deal damage equal to one weapon damage die of the required weapon. Increase this to two dice if you’re at least 18th level.",
                 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1ca6f9e4-8cb2-43fb-8aa6-1d08d56ef5b1"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
