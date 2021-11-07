using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SummonEarthElemental : Template
    {
        public static readonly Guid ID = Guid.Parse("7c918192-c088-4203-8c53-b3ccc4c26a3d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Summon Earth Elemental",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d7c4d323-8dc9-486a-ada8-12e04b2f5fa2"), Type = TextBlockType.Text, Text = "You have a connection to the Inner Sphere, allowing you to summon an elemental ally. Once per day, you can cast (spell: summon elemental) as a 5th-level primal innate spell, but the elemental summoned must be an (trait: earth) elemental." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c81a46a8-b694-4771-9ce5-b894d7867805"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
