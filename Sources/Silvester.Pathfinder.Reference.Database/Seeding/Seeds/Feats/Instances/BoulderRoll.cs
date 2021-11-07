using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BoulderRoll : Template
    {
        public static readonly Guid ID = Guid.Parse("be8db5be-bc6f-4438-b3ea-8280589d6946");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Boulder Roll",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("adfac070-e2d5-4062-b2d5-382fccdf695f"), Type = TextBlockType.Text, Text = "Your dwarven build allows you to push foes around, just like a mighty boulder tumbles through a subterranean cavern. Take a (Action: Step) into the square of a foe that is your size or smaller, and the foe must move into the empty space directly behind it. The foe must move even if doing so places it in harm’s way. The foe can attempt a Fortitude saving throw against your Athletics DC to block your (Action: Step). If the foe attempts this saving throw, unless it critically succeeds, it takes bludgeoning damage equal to your level plus your Strength modifier." };
            yield return new TextBlock { Id = Guid.Parse("65de67dc-fe93-4c94-8205-c594444c765f"), Type = TextBlockType.Text, Text = "If the foe can’t move into an empty space (if it is surrounded by solid objects or other creatures, for example), your Boulder Roll has no effect." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("9eda2e6c-bbc1-4651-a9b3-8e463f5154ad"), Feats.Instances.RockGunner.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a2743361-00dd-4bf7-9994-bf194b176f23"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
