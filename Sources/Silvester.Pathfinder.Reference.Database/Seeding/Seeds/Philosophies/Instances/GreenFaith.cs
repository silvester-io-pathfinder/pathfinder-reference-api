using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Philosophies.Instances
{
    public class GreenFaith : Template
    {
        public static readonly Guid ID = Guid.Parse("");
        
        protected override Philosophy GetPhilosophy()
        {
            return new Philosophy
            {
                Id = ID, 
                Name = "Green Faith",
                Edicts = "Guide civilization to grow in harmony with nature, live sustainably and according to natural cycles, preserve areas of natural wilderness, protect the balance of nature, protect endangered species.",
                Anathema = "Cause damage to natural settings, kill animals for reasons other than self-defense or sustenance, remove an element or indigenous species from a natural area, encourage imbalance in nature, allow abuse of natural resources.",
                AreasOfConcern = "Veneration of the natural world."
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "While the Green Faith is practiced differently from one believer to another, especially across its various orders, its adherents share a universal reverence for the natural world and a commitment to preserving it. While each order’s practitioners may be drawn to a particular element, season, creature, or natural occurrence, all followers respect the sanctity and importance of every aspect of nature." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Many cycles have passed since the Green Faith’s fabled founders contended over which expression of natural power was supreme. Just as the legend speaks of their ultimate unity, those who now follow the Green Faith and view nature as sacred understand the interconnectedness of all beings, recognizing that harmony is possible only through balance, and that the cycles of nature are both delicate and infinite. Advocates of the Green Faith therefore fall into a neutral alignment, for they understand that by naming one thing, its opposite is also created; they walk the path of balance between death and rebirth, light and shadow, growth and decay." };
        }

        protected override IEnumerable<Guid> GetRequiredAlignments()
        {
            yield return Alignments.Instances.NeutralGood.ID;
            yield return Alignments.Instances.LawfulNeutral.ID;
            yield return Alignments.Instances.TrueNeutral.ID;
            yield return Alignments.Instances.ChaoticNeutral.ID;
            yield return Alignments.Instances.NeutralEvil.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.GodsAndMagic.ID,
                Page = 97
            };
        }
    }
}
