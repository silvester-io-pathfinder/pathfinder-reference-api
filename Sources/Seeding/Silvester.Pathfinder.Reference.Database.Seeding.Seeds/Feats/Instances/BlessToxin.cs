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
    public class BlessToxin : Template
    {
        public static readonly Guid ID = Guid.Parse("e83f638f-0103-4063-977d-3e657ac3f6b1");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Bless Toxin",
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
            yield return new TextBlock { Id = Guid.Parse("7cd757e4-546f-4cb3-838a-19a2403ac5cc"), Type = TextBlockType.Text, Text = $"You pour negative energy into toxins you create to further debilitate your targets. When you {ToMarkdownLink<Models.Entities.SkillAction>("Craft", SkillActions.Instances.Craft.ID)} an alchemical poison (rather than create it with advanced alchemy, {ToMarkdownLink<Models.Entities.Feat>("Quick Alchemy", Feats.Instances.QuickAlchemy.ID)}, or another means), it becomes a blessed alchemical poison and gains the {ToMarkdownLink<Models.Entities.Trait>("negative", Traits.Instances.Negative.ID)} trait. When a creature is afflicted with a blessed alchemical poison, for 1 round, any Hit Points it would regain from a positive effect are reduced by 5, or by 10 if you are legendary in Crafting." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("0209f277-26ea-4908-ac2b-6c6ac0fe834b"), Proficiencies.Instances.Master.ID, Skills.Instances.Crafting.ID);
            builder.HaveAnyDeitySpecificFont(Guid.Parse("d2bbc76f-4653-4799-a8af-67c7ccdca91e"), DivineFonts.Instances.Harm.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("04a51d51-9a1d-42fb-863b-0aee38486853"), Traits.Instances.General.ID);
            builder.Add(Guid.Parse("fa77e816-6354-4b1c-ac43-108a7acc5a80"), Traits.Instances.Negative.ID);
            builder.Add(Guid.Parse("f80b7cf9-126b-4da1-bb45-c3dfa16a5b7d"), Traits.Instances.Skill.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("590b4a32-6536-40a9-a814-2668fa33c0c4"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = -1
            };
        }
    }
}
