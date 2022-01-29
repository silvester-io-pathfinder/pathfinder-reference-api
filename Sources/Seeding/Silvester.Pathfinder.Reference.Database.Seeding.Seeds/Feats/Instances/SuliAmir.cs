using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SuliAmir : Template
    {
        public static readonly Guid ID = Guid.Parse("ba8c380f-28b4-4a13-8013-b8cbb9c610fe");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Suli Amir",
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
            yield return new TextBlock { Id = Guid.Parse("4d8b03a8-f069-45ac-9313-8a22eab2c13a"), Type = TextBlockType.Text, Text = $"You have power connected to the powerful jann amirs. You can cast {ToMarkdownLink<Models.Entities.Spell>("read omens", Spells.Instances.ReadOmens.ID)} and 4th-level {ToMarkdownLink<Models.Entities.Spell>("invisibility", Spells.Instances.Invisibility.ID)} each once per day as arcane innate spells, and you can cast {ToMarkdownLink<Models.Entities.Spell>("detect magic", Spells.Instances.DetectMagic.ID)} at will as an arcane innate cantrip, heightened to a spell level equal to half your level rounded up." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b5984179-1a4d-456f-9723-9501ade4e145"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
