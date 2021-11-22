using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ArcaneSlam : Template
    {
        public static readonly Guid ID = Guid.Parse("72c6cd48-6547-4210-a0ab-2ab61066df9b");

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
            yield return new TextBlock { Id = Guid.Parse("0a8e15cc-68b8-4fe9-9a88-6af0881c5e00"), Type = TextBlockType.Text, Text = "You channel magical power from your core into your arm, empowering your attack as you attempt to slam your foe into the ground. Attempt an Athletics check against the foe's Fortitude DC. You take a –2 circumstance penalty to your check if the target is one size larger than you and a –4 circumstance penalty if it's larger than that. You gain a +2 circumstance bonus to your check if the target is one size smaller than you and a +4 circumstance bonus if it's smaller than that." };
            yield return new TextBlock { Id = Guid.Parse("f82e8b26-dc67-419d-b275-18e721a5f5a5"), Type = TextBlockType.Text, Text = "----" };
            yield return new TextBlock { Id = Guid.Parse("97544926-c468-4710-964f-fcd0e064dbde"), Type = TextBlockType.Text, Text = "~ Enhancement: Your arms better channel your core's power. You no longer take penalties for attempting to slam larger foes. Your foe takes damage equal to 2d6 plus your Strength modifier on a success (or double that on a critical success)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificHeritage(Guid.Parse("a70e270a-61d5-4f92-a668-87e1ef6c3e52"), Heritages.Instances.WarriorAutomaton.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("58ecaa10-6aaa-43a4-8586-b5cf6abee576"),
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
                Id = Guid.Parse("cd0282c8-5bf0-4e1f-ba69-69d98e141af2"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
