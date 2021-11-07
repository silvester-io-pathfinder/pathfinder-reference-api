using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ChampionDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("792d9cb3-1307-4350-89f2-bed70a20a39b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Champion Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You cannot select another dedication feat until you have gained two other feats from the champion archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("30bc517d-e8ed-46b8-afe7-e4afd45963a1"), Type = TextBlockType.Text, Text = "Choose a deity and cause as you would if you were a champion. You become trained in light, medium, and heavy armor. You become trained in Religion and your deity’s associated skill; for each of these skills in which you were already trained, you instead become trained in a skill of your choice. You become trained in champion class DC." };
            yield return new TextBlock { Id = Guid.Parse("3218cf78-a7c9-41ca-be15-1b0976c2f69c"), Type = TextBlockType.Text, Text = "You are bound by your deity’s anathema and must follow the champion’s code and alignment requirements for your cause. You don’t gain any other abilities from your choice of deity or cause." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificStat(Guid.Parse("b0ecb111-4904-41d5-962d-b5ec7900902a"), requiredStatValue: 14, Stats.Instances.Strength.ID);
            builder.HaveSpecificStat(Guid.Parse("ad675d3b-111f-4416-8ec7-ed4f127b92c6"), requiredStatValue: 14, Stats.Instances.Charisma.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7f799990-2ccb-4bf1-8633-15ad0a260e17"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
