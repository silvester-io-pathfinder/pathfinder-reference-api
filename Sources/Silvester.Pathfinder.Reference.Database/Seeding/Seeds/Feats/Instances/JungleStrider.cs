using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class JungleStrider : Template
    {
        public static readonly Guid ID = Guid.Parse("30d12389-269f-4195-be99-34ead3475f98");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Jungle Strider",
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
            yield return new TextBlock { Id = Guid.Parse("4527a206-fb13-4a8d-9403-eb691895c40a"), Type = TextBlockType.Text, Text = "You are adept at dodging roots, foliage, and other jungle obstacles. You ignore difficult terrain in forests and jungles. In addition, when you use the Acrobatics skill to (action: Balance) on narrow surfaces or uneven ground made of plant material, you aren’t flat-footed, and when you roll a success at one of these Acrobatics checks, you get a critical success instead." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d51ffead-e8a8-4059-afb3-2b52c4338e43"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
