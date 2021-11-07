using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DualStudies : Template
    {
        public static readonly Guid ID = Guid.Parse("a9c9110c-7373-4b94-bb86-2e4cfcd1daf3");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Dual Studies",
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
            yield return new TextBlock { Id = Guid.Parse("0ed4e8c0-e59d-4229-af50-514c90f279b6"), Type = TextBlockType.Text, Text = "You and your eidolon have some skills you practice on your own. Choose two skills. Your eidolon becomes trained in one of those skills and you become trained in the other skill. At 7th level, you each become an expert in the chosen skills. These skill proficiencies are not shared between you and your eidolon." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5b560f13-0ca0-48eb-aef6-0d6fa38837ae"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
