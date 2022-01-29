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
    public class LegendaryShot : Template
    {
        public static readonly Guid ID = Guid.Parse("64f9e2ea-fe9c-4eee-b1ed-eba12b7e240c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Legendary Shot",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f5266945-71eb-4682-97b6-129fd43ad0c6"), Type = TextBlockType.Text, Text = $"You focus on your hunted prey, perceiving angles, air resistance, and every variable that would affect your ranged attack. If you have master proficiency with your ranged weapon, you can ignore the penalty for attacking up to five range increments away when attacking your hunted prey." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificClassFeature(Guid.Parse("42a8ad3b-3d9a-4891-b214-c63423fbc13d"), ClassFeatures.Rangers.MasterfulHunter.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("b2c40d9a-06bb-482b-a851-e61b4dae707d"), Proficiencies.Instances.Legendary.ID, Skills.Instances.Perception.ID);
            builder.HaveSpecificFeat(Guid.Parse("b83cd158-d0d5-4536-95fd-007160c688eb"), Feats.Instances.FarShot.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("c4fc844a-065c-4960-b179-989dd25e9b49"), Traits.Instances.Ranger.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6bfdfacb-11ae-42c1-b75c-0fa92c539916"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
