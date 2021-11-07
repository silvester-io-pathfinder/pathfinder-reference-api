using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RejuvenatingTouch : Template
    {
        public static readonly Guid ID = Guid.Parse("752f05b6-7773-4a60-bfe8-5ac52eb53453");

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
            yield return new TextBlock { Id = Guid.Parse("6f89227c-7c4b-4626-81e1-f005d2e1b17c"), Type = TextBlockType.Text, Text = "Your healing energies linger after you cast, providing continual benefits. An ally that recovers Hit Points from your lay on hands gains 10 temporary Hit Points at the start of their turn during each of the next 10 rounds. This effect ends if the ally is knocked unconscious." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSpell(Guid.Parse("a816c080-e3f7-40c4-b17b-4ca454f9b6e0"), Spells.Instances.LayOnHands.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4c9e7439-7871-468f-b4b7-665b8e77f645"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
