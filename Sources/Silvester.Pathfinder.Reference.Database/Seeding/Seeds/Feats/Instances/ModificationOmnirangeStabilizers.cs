using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ModificationOmnirangeStabilizers : Template
    {
        public static readonly Guid ID = Guid.Parse("7996119c-4295-4393-bee3-890cd98045c7");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Modification - Omnirange Stabilizers",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("cac0d23d-77ba-4310-a833-1c059edb0fa1"), Type = TextBlockType.Enumeration, Text = "*Ranged Only**" };
            yield return new TextBlock { Id = Guid.Parse("417880fc-ebef-478d-8e6a-211987b18739"), Type = TextBlockType.Text, Text = "You’ve modified your innovation to be dangerous and effective at any range. If your innovation had the (trait: volley) trait, remove the (trait: volley) trait. Otherwise, increase your innovation’s range increment by 50 feet or an amount equal to the weapon’s base range increment, whichever is more." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8fbf39cd-84e5-4b80-a28c-98d011bbc722"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
