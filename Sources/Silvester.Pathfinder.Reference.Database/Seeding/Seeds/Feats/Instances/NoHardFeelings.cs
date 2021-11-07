using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class NoHardFeelings : Template
    {
        public static readonly Guid ID = Guid.Parse("f5ced8f4-d16d-4239-acdd-cc56f206c4e9");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "No Hard Feelings",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0d76576c-6b9b-41b5-88b2-5078638ab65d"), Type = TextBlockType.Text, Text = "Despite the devastation your weapons tend to inflict upon their targets or the destruction you might unleash upon an area, your foes still manage to walk away at the end of a fight—at least sometimes. You can choose to add the (trait: nonlethal) trait to your ranged weapons, making the choice of whether to add the trait or not just before each (action: Strike)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("e7c7dee0-f91c-4af4-b2cf-f93cbbc11df8"), Feats.Instances.UnexpectedSharpshooterDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("45822860-11c1-4d00-9d45-2c1d5fdb4b5b"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
