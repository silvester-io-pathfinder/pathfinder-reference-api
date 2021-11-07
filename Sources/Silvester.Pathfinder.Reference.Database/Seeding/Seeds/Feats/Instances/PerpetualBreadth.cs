using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PerpetualBreadth : Template
    {
        public static readonly Guid ID = Guid.Parse("89d9bf42-b787-4163-9163-1efeb3621850");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Perpetual Breadth",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2c0b72d5-cb90-4092-96fd-2695440c2448"), Type = TextBlockType.Text, Text = "You have expanded your supply of near-infinite items. Choose a research field. Add one item from the list of options available to that field from perpetual infusions, or two items if you choose your own field. If you have perpetual potency or perpetual perfection, you gain an additional item (or items if you chose your own field) appropriate to the field you chose, for instance a higher-level version of the bomb you chose or a new poison." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificClassFeature(Guid.Parse("72553b87-ad2c-4fba-b74f-447eeb7dcf28"), ClassFeatures.Alchemists.PerpetualInfusions.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("debd3810-b8be-48d1-8d18-6486725f3571"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
