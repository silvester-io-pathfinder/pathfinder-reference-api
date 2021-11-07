using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HotFoot : Template
    {
        public static readonly Guid ID = Guid.Parse("f94d284d-b734-4b52-a059-e9ab35d26ccf");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Hot Foot",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("efe93bbb-cab8-4054-95b0-15edf0b0e010"), Type = TextBlockType.Text, Text = "Using a carefully aimed shot, you make a creature “dance.” You shoot at the ground near a target’s feet, causing them to react involuntarily; even mindless creatures have unconscious responses to dodge an attack, and you can capitalize off those uncontrollable reflexes to achieve your aim. As they dance to the sweet tune of your pistol’s retort, you ensure your foe can’t use whatever nasty surprise they had planned in store for you and your allies. Make an attack roll against the Reflex DC of a target creature within your firearm’s first range increment." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("902feb74-b040-4550-95e4-56c68c8a3292"), Feats.Instances.PistolPhenomDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("02f9d8ef-61e4-473b-8596-ba1daf8cc05b"),
                CriticalSuccess = "The creature can’t use reactions, is flat-footed, and takes a –2 circumstance penalty to Reflex saves. These effects last until the start of its next turn.",
                Success = "The creature can’t use reactions until the start of its next turn.",
                
                 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("67c710ff-fcd0-467e-92de-ad53ba225a65"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
