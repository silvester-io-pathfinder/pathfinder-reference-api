using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HeroicHeart : Template
    {
        public static readonly Guid ID = Guid.Parse("d3c359f7-3aa9-47e0-a9eb-138ec5f3a7b7");

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
            yield return new TextBlock { Id = Guid.Parse("9366eb8f-b3d2-430d-b37f-71a7e7e2d934"), Type = TextBlockType.Text, Text = "You gain a +1 status bonus to attack rolls, Perception checks, skill checks, and saves." };
            yield return new TextBlock { Id = Guid.Parse("10a92901-cd30-4679-b774-988c26ed7da5"), Type = TextBlockType.Text, Text = "__Corruption Flaw__ You take a –1 penalty to attack rolls." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3fcfc402-ec85-495d-a3f9-cb3c157679f6"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
