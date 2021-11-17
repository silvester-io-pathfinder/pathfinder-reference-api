using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ChangeShapeBeastkin : Template
    {
        public static readonly Guid ID = Guid.Parse("847736a0-779b-40c5-85a3-b0aa3b2740c4");

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
            yield return new TextBlock { Id = Guid.Parse("758d24d0-ae2f-4976-b844-020196245861"), Type = TextBlockType.Text, Text = "You change into your humanoid or hybrid shape. Each shape has a specific, persistent appearance, and most beastkin remain in their hybrid shapes by default. In hybrid shape, you appear as a mix between your ancestry and your inherent animal." };
            yield return new TextBlock { Id = Guid.Parse("32a8e4e1-07bd-4c19-bc40-b6d9e688928c"), Type = TextBlockType.Text, Text = "While in hybrid shape, you gain a jaws unarmed (action: Strike) resembling the features of your inherent animal (fangs for bats, beaks for eagles, mandibles for wasps, and so on). Your jaws deal 1d4 piercing damage, have the (trait: agile), (trait: finesse), and (trait: unarmed) traits, and are in the brawling weapon group. In your humanoid shape, you retain the appearance of your original ancestry." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c1240478-f1b0-4bfa-963a-9ae169b57838"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
