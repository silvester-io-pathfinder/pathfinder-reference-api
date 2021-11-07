using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ElementalAssault : Template
    {
        public static readonly Guid ID = Guid.Parse("28b2fd12-c683-4413-82f0-6ffd8bbf6c71");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Elemental Assault",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("75b4f672-669d-4ec3-87d0-5913f513b5f1"), Type = TextBlockType.Text, Text = "You shroud your arms and held weapons in elemental magic. Choose one element. Until the end of your next turn, your (action: Strikes | Strike) deal an additional 1d6 damage of the indicated type and have the trait corresponding to the element: electricity for (trait: air), bludgeoning for (trait: earth), fire for (trait: fire), or cold for (trait: water)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5246d815-fa39-45e2-9d37-4ae4936bc68f"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
