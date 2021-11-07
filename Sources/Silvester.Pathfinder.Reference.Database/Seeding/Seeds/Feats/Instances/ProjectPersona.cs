using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ProjectPersona : Template
    {
        public static readonly Guid ID = Guid.Parse("1a42e97b-d280-4aa0-9813-54a2072d43ee");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Project Persona",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("bc8ed3d6-d3c7-4ca4-8bf5-8d881be59d3a"), Type = TextBlockType.Text, Text = "Where others etch their armor to serve as a conduit for their imaginations, your vivid mind and bold personality allow you to project a more fitting persona over your lackluster armor. You change the shape and appearance of your armor to appear as ordinary or fine clothes of your imagining. The armor’s statistics don’t change. This effect lasts as long as you remain conscious and are wearing the armor. A creature can disbelieve the illusion by (action: Seeking | Seek) or touching your armor. The DC equals your Will DC." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d4d55beb-42b3-4acd-b666-343f78634452"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
