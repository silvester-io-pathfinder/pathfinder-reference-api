using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BasicScrollCache : Template
    {
        public static readonly Guid ID = Guid.Parse("71d77451-46bd-4bf4-af73-f991bc5a77a3");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Basic Scroll Cache",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b8e03cee-0a77-46c5-a8ab-06696d7598a6"), Type = TextBlockType.Text, Text = "You have a vast and overflowing collection of scroll scraps, riddled with errors and misspellings and leaking energy like a sieve. With enough care, you can coax these scroll scraps into functioning – briefly. Each day during your daily preparations, you can create a single temporary scroll containing a 1st-level spell. The spell must be a common spell from the Core Rulebook, or another spell you learned via (action: Learn a Spell), and it must come from a tradition in which you have the corresponding skill trained. This scroll is an unstable, temporary item and loses its magic the next time you make your daily preparations if you haven’t already used it. It can’t be used to (action: Learn the Spell | Learn a Spell)." };
            yield return new TextBlock { Id = Guid.Parse("c86b1f25-8f9b-4ae3-b6aa-ac3d678d9c6f"), Type = TextBlockType.Text, Text = "At 8th level, add a second temporary scroll containing a 2nd-level spell." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("1eba5bfd-8889-4eb9-beec-d05bb42b4b61"), Feats.Instances.ScrollTricksterDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("77aa85f3-ffe8-408e-ac16-2627f5180a02"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
