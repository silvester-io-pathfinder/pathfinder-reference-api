using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class VariableCore : Template
    {
        public static readonly Guid ID = Guid.Parse("f68b30b5-7384-4eac-bca5-ac604337e991");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Variable Core",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7a9846ff-2a2d-4fa7-bb92-a392812e5a0c"), Type = TextBlockType.Text, Text = "You adjust your innovation’s core, changing the way it explodes. When you choose this feat, select acid, cold, or electricity. Your innovation’s core runs on that power source. When using the (action: Explode) action, or any time your innovation explodes on a critical failure and damages you, change the damage type from fire damage to the type you chose." };
            yield return new TextBlock { Id = Guid.Parse("06b044a2-9a73-45e7-bbf9-14f49e744476"), Type = TextBlockType.Text, Text = "If you have the offensive boost class feature and retrain Variable Core to a different damage type, you can also switch to a different offensive boost that deals the same damage type if you wish." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b3d49a01-afdd-4b09-b99c-ae4cae91f77d"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
