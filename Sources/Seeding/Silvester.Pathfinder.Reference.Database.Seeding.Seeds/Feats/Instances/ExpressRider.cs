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
    public class ExpressRider : Template
    {
        public static readonly Guid ID = Guid.Parse("64110f55-2fca-460c-9ebc-9e6d948739db");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Express Rider",
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
            yield return new TextBlock { Id = Guid.Parse("47088dd8-a519-486e-a3b2-30bf19b1aa8a"), Type = TextBlockType.Text, Text = $"You know how to encourage your mount to cover ground quickly. When calculating your travel speed (page 479) for the day while mounted, you can attempt a Nature check to {ToMarkdownLink<Models.Entities.SkillAction>("Command an Animal", SkillActions.Instances.CommandAnAnimal.ID)} to increase your mount's travel speed. The DC is determined by the GM, but is typically based on the mount's level or the difficulty of the environment, whichever is harder. On a success, increase your mount's travel speed by half. This has no effect on your mount's movement in encounters." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("a6cf779f-d343-4486-a733-fe5d4d759bf6"), Proficiencies.Instances.Trained.ID, Skills.Instances.Nature.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Exploration.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.General.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Move.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Skill.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a066df6a-4e8e-4f42-b5c8-05d06891d06c"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
