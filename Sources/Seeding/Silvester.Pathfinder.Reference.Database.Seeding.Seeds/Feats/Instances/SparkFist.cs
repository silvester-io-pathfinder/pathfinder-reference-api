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
    public class SparkFist : Template
    {
        public static readonly Guid ID = Guid.Parse("2bb05cf8-859b-46ad-b2f1-5e0c4e18d440");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Spark Fist",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per minute"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1dd2187f-fb36-428a-af4e-febfdc08d514"), Type = TextBlockType.Text, Text = $"~ Access: You are from Dongun Hold or Alkenstar." };
            yield return new TextBlock { Id = Guid.Parse("2ddd6d71-3470-4d02-af94-795b796c91ca"), Type = TextBlockType.Text, Text = $"You dust explosive black powder on your fist or glove before attacking, which combusts as you hit an opponent. The resulting pops of flame harm both you and your enemy. Until the end of your next turn, your fist loses the {ToMarkdownLink<Models.Entities.Trait>("nonlethal", Traits.Instances.Nonlethal.ID)} trait and deals an additional 1 fire damage on a successful {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)}. Each time you succeed on a fist {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)}, you take 1 fire damage. If your fist would deal more than one weapon damage die, the fire damage dealt on a successful {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)}, to both you and your opponent, is equal to the number of weapon damage dice." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("cf2d4ebc-409e-4765-9f52-feee07dd108b"), Proficiencies.Instances.Expert.ID, Skills.Instances.Crafting.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Dwarf.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Fire.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Manipulate.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("66c07473-dc6a-422b-84e0-b3270aa015e4"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
