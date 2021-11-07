using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ChangeShapeBeastkin : Template
    {
        public static readonly Guid ID = Guid.Parse("da959386-95f7-4c12-978a-f3f050455573");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Change Shape - Beastkin",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("85f7b65b-2192-4c9f-8c99-2562b62a6e9c"), Type = TextBlockType.Text, Text = "You change into your humanoid or hybrid shape. Each shape has a specific, persistent appearance, and most beastkin remain in their hybrid shapes by default. In hybrid shape, you appear as a mix between your ancestry and your inherent animal." };
            yield return new TextBlock { Id = Guid.Parse("3cc64972-45cc-4210-9be7-5f7a05fd010c"), Type = TextBlockType.Text, Text = "While in hybrid shape, you gain a jaws unarmed (action: Strike) resembling the features of your inherent animal (fangs for bats, beaks for eagles, mandibles for wasps, and so on). Your jaws deal 1d4 piercing damage, have the (trait: agile), (trait: finesse), and (trait: unarmed) traits, and are in the brawling weapon group. In your humanoid shape, you retain the appearance of your original ancestry." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b2817876-20f9-4252-859f-5d7b48567657"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
