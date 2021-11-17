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
    public class WhisperingWay : Template
    {
        public static readonly Guid ID = Guid.Parse("1fcac5bd-61ae-4a7a-8b2b-bdd5e99348ed");
        
        protected override Philosophy GetPhilosophy()
        {
            return new Philosophy
            {
                Id = ID, 
                Name = "Whispering Way",
                Edicts = "Seek methods to become undead (a lich if possible), oppose those who seek to destroy undead, protect necromantic secrets, serve the Whispering Tyrant.",
                Anathema = "Destroy necromantic texts (unless they reveal secrets of the Whispering Way), teach others of the Whispering Way other than by whispering, use positive energy to harm undead.", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("689f4589-280a-4f79-90bc-62bbc21ec9dc"), Type = TextBlockType.Text, Text = "These cultists believe undeath is the truest form of existence, and life is meant to be spent in preparation for transition to a more glorious unlife after death." };
        }

        protected override IEnumerable<Guid> GetRequiredAlignments()
        {
            yield return Alignments.Instances.LawfulEvil.ID;
            yield return Alignments.Instances.NeutralEvil.ID;
            yield return Alignments.Instances.ChaoticEvil.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bfc4450a-1358-49e6-967c-936880e0dfbc"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 441
            };
        }
    }
}
