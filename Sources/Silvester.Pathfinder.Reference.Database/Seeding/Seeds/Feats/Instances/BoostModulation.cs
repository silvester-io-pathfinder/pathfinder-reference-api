using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BoostModulation : Template
    {
        public static readonly Guid ID = Guid.Parse("45936b12-e7f9-4784-b93f-83d9565d416d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Boost Modulation",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("75e223cd-5d76-4cef-8bc5-1e4a7d819130"), Type = TextBlockType.Text, Text = "You aren’t satisfied with keeping to just one kind of boost from your constant tinkering, so you’ve learned to modulate between several possibilities at once. Choose two additional offensive boosts (G&amp;G pg. 22). You can use an (action: Interact) action to change the offensive boost currently affecting your weapon, choosing between the one you chose for the class feature and the two you chose for this modification. If your weapon has the (trait: modular) trait, you can swap the offensive boost as part of the (action: Interact) action you take to use that trait." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificClassFeature(Guid.Parse("2624b234-496c-4ec0-b606-c2981f0c503e"), ClassFeatures.Gunslingers.OffensiveBoost.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("20d724e6-5fe4-47ba-862b-5d75d3f05351"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
