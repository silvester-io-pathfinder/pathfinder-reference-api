using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BoundlessReprisals : Template
    {
        public static readonly Guid ID = Guid.Parse("44d0d8e4-37dd-4636-badd-7a3a26661620");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Boundless Reprisals",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("97544a3e-5e2b-4e8b-92f9-be42e9dca11d"), Type = TextBlockType.Text, Text = "With a sixth sense for the flow of combat, you can quickly react to any situation as required. At the start of each enemy's turn, you gain a reaction you can use only during that turn." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8f700060-0ec5-4c10-8443-7543fb99d379"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
