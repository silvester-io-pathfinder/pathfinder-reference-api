using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MonasticArcherStance : Template
    {
        public static readonly Guid ID = Guid.Parse("7e8bb88b-8983-4c68-966a-48d66c67b99b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Monastic Archer Stance",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "When you select this feat, you become trained in the longbow, shortbow, and any simple and martial bows with the monk trait. If you gain the expert strikes class feature, your proficiency rank for these weapons increases to expert, and if you gain the master strikes class feature, your proficiency rank for these weapons increases to master.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d3ab4e2b-f4be-49a4-81d6-04967c26e47c"), Type = TextBlockType.Text, Text = "You enter a specialized stance for a unique martial art centered around the use of a bow. While in this stance, the only (action: Strikes | Strike) you can make are those using longbows, shortbows, or bows with the (trait: monk | Monk - Item) trait. You can use (feat: Flurry of Blows) with these bows. You can use your other monk feats or monk abilities that normally require unarmed attacks with these bows when attacking within half the first range increment (normally 50 feet for a longbow and 30 feet for a shortbow), so long as the feat or ability doesn’t require a single, specific (action: Strike)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("027708e1-dd55-460f-a150-614d6f7bd909"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
