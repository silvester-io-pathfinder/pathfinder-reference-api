using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class KitsuneSpellFamiliarity : Template
    {
        public static readonly Guid ID = Guid.Parse("685b4561-7f8e-4de7-bfa5-b8e0202cf668");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Kitsune Spell Familiarity",
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
            yield return new TextBlock { Id = Guid.Parse("0cd9d3a9-6156-4629-9c57-249c544ffb8b"), Type = TextBlockType.Text, Text = $"You've picked up a few magical tricks. During your daily preparations, choose {ToMarkdownLink<Models.Entities.Spell>("daze", Spells.Instances.Daze.ID)}, {ToMarkdownLink<Models.Entities.Spell>("forbidding ward", Spells.Instances.ForbiddingWard.ID)}, or {ToMarkdownLink<Models.Entities.Spell>("ghost sound", Spells.Instances.GhostSound.ID)}. Until your next daily preparations, you can cast this cantrip as a divine innate spell at will. A cantrip is heightened to a spell level equal to half your level rounded up." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b40c96d2-de9e-4a1b-88cd-b56d5d75ef36"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
