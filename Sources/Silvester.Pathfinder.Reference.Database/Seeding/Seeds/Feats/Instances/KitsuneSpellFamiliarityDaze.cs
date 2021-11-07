using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class KitsuneSpellFamiliarityDaze : Template
    {
        public static readonly Guid ID = Guid.Parse("2414c553-0177-4dbd-a7d8-a3ee0b7dd4ee");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Kitsune Spell Familiarity - Daze",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7597e55e-5dbc-4e19-b346-b188018887bd"), Type = TextBlockType.Text, Text = "Until your next daily preparations, you can cast (spell: daze) as a divine innate spell at will." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("61d4156f-b641-4979-8ce8-c4435e957b52"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
