using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LuckyEscape : Template
    {
        public static readonly Guid ID = Guid.Parse("f1fb4e3b-0b83-46b6-a31b-85e53aa5463a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Lucky Escape",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "A creature targets you with an attack, even if you aren't aware of it.",
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0fe88f55-44aa-415b-8b90-71adb433c4a9"), Type = TextBlockType.Text, Text = $"Your enemy lies in wait, lines up the perfect shot, and pulls the trigger... then at just the right moment you duck down to notice something scrawled on the cobblestone in chalk, a shiny coin, or some other coincidental distraction, creating an opportunity for the attack to miss. The attacker must roll the attack twice and use the worse result." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("f02afeb0-0ba1-4577-af39-4add880255e8"), Feats.Instances.UnexpectedSharpshooterDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2c826f31-6e52-4fce-90b8-f3e4bae9495f"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
