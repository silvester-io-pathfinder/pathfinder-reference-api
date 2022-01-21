using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ProjectPersona : Template
    {
        public static readonly Guid ID = Guid.Parse("072c0fbb-de6e-40ff-a50b-5a96cf2dbf33");

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
            yield return new TextBlock { Id = Guid.Parse("0081a615-4090-4d2c-bbfa-216ee88c3dfe"), Type = TextBlockType.Text, Text = "Where others etch their armor to serve as a conduit for their imaginations, your vivid mind and bold personality allow you to project a more fitting persona over your lackluster armor. You change the shape and appearance of your armor to appear as ordinary or fine clothes of your imagining. The armor's statistics don't change. This effect lasts as long as you remain conscious and are wearing the armor. A creature can disbelieve the illusion by (action: Seeking | Seek) or touching your armor. The DC equals your Will DC." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("86f20101-834c-4bdd-948b-0a829a615e6e"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}