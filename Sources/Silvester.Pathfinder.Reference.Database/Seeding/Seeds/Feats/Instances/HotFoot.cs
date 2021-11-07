using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HotFoot : Template
    {
        public static readonly Guid ID = Guid.Parse("eb4ddeea-cd6a-4af8-be1c-c3d5a1d4e8e5");

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
            yield return new TextBlock { Id = Guid.Parse("ef948fb6-638a-4ce0-b7be-34a3233e9c43"), Type = TextBlockType.Text, Text = "Using a carefully aimed shot, you make a creature “dance.” You shoot at the ground near a target’s feet, causing them to react involuntarily; even mindless creatures have unconscious responses to dodge an attack, and you can capitalize off those uncontrollable reflexes to achieve your aim. As they dance to the sweet tune of your pistol’s retort, you ensure your foe can’t use whatever nasty surprise they had planned in store for you and your allies. Make an attack roll against the Reflex DC of a target creature within your firearm’s first range increment." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("c2413529-c8a5-4843-bc04-1a57e97a01a5"), Feats.Instances.PistolPhenomDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("73eedfae-652e-4f14-9d42-27ba4d29f856"),
                CriticalSuccess = "The creature can’t use reactions, is flat-footed, and takes a –2 circumstance penalty to Reflex saves. These effects last until the start of its next turn.",
                Success = "The creature can’t use reactions until the start of its next turn.",
                
                 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d128508f-dc66-40b6-9f66-ef5bc5597bf2"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
