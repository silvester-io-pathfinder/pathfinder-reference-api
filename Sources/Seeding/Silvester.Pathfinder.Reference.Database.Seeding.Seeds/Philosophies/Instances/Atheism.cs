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
    public class Atheism : Template
    {
        public static readonly Guid ID = Guid.Parse("e03fd3bd-d9bf-42b6-b917-2a7902133917");
        
        protected override Philosophy GetPhilosophy()
        {
            return new Philosophy
            {
                Id = ID, 
                Name = "Atheism",
                Edicts = null,
                Anathema = null,
                AreasOfConcern = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("000a8d4d-da55-4ba1-9440-04bf7521a17e"), Type = TextBlockType.Text, Text = "In a world where the gods demonstrably exist, few people uphold a strictly atheistic or agnostic worldview; that is, a belief that there are no gods, or that the existence of gods is unknowable. However, a good number of people choose not to worship any deities whatsoever. Many do so because of the value they place on freedom - not being beholden to a deity means no limitations, no censure, no anathema, and no strictures. While this decision might sound amoral to some, for atheists, it can be motivated by a desire for autonomy and the right to choose one's own fate." };
        }

        protected override IEnumerable<Guid> GetRequiredAlignments()
        {
            yield return Alignments.Instances.LawfulGood.ID;
            yield return Alignments.Instances.ChaoticGood.ID;
            yield return Alignments.Instances.NeutralGood.ID;
            yield return Alignments.Instances.LawfulEvil.ID;
            yield return Alignments.Instances.ChaoticEvil.ID;
            yield return Alignments.Instances.NeutralEvil.ID;
            yield return Alignments.Instances.ChaoticNeutral.ID;
            yield return Alignments.Instances.LawfulNeutral.ID;
            yield return Alignments.Instances.TrueNeutral.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0257f991-ba5d-41cc-a3e5-ede97d14b7ce"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 97
            };
        }
    }
}
