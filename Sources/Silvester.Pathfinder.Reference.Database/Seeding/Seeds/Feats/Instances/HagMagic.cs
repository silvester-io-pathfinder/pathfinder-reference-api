using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HagMagic : Template
    {
        public static readonly Guid ID = Guid.Parse("1dd0ea25-42e4-429d-a928-e0d316775612");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Hag Magic",
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
            yield return new TextBlock { Id = Guid.Parse("7e98a762-345c-492e-a5a8-2aae4c15e88e"), Type = TextBlockType.Text, Text = "Through your heritage, you can replicate some of a hag&#39;s magic. Choose one common spell of 4th level or lower from those available to a coven, including the spells contributed to a coven by a hag of your mother&#39;s type. You can cast this spell once per day as a 4th-level occult innate spell." };
            yield return new TextBlock { Id = Guid.Parse("129e747b-bab4-46ba-8bc1-7b29feb3a33c"), Type = TextBlockType.Text, Text = "Spells available to all covens are (spell: augury), (spell: charm), (spell: clairaudience), (spell: clairvoyance), (spell: dream message), and (spell: illusory disguise). The eligible spells granted by the most prominent types of hag are: **Sea Hag** (spell: acid arrow), (spell: water walk); **Green Hag** (spell: entangle), (spell: outcast&#39;s curse), (spell: wall of thorns); **Annis Hag** (spell: earthbind); **Night Hag** (spell: nightmare)" };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("160f23c8-161f-46b2-b8d4-9074a80bb71b"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
