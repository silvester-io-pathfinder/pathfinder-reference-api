using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LuckyEscape : Template
    {
        public static readonly Guid ID = Guid.Parse("992f0def-0fc5-495c-9f46-bbfb6f8118d8");

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
            yield return new TextBlock { Id = Guid.Parse("11cf23bb-5c24-4412-b8e0-ac99f576c33d"), Type = TextBlockType.Text, Text = "Your enemy lies in wait, lines up the perfect shot, and pulls the trigger... then at just the right moment you duck down to notice something scrawled on the cobblestone in chalk, a shiny coin, or some other coincidental distraction, creating an opportunity for the attack to miss. The attacker must roll the attack twice and use the worse result." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("9061e5dd-5718-4c96-91ec-280081dfdad0"), Feats.Instances.UnexpectedSharpshooterDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e9a0edcb-6b74-435e-b00e-082729816b92"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
