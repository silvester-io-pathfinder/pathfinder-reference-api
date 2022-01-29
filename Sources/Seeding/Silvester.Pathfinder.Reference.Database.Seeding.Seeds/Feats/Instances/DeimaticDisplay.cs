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
    public class DeimaticDisplay : Template
    {
        public static readonly Guid ID = Guid.Parse("e50366e9-e17e-4e56-bf4a-560badf65061");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Deimatic Display",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d5cbb6c7-2ef0-400a-b50d-904b4a06cee5"), Type = TextBlockType.Text, Text = $"Imitating animal threat displays, you make yourself appear larger and more imposing. Roll one Intimidation check to {ToMarkdownLink<Models.Entities.SkillAction>("Demoralize", SkillActions.Instances.Demoralize.ID)} and compare the result to the Will DC of each animal, fungus, and plant creature in a 15-foot cone. When you do, {ToMarkdownLink<Models.Entities.SkillAction>("Demoralize", SkillActions.Instances.Demoralize.ID)} gains the {ToMarkdownLink<Models.Entities.Trait>("visual", Traits.Instances.Visual.ID)} trait, and creatures are affected if they can see you. You don't take a penalty if the creature doesn't understand your language." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("e24de699-3aed-4e2e-8bf8-209c1937bb3b"), Proficiencies.Instances.Trained.ID, Skills.Instances.Intimidation.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("50041000-9329-4083-ae0e-66ff46289b60"), Traits.Instances.Druid.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fe75c230-04f0-4a9e-93f3-b94068a76e9b"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
