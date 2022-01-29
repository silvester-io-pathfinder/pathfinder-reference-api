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
    public class WaterSprint : Template
    {
        public static readonly Guid ID = Guid.Parse("093ff1bc-26f3-40c1-8250-863fb78eab9b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Water Sprint",
                Level = 7,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8a65c729-7a95-4def-988b-bb2945849c1f"), Type = TextBlockType.Text, Text = $"Experience and training have taught you that water has just enough surface tension for a master sprinter to traverse the surface. When you {ToMarkdownLink<Models.Entities.Action>("Stride", Actions.Instances.Stride.ID)} in a straight line, if you move at least half your Speed over ground, you can move any amount of the remaining distance across a level body of water. If you don't end your {ToMarkdownLink<Models.Entities.Action>("Stride", Actions.Instances.Stride.ID)} on solid ground, you fall into the water." };
            yield return new TextBlock { Id = Guid.Parse("e10beac1-91a7-4dfb-9cd4-e2e12ef4622e"), Type = TextBlockType.Text, Text = $"If you're legendary in Athletics, as long as you start on solid ground, any part of your {ToMarkdownLink<Models.Entities.Action>("Stride", Actions.Instances.Stride.ID)} can cross the water's surface, even if you aren't moving a straight line, though you still fall into the water if you don't end your movement on solid ground." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("bdbe730c-b277-4cb3-a3d6-afae78645780"), Proficiencies.Instances.Master.ID, Skills.Instances.Athletics.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.General.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Skill.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d5bee099-7109-4828-ac63-2a0c726b2bb5"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
