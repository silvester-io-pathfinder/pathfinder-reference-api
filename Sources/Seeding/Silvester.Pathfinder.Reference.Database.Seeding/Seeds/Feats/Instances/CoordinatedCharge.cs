using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CoordinatedCharge : Template
    {
        public static readonly Guid ID = Guid.Parse("789ebfc3-91ae-451c-aa58-9a9b0b97f0f5");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Coordinated Charge",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8f1f6ff4-c455-4d3a-ab89-937b58e8d2ed"), Type = TextBlockType.Text, Text = "You heroically dash into the fray, inspiring your allies to follow. You (action: Stride) up to your Speed and make a melee (action: Strike). If your (action: Strike) hits and damages an enemy, each ally within 60 feet who saw you hit can use a reaction to (action: Stride), but they each must end their (action: Stride) closer to the creature you hit than where they started." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("40f0d00c-7442-4c0b-8547-86bf53b3c16a"), Feats.Instances.MarshalDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("028305e9-fbf4-400a-8fae-27a1d3fe71fa"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
