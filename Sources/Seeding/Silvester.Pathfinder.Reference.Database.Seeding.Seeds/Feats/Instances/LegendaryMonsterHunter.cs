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
    public class LegendaryMonsterHunter : Template
    {
        public static readonly Guid ID = Guid.Parse("164a9022-85bc-492b-8dd7-772c5759564c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Legendary Monster Hunter",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d5f1025c-3f6f-442b-b927-1a49d24deeca"), Type = TextBlockType.Text, Text = $"Your knowledge of monsters is so incredible that it reveals glaring flaws in your prey. Your bonus from {ToMarkdownLink<Models.Entities.Feat>("Monster Hunter", Feats.Instances.MonsterHunter.ID)} (and the bonus from {ToMarkdownLink<Models.Entities.Feat>("Monster Warden", Feats.Instances.MonsterWarden.ID)} if you have it) increases from +1 to +2 for you and any allies who benefit." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("25fe8d14-e084-4e4e-86d0-f325cdbdced5"), Proficiencies.Instances.Legendary.ID, Skills.Instances.Nature.ID);
            builder.HaveSpecificFeat(Guid.Parse("89721678-1d5b-4abe-bc64-aacda3bb8b11"), Feats.Instances.MasterMonsterHunter.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Ranger.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d07d1c41-d465-4c97-b97b-1882b294fa28"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
