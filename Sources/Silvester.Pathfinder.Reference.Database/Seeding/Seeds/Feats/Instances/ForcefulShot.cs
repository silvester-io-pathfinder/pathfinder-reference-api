using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ForcefulShot : Template
    {
        public static readonly Guid ID = Guid.Parse("0f6edbc3-abf1-49c5-a650-cfb49b683964");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Forceful Shot",
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
            yield return new TextBlock { Id = Guid.Parse("0fdc06f2-511d-46cc-95fd-59cc83e459ba"), Type = TextBlockType.Text, Text = "Your ranged attacks push your foes away from your allies. Make a ranged (action: Strike), adding the following effects in addition to the normal effects of the (action: Strike)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("dfc8b738-fd05-4134-997b-088f0a36e02d"), Feats.Instances.SwordmasterDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("114fee80-2748-45b0-816f-6531da76f497"),
                CriticalSuccess = "The target is pushed 10 feet away from you.",
                Success = "The target is pushed 5 feet away from you.",
                Failure = "The target is flat-footed for 1 round.",
                 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("86290332-f3b8-47c3-8e89-91803dbc7a01"),
                SourceId = Sources.Instances.LostOmensSocietyGuide.ID,
                Page = -1
            };
        }
    }
}
