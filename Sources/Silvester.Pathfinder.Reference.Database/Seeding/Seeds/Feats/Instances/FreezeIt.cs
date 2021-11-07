using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FreezeIt : Template
    {
        public static readonly Guid ID = Guid.Parse("88e56dac-53f3-4a0f-b88a-b7c19b8c345c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Freeze It!",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("dac6416c-cd43-401f-b27a-385da6dee51c"), Type = TextBlockType.Text, Text = "You are no rime hag or Jadwiga, but the magic of the north has still left a mark on you. Frigid ice runs through your veins, and you can expel frost from your body to freeze your foes. Attempt an Athletics check against the Fortitude DC of an adjacent foe." };
            yield return new TextBlock { Id = Guid.Parse("23bd4510-e878-477b-be4e-b1278b78899f"), Type = TextBlockType.Text, Text = "If you have master proficiency in Athletics, you can affect up to two adjacent foes, rolling one Athletics check against each foe." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificHeritage(Guid.Parse("33588995-8df0-4a4a-8c08-1f449e09e059"), Heritages.Instances.SnowGoblin.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("0d870167-667d-4213-ac66-06fbdf22438c"),
                CriticalSuccess = "The target becomes clumsy 2 for 1 round.",
                Success = "The target becomes clumsy 1 for 1 round.",
                
                CriticalFailure = "The target is temporarily immune for 1 minute.", 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b5833033-f439-46fd-8f7d-1424f11f5108"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
