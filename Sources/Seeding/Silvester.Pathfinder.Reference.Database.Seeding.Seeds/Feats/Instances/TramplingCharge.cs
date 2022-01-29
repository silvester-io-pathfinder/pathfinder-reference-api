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
    public class TramplingCharge : Template
    {
        public static readonly Guid ID = Guid.Parse("26073549-c442-4c0d-812c-08427238a798");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Trampling Charge",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d3770906-b5ac-497c-ba78-e8c1033215b3"), Type = TextBlockType.Text, Text = $"You urge your mount forward, trampling enemies in your path. You command your mount to {ToMarkdownLink<Models.Entities.Action>("Stride", Actions.Instances.Stride.ID)} up to its Speed (or to {ToMarkdownLink<Models.Entities.Action>("Burrow", Actions.Instances.Burrow.ID)}, {ToMarkdownLink<Models.Entities.SkillAction>("Climb", SkillActions.Instances.Climb.ID)}, {ToMarkdownLink<Models.Entities.Action>("Fly", Actions.Instances.Fly.ID)}, or {ToMarkdownLink<Models.Entities.SkillAction>("Swim", SkillActions.Instances.Swim.ID)}, if it has the corresponding movement type), moving through the spaces of any foes in your path up to one size smaller than your mount. Your mount deals damage equal to the melee {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} using its legs to each creature whose space you move through, subject to a basic Reflex save against your mount's Athletics DC. On a critical failure, the creature also becomes flat-footed until the end of your next turn. You can damage a given creature only once during this movement." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("19b29625-91c3-4799-9f24-291ec72c9865"), Feats.Instances.CavalierDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("9105831d-45b7-491d-8646-7b248a1459df"), Traits.Instances.Archetype.ID);
            builder.Add(Guid.Parse("45deca12-2eaf-4865-8c4e-e893a10361e7"), Traits.Instances.Flourish.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3baf6ff1-c773-486e-a456-61076c28f4d8"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
