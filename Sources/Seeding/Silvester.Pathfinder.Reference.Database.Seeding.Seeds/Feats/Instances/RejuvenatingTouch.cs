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
    public class RejuvenatingTouch : Template
    {
        public static readonly Guid ID = Guid.Parse("86d3b230-db6b-4a2f-a204-ccb1ab93e190");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Rejuvenating Touch",
                Level = 18,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6ed5acb0-061f-4719-bc79-62263549ea3f"), Type = TextBlockType.Text, Text = $"Your healing energies linger after you cast, providing continual benefits. An ally that recovers Hit Points from your lay on hands gains 10 temporary Hit Points at the start of their turn during each of the next 10 rounds. This effect ends if the ally is knocked unconscious." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSpell(Guid.Parse("75d0de64-f86b-4dd5-9036-8f1ce3bdeff5"), Spells.Instances.LayOnHands.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("638cf984-51c1-42f7-b97d-e2578f3c8c91"), Traits.Instances.Champion.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fa96d9cd-c041-4fa4-bbec-2a40b344cc58"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
