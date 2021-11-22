using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BoulderRoll : Template
    {
        public static readonly Guid ID = Guid.Parse("01aaf7d3-a9fa-40fd-804d-28f0929339d4");

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
            yield return new TextBlock { Id = Guid.Parse("299bc2be-7711-4e2c-88c0-ed3af05014ce"), Type = TextBlockType.Text, Text = "Your dwarven build allows you to push foes around, just like a mighty boulder tumbles through a subterranean cavern. Take a (Action: Step) into the square of a foe that is your size or smaller, and the foe must move into the empty space directly behind it. The foe must move even if doing so places it in harm's way. The foe can attempt a Fortitude saving throw against your Athletics DC to block your (Action: Step). If the foe attempts this saving throw, unless it critically succeeds, it takes bludgeoning damage equal to your level plus your Strength modifier." };
            yield return new TextBlock { Id = Guid.Parse("8906b5b1-ac12-45aa-87c4-df20ab787df5"), Type = TextBlockType.Text, Text = "If the foe can't move into an empty space (if it is surrounded by solid objects or other creatures, for example), your Boulder Roll has no effect." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("79cfe679-f8f7-424d-bfcf-b2bde21dc9f2"), Feats.Instances.RockRunner.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9113f10b-0e91-40b2-b707-669d8cd0b178"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
