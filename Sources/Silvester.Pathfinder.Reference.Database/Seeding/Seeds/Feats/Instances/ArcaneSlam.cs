using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ArcaneSlam : Template
    {
        public static readonly Guid ID = Guid.Parse("493b0497-f899-4aa8-aaa0-d4c428c94246");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Arcane Slam",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c7b9bd25-8b2a-4fff-8f40-24da32a754bf"), Type = TextBlockType.Text, Text = "You channel magical power from your core into your arm, empowering your attack as you attempt to slam your foe into the ground. Attempt an Athletics check against the foe’s Fortitude DC. You take a –2 circumstance penalty to your check if the target is one size larger than you and a –4 circumstance penalty if it’s larger than that. You gain a +2 circumstance bonus to your check if the target is one size smaller than you and a +4 circumstance bonus if it’s smaller than that." };
            yield return new TextBlock { Id = Guid.Parse("8a31d096-17f6-403a-82fc-adf568822f87"), Type = TextBlockType.Text, Text = "----" };
            yield return new TextBlock { Id = Guid.Parse("ae05543f-0af6-4c1c-bc3f-3fc0b1052ab7"), Type = TextBlockType.Text, Text = "~ Enhancement: Your arms better channel your core’s power. You no longer take penalties for attempting to slam larger foes. Your foe takes damage equal to 2d6 plus your Strength modifier on a success (or double that on a critical success)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificHeritage(Guid.Parse("1cfe75b2-3e5e-4435-980a-702519e08590"), Heritages.Instances.WarriorAutomaton.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("97f365cd-0d55-45ef-97c1-bd4bd419fafe"),
                CriticalSuccess = "You slam the foe down and the magical energy overwhelms it. The creature is knocked prone, becomes dazzled for 1 round, and takes damage equal to 2d6 plus your Strength modifier. The foe is no longer grabbed or restrained by you.",
                Success = "You slam the foe down. The creature is knocked prone and takes damage equal to your Strength modifier. The foe is no longer grabbed or restrained by you.",
                Failure = "You are unable to slam the creature, but your hold on the creature remains.",
                CriticalFailure = "The creature breaks free and is no longer grabbed or restrained by you.", 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1426b228-dcb2-4db9-940a-6981025a6d75"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
