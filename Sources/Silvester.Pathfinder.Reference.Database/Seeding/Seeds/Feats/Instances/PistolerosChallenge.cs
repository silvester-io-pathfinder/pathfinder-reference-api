using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PistolerosChallenge : Template
    {
        public static readonly Guid ID = Guid.Parse("e6be10f5-64b0-4fd6-a3a2-862d021a91e7");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Pistolero's Challenge",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a05fe7b6-a3cd-4704-b347-f1e40b91fb8b"), Type = TextBlockType.Text, Text = "With a stern call, carefully chosen barb, or some other challenging declaration, you demand your foe’s attention in a duel. Choose an opponent within 30 feet who you can perceive and can hear you, and make your choice of a Deception or Intimidation check against the target’s Will DC. No matter the result of the check, the foe is temporarily immune to your Pistolero’s Challenge until noon the next day." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificGunslingersWay(Guid.Parse("49f04f01-fbb0-41df-9549-c0d2a2519a7c"), GunslingerWays.Instances.WayOfThePistolero.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("3ac08102-9fef-41e9-993c-6010c9b1ad0f"),
                
                Success = "Both you and the opponent gain a +2 status bonus to damage rolls with (action: Strikes|Strike) made against each other. If you’re a master in the skill you used for the check, the status bonus to damage rolls increases to +3, and if you’re legendary, it increases to +4. You can have only one challenge in effect at a time; challenging a new opponent ends this effect on any current target. Otherwise, the effect lasts until one of you is defeated, flees, or the encounter ends.",
                
                CriticalFailure = "You become frightened 1 and can’t use this ability again for 1 minute.", 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6c84b700-75fa-4809-9041-c8890131f73a"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
