using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RitualReversion : Template
    {
        public static readonly Guid ID = Guid.Parse("ef9a423a-7238-455e-a1bf-721ca4bec1bc");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Ritual Reversion",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5fd86171-f4d7-4514-a839-9a765a6f0bf4"), Type = TextBlockType.Text, Text = $"You can temporarily revert to a less conspicuous form without diminishing your senses." };
            yield return new TextBlock { Id = Guid.Parse("f8076ac5-04e1-4a04-92fe-2fa14383709a"), Type = TextBlockType.Text, Text = $"You take the form of an ordinary specimen of the type of plant or fungus that most closely resembles you, reverting to your body's appearance just before your spirit joined with it. This otherwise has the effects of {ToMarkdownLink<Models.Entities.Spell>("tree shape", Spells.Instances.TreeShape.ID)}, except that your size remains Small." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("56de1d3d-af66-41de-8477-ea6ff8d7684e"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
