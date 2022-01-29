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
    public class ArmoredStealth : Template
    {
        public static readonly Guid ID = Guid.Parse("116d152d-de04-45ef-8921-3ca79098c20b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Armored Stealth",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ea2f3538-b4e0-4ec7-b2d1-c28abdbcaa3d"), Type = TextBlockType.Text, Text = $"You have learned techniques to adjust and modify your armor and movements to reduce the noise you make. When you wear non-{ToMarkdownLink<Models.Entities.Trait>("noisy", Traits.Instances.Noisy.ID)} armor with which you are trained, your penalty to Stealth checks is reduced by 1 (to a minimum penalty of 0). If you're a master in Stealth, reduce the penalty by 2, and if you're legendary, reduce the penalty by 3. If your armor has the {ToMarkdownLink<Models.Entities.Trait>("noisy", Traits.Instances.Noisy.ID)} trait, instead of reducing the penalty to Stealth checks, you ignore the effects of the {ToMarkdownLink<Models.Entities.Trait>("noisy", Traits.Instances.Noisy.ID)} trait, enabling you to remove the penalty with a sufficient Strength score as normal." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("bb3d4d84-eff6-4789-b561-b3fccc7ce1e4"), Proficiencies.Instances.Expert.ID, Skills.Instances.Stealth.ID);
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
                Id = Guid.Parse("9660d5ad-5838-4be8-bf68-1d6bfd8f47bc"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
