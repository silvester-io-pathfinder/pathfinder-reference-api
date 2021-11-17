using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BrutalFinish : Template
    {
        public static readonly Guid ID = Guid.Parse("4800da14-82ad-4e4d-b5c4-736c5195c481");

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
            yield return new TextBlock { Id = Guid.Parse("2293a30f-f7f0-4619-8843-63489bfbc18c"), Type = TextBlockType.Text, Text = "Your final blow can make an impact even if it rebounds off a foe’s defenses. Make a (action: Strike) with the required weapon. After the (action: Strike), your turn ends. The (action: Strike) deals one extra weapon damage die, or two extra weapon damage dice if you’re at least 18th level. The (action: Strike) also gains the following failure effect." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("71447f23-dc51-4a23-b232-24dd5466a405"), Feats.Instances.MaulerDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("73339d55-38bf-4c03-b725-1f43937788ef"),
                
                
                Failure = "You deal damage equal to one weapon damage die of the required weapon. Increase this to two dice if you’re at least 18th level.",
                 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a5300c58-523b-43a5-b816-b5a1b9e1e424"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}