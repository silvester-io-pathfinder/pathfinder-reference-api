using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Fading : Template
    {
        public static readonly Guid ID = Guid.Parse("b20ed129-0a9f-431d-aa87-0db4938ddf55");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Fading",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You are targeted with a Strike by someone you can detect while your Crimson Shroud is active.",
                Frequency = "once per Crimson Shroud"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ffc44b8f-f99f-4475-8692-57e5d7f45c0b"), Type = TextBlockType.Text, Text = "You fade partially from reality. The attacker must attempt a DC 11 flat check; on a failure, the attack passes harmlessly through the image of your body that remains behind. An instant later you return to reality, and your (feat: Crimson Shroud) ends." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("781e8151-b6e8-451c-aa9c-b49eb59dd848"), Feats.Instances.CrimsonShroud.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6a1597ad-e7a5-4543-b2d1-c54f9ea332bc"),
                SourceId = Sources.Instances.LostOmensLegends.ID,
                Page = -1
            };
        }
    }
}
