using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class JungleStrider : Template
    {
        public static readonly Guid ID = Guid.Parse("9be78b6f-22e6-4da5-beca-8397fdb061c8");

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
            yield return new TextBlock { Id = Guid.Parse("aea36d16-f36e-4fde-8b9c-eafba7f6ae8c"), Type = TextBlockType.Text, Text = "You are adept at dodging roots, foliage, and other jungle obstacles. You ignore difficult terrain in forests and jungles. In addition, when you use the Acrobatics skill to (action: Balance) on narrow surfaces or uneven ground made of plant material, you aren't flat-footed, and when you roll a success at one of these Acrobatics checks, you get a critical success instead." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7e84bcfd-2b2e-4c99-96c3-e8ea204723e1"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}