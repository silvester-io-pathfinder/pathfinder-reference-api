using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HagMagic : Template
    {
        public static readonly Guid ID = Guid.Parse("a2b0904b-ac1a-4c9f-97b7-7ebdbdd2b03c");

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
            yield return new TextBlock { Id = Guid.Parse("c4c59b00-10e9-4a33-a595-abab5417afb6"), Type = TextBlockType.Text, Text = "Through your heritage, you can replicate some of a hag&#39;s magic. Choose one common spell of 4th level or lower from those available to a coven, including the spells contributed to a coven by a hag of your mother&#39;s type. You can cast this spell once per day as a 4th-level occult innate spell." };
            yield return new TextBlock { Id = Guid.Parse("e2b6692b-0258-4047-9333-d4ff74c56e52"), Type = TextBlockType.Text, Text = "Spells available to all covens are (spell: augury), (spell: charm), (spell: clairaudience), (spell: clairvoyance), (spell: dream message), and (spell: illusory disguise). The eligible spells granted by the most prominent types of hag are: **Sea Hag** (spell: acid arrow), (spell: water walk); **Green Hag** (spell: entangle), (spell: outcast&#39;s curse), (spell: wall of thorns); **Annis Hag** (spell: earthbind); **Night Hag** (spell: nightmare)" };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("af343637-4237-4007-a49d-9aa62781d346"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
