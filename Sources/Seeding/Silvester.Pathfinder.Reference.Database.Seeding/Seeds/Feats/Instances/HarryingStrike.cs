using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HarryingStrike : Template
    {
        public static readonly Guid ID = Guid.Parse("ea373afc-587a-4fd4-853d-587430d1f256");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Harrying Strike",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4aca3101-bc28-4ce2-8d17-2ada39dcf2ef"), Type = TextBlockType.Text, Text = "Your attack prevents a foe from pursuing your allies. Make a melee (action: Strike), adding the following effects in addition to the normal effects of the (action: Strike)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("f7731b18-d382-4cb3-ab47-9a5f0272793a"), Feats.Instances.SwordmasterDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("2e6615ab-ff6b-43ca-9bf7-41a5b0885ef1"),
                CriticalSuccess = "The target takes a -15-foot status penalty to its Speeds until the start of your next turn.",
                Success = "The target takes a -10-foot status penalty to its Speeds until the start of your next turn.",
                Failure = "The target takes a -5-foot status penalty to its Speeds until the start of your next turn.",
                 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ebd705f5-0802-4c66-b064-95edb451bc03"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
