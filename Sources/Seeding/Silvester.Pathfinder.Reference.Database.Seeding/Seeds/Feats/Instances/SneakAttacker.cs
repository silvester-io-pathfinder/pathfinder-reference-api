using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SneakAttacker : Template
    {
        public static readonly Guid ID = Guid.Parse("c71ed66f-fc05-4ed0-9d6e-4dcf7b14e1ba");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Sneak Attacker",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0405b115-b332-4fc4-acbe-e3e62f12c8cf"), Type = TextBlockType.Text, Text = "You gain the sneak attack class feature (page 181), except you deal 1d6 precision damage regardless of your level. Sneak attack from multiple sources isn't cumulative. If you have sneak attack from more than one source, use only the highest number of dice when you sneak attack rather than adding the amounts together." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("c87d9982-8c4f-4f87-9152-9b39b03854e7"), Feats.Instances.AssassinDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("adb12ca6-7c21-4968-8fe1-6099fde50bb1"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
