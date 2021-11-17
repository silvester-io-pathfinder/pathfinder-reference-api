using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Lunge : Template
    {
        public static readonly Guid ID = Guid.Parse("0e255784-52ce-476d-b4b1-43e67eac4e67");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Lunge",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a96d4fcf-bcdc-4e10-afd0-da0106d3ddba"), Type = TextBlockType.Text, Text = "Extending your body to its limits, you attack an enemy that would normally be beyond your reach. Make a (Action: Strike) with a melee weapon, increasing your reach by 5 feet for that (Action: Strike). If the weapon has the (trait: disarm), (trait: shove), or (trait: trip) trait, you can use the corresponding action instead of a (Action: Strike)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ca1ea097-9c08-420f-93c7-05bdb7d59cee"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
