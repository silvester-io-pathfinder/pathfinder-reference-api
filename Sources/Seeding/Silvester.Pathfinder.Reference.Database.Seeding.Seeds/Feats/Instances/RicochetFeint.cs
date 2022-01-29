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
    public class RicochetFeint : Template
    {
        public static readonly Guid ID = Guid.Parse("c54ce035-45b4-4462-9cb0-0657ba8af6c3");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Ricochet Feint",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("bead3396-9476-45ac-9d04-3cdfc486b8d7"), Type = TextBlockType.Text, Text = $"While in {ToMarkdownLink<Models.Entities.Feat>("Ricochet Stance", Feats.Instances.RicochetStance.ID)}, you can bounce a thrown weapon off a foe to distract them. You can attempt a {ToMarkdownLink<Models.Entities.SkillAction>("Feint", SkillActions.Instances.Feint.ID)} against a creature within the first range increment of a thrown weapon you are wielding, rather than only creatures within your melee reach." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("e79af622-9364-44d0-baaa-2405c54977ec"), Feats.Instances.RicochetStance.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("f3e66b50-a1c7-4eea-bffb-84ffbb653785"), Traits.Instances.Rogue.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("931eabb2-d116-477f-8fcf-37eeb6eefb3e"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
