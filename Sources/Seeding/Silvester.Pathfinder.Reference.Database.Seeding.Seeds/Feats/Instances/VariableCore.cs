using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class VariableCore : Template
    {
        public static readonly Guid ID = Guid.Parse("40d38c39-8087-43e3-bc30-03a703379517");

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
            yield return new TextBlock { Id = Guid.Parse("98abda9b-8a27-4223-9b40-9c3052d9e48c"), Type = TextBlockType.Text, Text = $"You adjust your innovation's core, changing the way it explodes. When you choose this feat, select acid, cold, or electricity. Your innovation's core runs on that power source. When using the {ToMarkdownLink<Models.Entities.Feat>("Explode", Feats.Instances.Explode.ID)} action, or any time your innovation explodes on a critical failure and damages you, change the damage type from fire damage to the type you chose." };
            yield return new TextBlock { Id = Guid.Parse("faddd02f-d7c7-44b6-88e2-5f3d46072068"), Type = TextBlockType.Text, Text = $"If you have the offensive boost class feature and retrain Variable Core to a different damage type, you can also switch to a different offensive boost that deals the same damage type if you wish." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4b3d66c3-9474-4c38-bdd0-2ec3465fcef0"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
