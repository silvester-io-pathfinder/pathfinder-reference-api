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
    public class PropheciesOfKalistrade : Template
    {
        public static readonly Guid ID = Guid.Parse("");
        
        protected override Philosophy GetPhilosophy()
        {
            return new Philosophy
            {
                Id = ID, 
                Name = "Prophecies of Kalistrade",
                Edicts = "Accumulate personal wealth, seek enlightenment through purity of self, foster and aid mercantile pursuits, welcome newcomers regardless of gender or ancestry.",
                Anathema = "Spend money frivolously; offer money to those who don't deserve wealth; overindulge in physical pleasures, food, or drink; give charity to others.", 
                AreasOfConcern = "Trade, wealth, self-denial, stability."
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "The secular prophecies of Kalistrade are famously centered on a single principle: amassing personal wealth both in search of and as evidence of personal enlightenment. The prophets of Kalistrade, often referred to as Kalistocrats, believe that achieving purity of body, mind, and spirit will lead to financial success, and thus they avoid certain foods and eschew contact with most persons and objects as impure. To avoid contamination and contact with nonbelievers they wear long, white gloves, and they wear distinctive, all-white clothing to represent their purity—often incorporating their symbol, a circle inside a triangle that is itself inscribed in a larger circle." };
        }

        protected override IEnumerable<Guid> GetRequiredAlignments()
        {
            yield return Alignments.Instances.LawfulGood.ID;
            yield return Alignments.Instances.LawfulNeutral.ID;
            yield return Alignments.Instances.LawfulEvil.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.GodsAndMagic.ID,
                Page = 99
            };
        }
    }
}
