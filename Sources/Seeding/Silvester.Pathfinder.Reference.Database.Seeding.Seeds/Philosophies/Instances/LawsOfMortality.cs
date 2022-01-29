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
    public class LawsOfMortality : Template
    {
        public static readonly Guid ID = Guid.Parse("c7e865d2-0eb0-4d60-acd5-995037b72d53");
        
        protected override Philosophy GetPhilosophy()
        {
            return new Philosophy
            {
                Id = ID, 
                Name = "Laws of Mortality",
                Edicts = "Challenge religious power and the spread of religion, expose and eradicate hidden worship, provide a peaceful and autonomous society in which the people are cared for through social infrastructure.",
                Anathema = "Worship or swear an oath by a deity or religion, solicit or receive divine or religious aid, take a side in conflicts between religions.",
                AreasOfConcern = "mortal affairs, peace, self-rule"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("83cc5f52-9d19-4c15-9848-c6408ac8485e"), Type = TextBlockType.Text, Text = "The Laws of Mortality originated in the Garundi nation of Rahadoum as a response to the Oath Wars, a series of internecine conflicts that were tearing the nation's society apart. The fundamental principle behind the Laws is a relatively simple assertion that deific aid - even the best intentioned - ultimately comes at too high a price. The slaughter of fellow mortals for the glory of distant, unfathomable beings is not something that should be permitted within a society. Instead, mortal beings must shape their own fate, aware of their own limitations, trusting in their reliance upon one another and their shared values rather than divine intervention and guidance. This philosophy is summed up in the primary tenet of the Laws of Mortality: Let no mortal be beholden to a god." };
        }

        protected override IEnumerable<Guid> GetRequiredAlignments()
        {
            yield return Alignments.Instances.LawfulGood.ID;
            yield return Alignments.Instances.NeutralGood.ID;
            yield return Alignments.Instances.LawfulNeutral.ID;
            yield return Alignments.Instances.TrueNeutral.ID;
            yield return Alignments.Instances.LawfulEvil.ID;
            yield return Alignments.Instances.NeutralEvil.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c9418afe-9b59-4e2f-a68f-a59dd0abf8e4"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 97
            };
        }
    }
}
