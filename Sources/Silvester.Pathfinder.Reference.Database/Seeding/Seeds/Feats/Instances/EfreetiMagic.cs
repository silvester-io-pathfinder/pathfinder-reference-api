using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EfreetiMagic : Template
    {
        public static readonly Guid ID = Guid.Parse("5f961821-3c05-4efa-ac49-b4199b69a2fb");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Efreeti Magic",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("279d85c2-b6e2-4195-be34-c27c21bb96e9"), Type = TextBlockType.Text, Text = "The magic of your efreeti ancestors flows through you. You can cast (spell: enlarge) and (spell: illusory object) once per day each as 2nd-level arcane innate spells." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7baa8bb0-c04f-4ea8-9da2-9d2238c4eb0a"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
