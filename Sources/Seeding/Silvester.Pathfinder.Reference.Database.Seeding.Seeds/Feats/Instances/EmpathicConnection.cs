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
    public class EmpathicConnection : Template
    {
        public static readonly Guid ID = Guid.Parse("d8b4d9fa-2f9f-400b-9851-7966f55f5de6");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Empathic Connection",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "An ally within 30 feet benefits from an emotion effect.",
                Frequency = "once per 10 minutes"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("00b3666b-ae1a-4982-b1fe-c41c89b42932"), Type = TextBlockType.Text, Text = $"Your sensitivity to your allies' emotions allows you to benefit from some of the same effects they do. Choose one of the following two benefits." };
            yield return new TextBlock { Id = Guid.Parse("7706d168-bd96-4ef2-b113-bf40496c0394"), Type = TextBlockType.Enumeration, Text = $" : If the ally regained Hit Points due to the triggering effect, you gain half these Hit Points as temporary Hit Points that last until the end of your next turn." };
            yield return new TextBlock { Id = Guid.Parse("8d24810f-f5a8-4abe-a37b-5899e68a9abf"), Type = TextBlockType.Enumeration, Text = $" : If the ally gained a status bonus to a type of save or other check due to the triggering effect, you gain the same bonus. This benefit ends at the end of your next turn if it hasn't already ended before then due to its normal limitations or duration." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            //TODO: Add prerequisites.
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0c56f274-bd87-4c32-820b-e4170cfd8f0a"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
