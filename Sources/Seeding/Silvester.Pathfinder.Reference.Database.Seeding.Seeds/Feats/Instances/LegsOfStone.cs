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
    public class LegsOfStone : Template
    {
        public static readonly Guid ID = Guid.Parse("35bda0ba-2e94-4f03-a772-29b4a407330d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Legs of Stone",
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
            yield return new TextBlock { Id = Guid.Parse("e045bdee-a675-4736-98e3-cceca960e4e7"), Type = TextBlockType.Text, Text = $"You gain a +2 status bonus to your Fortitude and Reflex DCs against attempts to {ToMarkdownLink<Models.Entities.SkillAction>("Shove", SkillActions.Instances.Shove.ID)} or {ToMarkdownLink<Models.Entities.SkillAction>("Trip", SkillActions.Instances.Trip.ID)} you. You can {ToMarkdownLink<Models.Entities.SkillAction>("Shove", SkillActions.Instances.Shove.ID)} creatures even if you don't have a hand free. When you successfully {ToMarkdownLink<Models.Entities.SkillAction>("Shove", SkillActions.Instances.Shove.ID)} a foe, you can {ToMarkdownLink<Models.Entities.Action>("Stride", Actions.Instances.Stride.ID)} away from your opponent (instead of toward it), but you must move the same distance in the opposite direction from where you {ToMarkdownLink<Models.Entities.SkillAction>("Shoved", SkillActions.Instances.Shove.ID)} it." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("068faf0d-9ecf-4e7c-a025-1121acad808f"), Feats.Instances.GolemGrafterDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Archetype.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a530ad7e-6ce2-47fa-916b-021625a16eb6"),
                SourceId = Sources.Instances.ExtinctionCurse.ID,
                Page = -1
            };
        }
    }
}
