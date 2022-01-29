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
    public class EngineBay : Template
    {
        public static readonly Guid ID = Guid.Parse("ed771853-08da-4c80-930c-7b3ba637a276");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Engine Bay",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("88a68ca7-4206-48df-946b-43c347f3edb9"), Type = TextBlockType.Text, Text = $"You are practiced at working in vast garages of vehicles and can work on many machines at a time. When {ToMarkdownLink<Models.Entities.SkillAction>("Repairing", SkillActions.Instances.Repair.ID)} and spending the full 10 minutes, you can fix up to two objects. If you are a master in Crafting, you can fix up to four targets. If you're legendary in Crafting, you can fix up to eight targets. This feat has no effect when using {ToMarkdownLink<Models.Entities.Feat>("Quick Repair", Feats.Instances.QuickRepair.ID)} or another ability to reduce the time spent {ToMarkdownLink<Models.Entities.SkillAction>("Repairing", SkillActions.Instances.Repair.ID)}." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("93b7c440-4e1a-4fda-acf1-e5574141d027"), Feats.Instances.VehicleMechanicDedication.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("d383b974-da9d-4d21-ab38-e7a54ac475e6"), Proficiencies.Instances.Expert.ID, Skills.Instances.Crafting.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Archetype.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Skill.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c6c46475-dcd0-46cb-9d52-e5dd4160c40c"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
