using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HelpfulTinkering : Template
    {
        public static readonly Guid ID = Guid.Parse("15ef8160-6c58-490b-9cc3-503ea5abaaad");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Helpful Tinkering",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per 10 minutes"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("852ea089-e799-48a8-adcf-23acc70bb2d2"), Type = TextBlockType.Text, Text = $"You don't just tinker with your own innovation, you fiddle with your allies' weapons as well (for their benefit, of course). Choose an ally in your reach and one of their weapons. Attempt a Crafting check against a high DC for your level." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificClassFeature(Guid.Parse("4198805b-9444-4176-b9ca-c32a4c6512da"), ClassFeatures.Inventors.OffensiveBoost.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("6127397d-446c-4c0e-b3b9-4721dd34499e"),
                
                Success = "For 1 minute, the chosen ally's (action: Strikes | Strike) with the chosen weapon gain the same offensive boost your innovation has.",
                
                CriticalFailure = "Your ally takes damage of the type and amount that your offensive boost normally deals on a successful (action: Strike).", 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d11aaa20-29b3-4973-858f-5493325ec2f3"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
