using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BasicScrollCache : Template
    {
        public static readonly Guid ID = Guid.Parse("5834fe02-7f01-42fa-a92d-d6d16a87994e");

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
            yield return new TextBlock { Id = Guid.Parse("61c2e069-6868-404a-ad9d-58ad86709ec6"), Type = TextBlockType.Text, Text = $"You have a vast and overflowing collection of scroll scraps, riddled with errors and misspellings and leaking energy like a sieve. With enough care, you can coax these scroll scraps into functioning – briefly. Each day during your daily preparations, you can create a single temporary scroll containing a 1st-level spell. The spell must be a common spell from the Core Rulebook, or another spell you learned via {ToMarkdownLink<Models.Entities.SkillAction>("Learn a Spell", SkillActions.Instances.LearnASpell.ID)}, and it must come from a tradition in which you have the corresponding skill trained. This scroll is an unstable, temporary item and loses its magic the next time you make your daily preparations if you haven't already used it. It can't be used to {ToMarkdownLink<Models.Entities.SkillAction>("Learn the Spell", SkillActions.Instances.LearnASpell.ID)}." };
            yield return new TextBlock { Id = Guid.Parse("ffc46c97-3209-4686-9c56-53b8e6b2db8a"), Type = TextBlockType.Text, Text = $"At 8th level, add a second temporary scroll containing a 2nd-level spell." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("7ae8c8c3-48a6-4144-b2ff-ac8840d0d297"), Feats.Instances.ScrollTricksterDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Archetype.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f2b718b9-74e2-4dc6-9013-1c2632949b3f"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
