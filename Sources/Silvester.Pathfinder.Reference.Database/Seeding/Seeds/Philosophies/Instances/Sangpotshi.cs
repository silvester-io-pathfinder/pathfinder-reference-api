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
    public class Sangpotshi : Template
    {
        public static readonly Guid ID = Guid.Parse("");
        
        protected override Philosophy GetPhilosophy()
        {
            return new Philosophy
            {
                Id = ID, 
                Name = "Sangpotshi",
                Edicts = "Live selflessly; heed the wisdom of the learned, the wise, and those in stations of authority.",
                AreasOfConcern = "Needlessly break significant traditions, actively interfere with the perfection efforts of another soul or allow others to do so.", 
                Anathema = "Fate, karma, and reincarnation."
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "The philosophy of Sangpotshi, also known as the River of Life, centers around concepts of fate, karma, and cyclic reincarnation. Adherents believe each soul is judged upon its actions in life, and these actions determine its station when it returns to the living world. This cycle repeats until the soul reaches its perfected form through the accrual of experience and wisdom, whereupon it passes on to Pharasma�s court and the afterlife to come." };
        }

        protected override IEnumerable<Guid> GetRequiredAlignments()
        {
            yield return Alignments.Instances.LawfulGood.ID;
            yield return Alignments.Instances.NeutralGood.ID;
            yield return Alignments.Instances.LawfulNeutral.ID;
            yield return Alignments.Instances.TrueNeutral.ID;
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
