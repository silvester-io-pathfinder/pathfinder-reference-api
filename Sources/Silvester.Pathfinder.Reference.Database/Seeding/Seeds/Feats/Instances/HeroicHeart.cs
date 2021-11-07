using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HeroicHeart : Template
    {
        public static readonly Guid ID = Guid.Parse("bc0d5e69-e825-454e-aade-7773feb4d478");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Heroic Heart",
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
            yield return new TextBlock { Id = Guid.Parse("b0e265b1-c174-4f35-8d13-7eb54828d6ac"), Type = TextBlockType.Text, Text = "You gain a +1 status bonus to attack rolls, Perception checks, skill checks, and saves." };
            yield return new TextBlock { Id = Guid.Parse("c9a8e3a0-1c7c-41c9-8a7e-94d442fd1902"), Type = TextBlockType.Text, Text = "__Corruption Flaw__ You take a –1 penalty to attack rolls." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("33efc5e1-7d7a-4152-940e-73d844e4244d"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
